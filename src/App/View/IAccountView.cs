using Budget.App.Presenter;

namespace Budget.App.View
{
	interface IAccountView : IView<IAccountPresenter>
	{
		void Show();
	}
}
