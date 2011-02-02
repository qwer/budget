using Budget.Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace Budget.App.Presenter
{
	public interface IIncomePresenter : INotifyPropertyChanged
	{
		Income Income { get; set; }
		IEnumerable<Account> Accounts { get; }
		ICommand SaveCommand { get; }
		ICommand UndoCommand { get; }
		IEnumerable<string> Periods { get; }
		int PeriodTypeIndex { get; set; }
		string PeriodString { get; set; }
	}
}
