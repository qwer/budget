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
			cancelButton.Click += new EventHandler(cancelButton_Click);

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
				accountControl1.Presenter = presenter;
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
			base.OnClosing(e);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			presenter.SaveCommand.Execute();
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
