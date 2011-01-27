
namespace Budget.App.View
{
	interface IView<IPresenter>
	{
		IPresenter Presenter { get; set; }
	}
}
