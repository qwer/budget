﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;

using Budget.Model;

namespace Budget.App
{
	public interface IAccountsView : INotifyPropertyChanged
	{
		IEnumerable<Account> Accounts { get; }
		string Status { get; }
		void ShowAccount(Account account);
	}

	public class ObservableObject : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string name)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(name));
		}
	}

	public class AccountsView : ObservableObject, IAccountsView
	{
		Db db;

		public AccountsView(Db db)
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

		AccountForm accountForm;
		AccountView accountView;

		public void ShowAccount(Account account)
		{
			if (accountView == null)
				accountView = new AccountView(db);
			if (accountForm == null)
				accountForm = new AccountForm(accountView);

			accountView.Account = account;
			accountForm.ShowDialog();
		}
	}
}