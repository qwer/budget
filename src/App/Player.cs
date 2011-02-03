using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

using Budget.Model;

namespace Budget.App
{
	class Player
	{
		
		public Player(Db db)
		{
			this.db = db;

			timer.AutoReset = false;
			timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
		}

		private Db db;

		Dictionary<Income, DateTime> nextEvents = new Dictionary<Income, DateTime>();
		Income nextEventIncome;
		DateTime nextEvent = DateTime.MaxValue;

		Timer timer = new Timer();

		public void Start(DateTime now)
		{
			nextEvent = DateTime.MaxValue;
			foreach (Income i in db.Container.IncomeSet)
			{
				if ((nextEvents[i] = i.Period2.GetNearestEvent(now)) < nextEvent)
				{
					nextEvent = nextEvents[i];
					nextEventIncome = i;
				}
			}

			//System.Windows.Forms.MessageBox.Show(nextEvent.ToString());
			SetupTimer();
		}

		void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			if (DateTime.Now < nextEvent)
			{
				SetupTimer();
				return;
			}

			db.CreateIncomeTx(nextEventIncome, nextEvent);

			nextEvents[nextEventIncome] = nextEventIncome.Period2.GetNearestEvent(nextEvent);

			nextEvent = DateTime.MaxValue;
			foreach (Income i in nextEvents.Keys)
				if (nextEvents[i] < nextEvent)
				{
					nextEvent = nextEvents[i];
					nextEventIncome = i;
				}

			SetupTimer();
		}

		private void SetupTimer()
		{
			DateTime now = DateTime.Now;
			timer.Interval = nextEvent > now ? (nextEvent - now).TotalMilliseconds : 1;
			timer.Start();
		}

		public void OnIcomeAdded(Income income)
		{
			UpdateNextEvent(income);
		}

		public void OnIncomeChanged(Income income)
		{
			UpdateNextEvent(income);
		}

		private void UpdateNextEvent(Income income)
		{
			nextEvents[income] = income.Period2.GetNearestEvent(DateTime.Now);
			if (nextEvents[income] >= nextEvent)
				return;

			nextEvent = nextEvents[income];
			nextEventIncome = income;

			timer.Stop();
			SetupTimer();
		}
	}
}
