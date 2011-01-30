using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using Budget.App.Presenter;
using Budget.App.IoC;

namespace Budget.App.View
{
	public partial class IncomeControl : UserControl, IIncomeView
	{
		public IncomeControl()
		{
			InitializeComponent();

		}

		private IIncomePresenter presenter;

		[Dependency]
		public IIncomePresenter Presenter
		{
			get { return presenter; }
			set
			{
				if (value == null)
					return;
				presenter = value;
			}
		}
	}
}
