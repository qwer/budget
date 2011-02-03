using System;
using System.Collections.Generic;
using System.Linq;

using Budget.Model;

namespace Budget.App.Presenter
{
	class HistoryPresenter : ObservableObject, IHistoryPresenter
	{
		Db db;
		Account nullAccount;
		
		public HistoryPresenter(Db db)
		{
			this.db = db;

			nullAccount = new Account();
			nullAccount.Name = "";
		}

		public IEnumerable<Account> Accounts
		{
			get 
			{
				List<Account> l = new List<Account>();
				l.Add(nullAccount);
				l.AddRange(db.Container.AccountSet);
				return l;
			}
		}

		private DateTime startDate = DateTime.Today;
		public DateTime StartDate
		{
			get { return startDate; }
			set
			{
				if (startDate == value)
					return;
				startDate = value;
				Changed("StartDate");
			}
		}

		private DateTime endDate = DateTime.Today;
		public DateTime EndDate
		{
			get { return endDate; }
			set
			{
				if (endDate == value)
					return;
				endDate = value;
				Changed("EndDate");
			}
		}

		private Account account;
		public Account Account
		{
			get { return account; }
			set
			{
				if (account == value)
					return;
				account = value;
				Changed("Account");
			}
		}

		public IEnumerable<History> History 
		{
			get
			{
				DateTime end = endDate.AddDays(1);
				
				if (Account == null || Account == nullAccount)
					return db.Container.HistorySet.Where(h =>
						h.Date >= startDate &&
						h.Date < end);

				return db.Container.HistorySet.Where(
					h => (h.AccountDest.Id == Account.Id) &&
					h.Date >= startDate &&
					h.Date < end);
			}
		}

		private void Changed(string property)
		{
			OnPropertyChanged(property);
			OnPropertyChanged("History");
		}

		public event EventHandler HistoryAdded
		{
			add    { db.HistoryAdded += value; }
			remove { db.HistoryAdded -= value; }
		}
	}
}
