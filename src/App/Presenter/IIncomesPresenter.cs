using System.Collections.Generic;
using Budget.Model;

namespace Budget.App.Presenter
{
	public interface IIncomesPresenter 
	{
		IEnumerable<Income> Incomes { get; }
		void ShowIncome(Income income);
		void CreateIncome();
	}
}
