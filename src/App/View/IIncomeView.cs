using Budget.App.Presenter;

namespace Budget.App.View
{
	interface IIncomeView : IView<IIncomePresenter>
	{
		void Show();
	}
}
