using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

using System.Threading.Tasks;

using Budget.Model;

namespace Budget.App
{
	public class Db
	{
		public Db()
		{
		}

		public event PropertyChangedEventHandler ConnectionStateChanged;
		
		private ConnectionState connectionState = ConnectionState.Closed;
		public ConnectionState ConnectionState
		{
			get { return connectionState; }
			set
			{
				if (connectionState == value)
					return;
				connectionState = value;
				if (ConnectionStateChanged != null)
					ConnectionStateChanged(this, null);
			}
		}

		public BudgetModelContainer Container { get; set; }

		public void Connect()
		{
			try
			{
				ConnectionState = ConnectionState.Connecting;

				ConnectionStringBuilder csb = new ConnectionStringBuilder();
				csb.DbPath = Properties.Settings.Default.DbPath;
				csb.Db = "BudgetModel";

				Container = new BudgetModelContainer(csb.ToString());
				ConnectionState = ConnectionState.Open;
				Container.Connection.StateChange += Connection_StateChange;
			}
			catch (Exception ex)
			{
				ConnectionState = ConnectionState.Closed;
				throw ex;
			}

			Play();
			
		}

		void Connection_StateChange(object sender, StateChangeEventArgs e)
		{
			//ConnectionState = e.CurrentState;
		}

		private ObjectStateEntry GetState(EntityObject obj)
		{
			return Container.ObjectStateManager.GetObjectStateEntry(obj.EntityKey);
		}

		internal void Undo(EntityObject obj)
		{
			var entry = GetState(obj);

			for (int i = 0; i < entry.OriginalValues.FieldCount; i++)
			{
				entry.CurrentValues.SetValue(i, entry.OriginalValues[i]);
			}

			entry.AcceptChanges();
		}

		public bool IsModified(EntityObject obj)
		{
			return 0 < Enumerable.Count(
				GetState(obj).GetModifiedProperties());
		}

		public event EventHandler HistoryAdded;
		public event EventHandler AccountAdded;
		public event EventHandler IncomeAdded;

		public void AddHistory(History history)
		{
			history.AccountDest.Balance += history.Amount;
			if (history.AccountSrc != null)
				history.AccountSrc.Balance -= history.Amount;
			
			Container.HistorySet.AddObject(history);

			try
			{
				Container.SaveChanges();
				
			}
			catch (Exception e)
			{
				Error.Show(e);
				Container.Detach(history);
				Undo(history.AccountDest);
				Undo(history.AccountSrc);
				return;
			}

			if (HistoryAdded != null)
				HistoryAdded(history, null);
		}

		public void AddIncome(Income income)
		{
			bool added = income.EntityState == EntityState.Added;
			if (added)
				Container.IncomeSet.AddObject(income);

			try
			{
				Container.SaveChanges();
			}
			catch (Exception e)
			{
				Error.Show(e);
				if (added)
					Container.Detach(income);
				return;
			}
			
			if (player != null)
			{
				if (added)
					player.OnIcomeAdded(income);
				else
					player.OnIncomeChanged(income);
			}

			if (added && IncomeAdded != null)
				IncomeAdded(income, null);
		}

		public void AddAccount(Account account)
		{
			bool added = account.EntityState == EntityState.Added;
			if (added)
				Container.AccountSet.AddObject(account);

			try
			{
				Container.SaveChanges();
			}
			catch (Exception e)
			{
				Error.Show(e);
				if (added)
					Container.Detach(account);
				return;
			}

			if (added && AccountAdded != null)
				AccountAdded(account, null);
		}

		public List<Tuple<Income, DateTime>> GetEvents(DateTime start, DateTime end)
		{
			var events = new List<Tuple<Income,DateTime>>();
			foreach (Income i in Container.IncomeSet)
			{
				for (DateTime
						dt = i.Period2.GetNearestEvent(start);
						dt < end;
						dt = i.Period2.GetNearestEvent(dt))
				{
					events.Add(Tuple.Create(i, dt));
					if (events.Count > 1000)
						break;
				}
			}

			events.Sort(new Comparison<Tuple<Income, DateTime>>(
				(t1, t2) => (t1.Item2 > t2.Item2) ? 1 : ((t1.Item2 == t2.Item2) ? 0 : -1)));

			return events;
		}

		public void CreateIncomeTx(Income income, DateTime datetime)
		{
			History h = new History();

			h.AccountDest = income.Account;
			h.AccountSrc = null;
			h.Amount = income.Amount;
			h.Date = datetime;
			h.Description = "";
			h.Income = income;

			AddHistory(h);
		}

		public List<Tuple<Income, DateTime>> GetPendingTransactions()
		{
			DateTime last = Container.HistorySet.Max(h => h.Date);
			DateTime now = DateTime.Now;
			return GetEvents(last, now);
		}

		Player player;

		private void Play()
		{
			DateTime last = Container.HistorySet.Max(h => h.Date);
			DateTime now = DateTime.Now;
			var events = GetEvents(last, now);
			if (!ShowEvents(events))
				return;

			foreach (var t in events)
			{
				CreateIncomeTx(t.Item1, t.Item2);
			}

			player = new Player(this);
			player.Start(now);

			/*
			var f = new System.Windows.Forms.Form();
			var pb = new System.Windows.Forms.ProgressBar();
			pb.Dock = System.Windows.Forms.DockStyle.Fill;
			f.Controls.Add(pb);
			f.Show();
			*/
		}

		public bool ShowEvents(List<Tuple<Income, DateTime>> events)
		{
			string s = "";
			foreach (var t in events)
			{
				s += String.Format("{2}   {0} {1} {3}\r\n", t.Item1.Name, t.Item1.Amount, t.Item2, t.Item1.Period2.Format);
			}

			var f = new System.Windows.Forms.Form();
			var tb = new System.Windows.Forms.TextBox();
			tb.Multiline = true;
			tb.Dock = System.Windows.Forms.DockStyle.Fill;
			tb.Text = s;
			tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			f.Controls.Add(tb);
			var b = new System.Windows.Forms.Button();
			b.Dock = System.Windows.Forms.DockStyle.Top;
			b.Text = "OK";
			f.Controls.Add(b);
			b.Click += delegate(object o, EventArgs e) { f.DialogResult = System.Windows.Forms.DialogResult.OK; f.Close(); };
			return f.ShowDialog() == System.Windows.Forms.DialogResult.OK;
		}
	}
}
