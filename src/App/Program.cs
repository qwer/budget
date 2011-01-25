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

			AccountsPresenter view = new AccountsPresenter(db);
			Application.Run(new Form1(view));
		}

		static void InitContainer()
		{
			container = new MsUnityContainer();

			container.Register<IAccountPresenter, AccountPresenter>();
			container.Register<IAccountsPresenter, AccountsPresenter>();

			container.Register<IAccountView, AccountForm>();
			container.Register<IAccountsView, Form1>();
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
