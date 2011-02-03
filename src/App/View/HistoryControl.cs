using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Budget.App.Presenter;
using Budget.App.IoC;

namespace Budget.App.View
{
	public partial class HistoryControl : UserControl, IHistoryView
	{
		public HistoryControl()
		{
			InitializeComponent();
			IoCContainer.Instance.Inject(this);
		}

		private IHistoryPresenter presenter;

		[Dependency]
		public IHistoryPresenter Presenter
		{
			get { return presenter; }
			set
			{
				if (value == null)
					return;

				presenter = value;
				
				accountComboBox.DataBindings.Clear();
				accountComboBox.DataBindings.Add("SelectedValue", presenter, "Account", true, DataSourceUpdateMode.OnPropertyChanged);
				accountComboBox.DataSource = presenter.Accounts;
				accountComboBox.DisplayMember = "Name";

				iHistoryPresenterBindingSource.DataSource = presenter;
				presenter.HistoryAdded += presenter_HistoryAdded;
			}
		}

		void presenter_HistoryAdded(object sender, EventArgs e)
		{
			iHistoryPresenterBindingSource.ResetBindings(false);
		}
	}
}
