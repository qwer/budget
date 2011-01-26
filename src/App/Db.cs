using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using Budget.Model;

using System.Data.Objects;
using System.Data.Objects.DataClasses;

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
			}
		}
	}
}
