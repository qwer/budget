using System.Collections.Generic;
using System.ComponentModel;
using Budget.Model;
using System;

namespace Budget.App.Presenter
{
	public interface IAccountsPresenter : INotifyPropertyChanged
	{
		IEnumerable<Account> Accounts { get; }
		string Status { get; }
		void ShowAccount(Account account);
		event EventHandler AccountAdded;
	}
}
