using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;

using Budget.Model;

namespace Budget.App.Presenter
{
	public interface IAccountsPresenter : INotifyPropertyChanged
	{
		IEnumerable<Account> Accounts { get; }
		string Status { get; }
		void ShowAccount(Account account);
	}
}
