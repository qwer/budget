using System;
using System.Collections.Generic;
using System.Linq;

using Budget.Model;

namespace Budget.App.Presenter
{
	class IncomePresenter : IIncomePresenter
	{
		public IncomePresenter(Db db)
		{
		}

		private Income income;
		public Income Income
		{
			get { return income; }
			set { income = value; }
		}
		
	}
}
