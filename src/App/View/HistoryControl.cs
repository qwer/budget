using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using Budget.App.Presenter;

namespace Budget.App.View
{
	public partial class HistoryControl : UserControl, IHistoryView
	{
		public HistoryControl()
		{
			InitializeComponent();
		}

		private IHistoryPresenter presenter;
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
			}
		}
	}
}
