using System;
using System.Collections.Generic;
using System.Linq;

using Budget.Model;

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

		public void ShowIncome(Income income)
		{
			
		}
	}
}
