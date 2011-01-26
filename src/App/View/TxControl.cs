using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Budget.App.Presenter;

namespace Budget.App.View
{
	public partial class TxControl : UserControl, ITxView
	{
		public TxControl()
		{
			InitializeComponent();
		}

		private ITxPresenter presenter;
		public ITxPresenter Presenter
		{
			get { return presenter; }
			set
			{
				presenter = value;
				if (presenter == null)
					return;
				
				comboBox1.DataBindings.Clear();
				comboBox1.DataBindings.Add("SelectedValue", presenter, "Account1", true, DataSourceUpdateMode.OnPropertyChanged);
				comboBox1.DataSource = presenter.Accounts;
				comboBox1.DisplayMember = "Name";
				
				comboBox2.DataBindings.Clear();
				comboBox2.DataBindings.Add("SelectedValue", presenter, "Account2", true, DataSourceUpdateMode.OnPropertyChanged);
				comboBox2.DataSource = presenter.Accounts;
				comboBox2.DisplayMember = "Name";

				numericUpDown1.DataBindings.Clear();
				numericUpDown1.DataBindings.Add("Value", presenter, "Amount", true, DataSourceUpdateMode.OnPropertyChanged);

				iTxPresenterBindingSource.DataSource = presenter;
				saveButton.DataBindings.Add("Enabled", iTxPresenterBindingSource, "SaveCommand.CanExecute"); 
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			Presenter.SaveCommand.Execute();
		}
	}
}
