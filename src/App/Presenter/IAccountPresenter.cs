using System.ComponentModel;
using Budget.Model;
 
namespace Budget.App.Presenter
{
	public interface IAccountPresenter : INotifyPropertyChanged
	{
		Account Account { get; set; }
		ICommand SaveCommand { get; }
		ICommand UndoCommand { get; }
		bool IsTarget { get; set; }
	}
}
