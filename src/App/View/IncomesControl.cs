using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Budget.App.Presenter;
using Budget.App.IoC;
using Budget.Model;

namespace Budget.App.View
{
	public partial class IncomesControl : UserControl, IIncomesView
	{
		public IncomesControl()
		{
			InitializeComponent();
			IoCContainer.Instance.Inject(this);
		}

		private IIncomesPresenter presenter;

		[Dependency]
		public IIncomesPresenter Presenter
		{
			get { return presenter; }
			set
			{
				if (value == null)
					return;
				presenter = value;
				LoadIncomes();
			}
		}

		private void LoadIncomes()
		{
			foreach (Income i in Presenter.Incomes)
				;
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			Presenter.CreateIncome();
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count != 1)
				return;
			Income i = (Income) listView1.SelectedItems[0].Tag;
			Presenter.ShowIncome(i);
		}
	}
}
