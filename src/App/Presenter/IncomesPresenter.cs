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
			CreateView();

			view.Presenter.Income = income;
			view.Show();
		}

		private void CreateView()
		{
			if (view == null)
				view = IoCContainer.Instance.Resolve<IIncomeView>();
		}

		public void CreateIncome()
		{
			CreateView();
			Account a = null;
			
			try
			{
				a = view.Presenter.Accounts.First();
			}
			catch (Exception e)
			{
				Error.Show(e);
				return;
			}

			Income i = new Income();
			i.Account = a;
			i.StartDate = DateTime.Now;
			i.EndDate = DateTime.Now.AddYears(1);
			i.Period = "";
			ShowIncome(i);
		}
	}
}
