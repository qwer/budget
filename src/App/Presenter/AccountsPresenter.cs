using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using Budget.Model;

using Budget.App.View;

namespace Budget.App.Presenter
{
	public class ObservableObject : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string name)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(name));
		}
	}

	public class AccountsPresenter : ObservableObject, IAccountsPresenter
	{
		Db db;

		public AccountsPresenter(Db db)
		{
			this.db = db;
			db.ConnectionStateChanged += this.ConnectionStateChanged;
		}

		private string status;
		public string Status
		{
			get { return status; }
			set
			{
				if (status == value)
					return;
				status = value;
				OnPropertyChanged("Status");
			}
		}

		private void ConnectionStateChanged(object sender, PropertyChangedEventArgs e)
		{
			Status = db.ConnectionState.ToString();
			if (db.ConnectionState == ConnectionState.Open)
				Connected();
		}

		private void Connected()
		{
			OnPropertyChanged("Accounts");
		}

		public IEnumerable<Account> Accounts
		{
			get { return db.Container.AccountSet; }
		}

		IAccountView accountView;
		IAccountPresenter accountPresenter;

		public void ShowAccount(Account account)
		{
			if (accountPresenter == null)
				accountPresenter = new AccountPresenter(db);
			if (accountView == null)
				accountView = new AccountForm(accountPresenter);

			accountPresenter.Account = account;
			accountView.Show();
		}
	}
}
