using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Budget.Model;
using Budget.App.Presenter;

namespace Budget.App.View
{
	public partial class AccountForm : Form, IAccountView
	{
		IAccountPresenter presenter;

		public AccountForm(IAccountPresenter presenter)
		{
			if (presenter == null)
				throw new ArgumentNullException();

			InitializeComponent();

			this.presenter = presenter;
			iAccountViewBindingSource.DataSource = presenter;
			button1.Click += new EventHandler(button1_Click);
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
