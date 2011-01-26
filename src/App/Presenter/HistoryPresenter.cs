using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Budget.Model;

namespace Budget.App.Presenter
{
	class HistoryPresenter : ObservableObject, IHistoryPresenter
	{
		Db db;

		public HistoryPresenter(Db db)
		{
			this.db = db;
		}

		public IEnumerable<Account> Accounts
		{
			get { return db.Container.AccountSet; }
		}

		private DateTime startDate = DateTime.Now;
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

		private DateTime endDate = DateTime.Now;
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
				if (account == null)
					return db.Container.HistorySet.Where(h =>
						h.Date >= startDate &&
						h.Date <= endDate);

				return db.Container.HistorySet.Where(
					h => (h.AccountDest.Id == Account.Id) &&
					h.Date >= startDate &&
					h.Date <= endDate);
			}
		}

		private void Changed(string property)
		{
			OnPropertyChanged(property);
			OnPropertyChanged("History");
		}
	}
}
