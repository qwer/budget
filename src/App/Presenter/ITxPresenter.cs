using System.Collections.Generic;

using Budget.Model;

namespace Budget.App.Presenter
{
	public interface ITxPresenter
	{
		IEnumerable<Account> Accounts { get; }
		Account Account1 { get; set; }
		Account Account2 { get; set; }
		decimal Amount { get; }
		ICommand SaveCommand { get; }
	}
}
