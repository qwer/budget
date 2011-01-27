using Budget.Model;
 
namespace Budget.App.Presenter
{
	public interface IAccountPresenter
	{
		Account Account { get; set; }
		ICommand SaveCommand { get; }
		ICommand UndoCommand { get; }
	}
}
