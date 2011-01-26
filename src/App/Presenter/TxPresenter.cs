using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Budget.Model;

namespace Budget.App.Presenter
{
	public class TxPresenter : ITxPresenter
	{
		Db db;
		Account nullAccount = new Account();

		public TxPresenter(Db db)
		{
			this.db = db;

			nullAccount.Name = "(none)";
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

		private Account account1;
		public Account Account1
		{
			get { return account1; }
			set
			{
				account1 = value; 
				Changed();
			}
		}

		private Account account2;
		public Account Account2
		{
			get { return account2; }
			set
			{
				account2 = value;
				Changed();
			}
		}

		private decimal amount;
		public decimal Amount
		{
			get { return amount; }
			set
			{
				amount = value;
				Changed();
			}
		}

		private SimpleCommand saveCommand;
		public ICommand SaveCommand
		{
			get
			{
				return saveCommand ?? (saveCommand =
					new SimpleCommand(Save, CanSave));
			}
		}

		void Save()
		{
			//System.Windows.Forms.MessageBox.Show(Account1 == null ? "null" : Account1.Name);

			History history = new History();
			history.Amount = Amount;
			history.Date = DateTime.Now;
			history.AccountDest = Account1;
			history.AccountSrc = Account2 == null || Account2 == nullAccount 
					? null : Account2;

			db.AddHistory(history);
		}

		bool CanSave()
		{
			return  Account1 != nullAccount &&
				Account1 != Account2 &&
				Amount != 0;
		}

		void Changed()
		{
			if (saveCommand != null)
				saveCommand.StateChanged();
		}
	}
}
