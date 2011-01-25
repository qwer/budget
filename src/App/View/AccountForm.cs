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
	public partial class AccountForm : Form
	{
		IAccountPresenter view;

		public AccountForm(IAccountPresenter view)
		{
			if (view == null)
				throw new ArgumentNullException();

			InitializeComponent();

			this.view = view;
			iAccountViewBindingSource.DataSource = view;
			button1.Click += new EventHandler(button1_Click);
		}

		protected override void OnShown(EventArgs e)
		{
			accountControl1.Account = view.Account;
			base.OnShown(e);
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (view.UndoCommand.CanExecute)
				view.UndoCommand.Execute();
			base.OnClosing(e);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			view.SaveCommand.Execute();
			Close();
		}

		void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
