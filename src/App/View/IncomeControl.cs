using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using Budget.App.Presenter;
using Budget.App.IoC;

namespace Budget.App.View
{
	public partial class IncomeControl : UserControl, IIncomeView
	{
		Form form = new Form();

		public IncomeControl()
		{
			InitializeComponent();

			this.Dock = DockStyle.Fill;
			form.Controls.Add(this);
			form.FormClosing += OnClosing;

			comboBox1.DisplayMember = "Name";
			IoCContainer.Instance.Inject(this);
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
				
				iIncomePresenterBindingSource.DataSource = presenter;
				comboBox1.DataSource = presenter.Accounts;
				presenter.PropertyChanged += presenter_PropertyChanged;
			}
		}

		void presenter_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Income" && Presenter.Income != null)
			{
				comboBox1.DataBindings.Clear();
				comboBox1.DataBindings.Add("SelectedItem", Presenter.Income, "Account", false, DataSourceUpdateMode.OnPropertyChanged);
			}
		}

		
		void IIncomeView.Show()
		{
			form.ShowDialog();
		}

		private void OnClosing(object sender, FormClosingEventArgs e)
		{
			if (Presenter.UndoCommand.CanExecute)
				Presenter.UndoCommand.Execute();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			Presenter.SaveCommand.Execute();
			if (form != null)
				form.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			if (form != null)
				form.Close();
		}
	}
}
