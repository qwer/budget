using System;
using System.ComponentModel;
using System.Windows.Forms;

using Budget.Model;
using Budget.App.Presenter;
using Budget.App.IoC;

namespace Budget.App.View
{
	public partial class AccountForm : Form, IAccountView
	{
		public AccountForm()
		{
			InitializeComponent();
			button1.Click += new EventHandler(button1_Click);

			if (!DesignMode)
				IoCContainer.Instance.Inject(this);
		}

		IAccountPresenter presenter;

		[Dependency]
		public IAccountPresenter Presenter
		{
			get { return presenter; }
			set
			{
				if (value == null)
					return;
				presenter = value;
				iAccountViewBindingSource.DataSource = value;
			}
		}
		
		void IAccountView.Show()
		{
			ShowDialog();
		}

		protected override void OnShown(EventArgs e)
		{
			accountControl1.Account = presenter.Account;
			base.OnShown(e);
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (presenter.UndoCommand.CanExecute)
				presenter.UndoCommand.Execute();
			base.Hide();
			//base.OnClosing(e);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			presenter.SaveCommand.Execute();
			Close();
		}

		void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
