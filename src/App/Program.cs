using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

using Budget.App.Presenter;
using Budget.App.View;
using Budget.App.IoC;

namespace Budget.App
{
	static class Program
	{
		static Db db = new Db();
		static IContainer container;
		
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			InitContainer();

			Task task = new Task(Connect);
			task.Start();
			task.Wait();

			ITxPresenter p = new TxPresenter(db);
			Form f = new Form();
			TxControl tx = new TxControl();
			tx.Presenter = p;
			tx.Dock = DockStyle.Fill;
			f.Controls.Add(tx);
			f.ShowDialog();

			AccountsPresenter view = new AccountsPresenter(db);
			Application.Run(new MainForm(view));
		}

		static void InitContainer()
		{
			container = new MsUnityContainer();

			container.Register<IAccountPresenter, AccountPresenter>();
			container.Register<IAccountsPresenter, AccountsPresenter>();

			container.Register<IAccountView, AccountForm>();
			container.Register<IAccountsView, AccountsControl>();
		}

		private static void Connect()
		{
			try
			{
				db.Connect();
			}
			catch (Exception e)
			{
				Error.Show(e);
			}
		}
	}
}
