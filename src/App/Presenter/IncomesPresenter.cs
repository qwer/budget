using System;
using System.Collections.Generic;
using System.Linq;

using Budget.Model;
using Budget.App.View;
using Budget.App.IoC;

namespace Budget.App.Presenter
{
	class IncomesPresenter : IIncomesPresenter
	{
		Db db;

		public IncomesPresenter(Db db)
		{
			this.db = db;
		}

		public IEnumerable<Income> Incomes
		{
			get 
			{
				return db.Container.IncomeSet;
			}
		}

		IIncomeView view;
		public void ShowIncome(Income income)
		{
			if (view == null)
				view = IoCContainer.Instance.Resolve<IIncomeView>();

			view.Show();
		}

		public void CreateIncome()
		{
			Income i = new Income();
			ShowIncome(i);
		}
	}
}
