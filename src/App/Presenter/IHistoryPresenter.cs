using System;
using System.Collections.Generic;
using System.ComponentModel;

using Budget.Model;

namespace Budget.App.Presenter
{
	public interface IHistoryPresenter : INotifyPropertyChanged
	{
		IEnumerable<Account> Accounts { get; }
		DateTime StartDate { get; set; }
		DateTime EndDate { get; set; }
		Account Account { get; set; }
		IEnumerable<History> History { get; }
	}
}