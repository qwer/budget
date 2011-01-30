using System;
using System.Collections.Generic;
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
		
		[STAThread]
		static void Main()
		{
			InitContainer();

			Task task = new Task(Connect);
			task.Start();
			task.Wait();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		private static void TestTx()
		{
			Form f = new Form();
			TxControl tx = new TxControl();
			tx.Dock = DockStyle.Fill;
			f.Controls.Add(tx);
			f.ShowDialog();
		}

		private static void TestHistory()
		{
			Form f = new Form();
			HistoryControl tx = new HistoryControl();
			tx.Dock = DockStyle.Fill;
			f.Controls.Add(tx);
			f.ShowDialog();
		}

		static void InitContainer()
		{
			IContainer container = IoCContainer.Instance;

			container.Enabled = true;
			container.Register(db);

			container.Register<IAccountPresenter, AccountPresenter>();
			container.Register<IAccountsPresenter, AccountsPresenter>();
			container.Register<ITxPresenter, TxPresenter>();
			container.Register<IHistoryPresenter, HistoryPresenter>();
			container.Register<IIncomesPresenter, IncomesPresenter>();
			container.Register<IIncomePresenter, IncomePresenter>();

			container.Register<IAccountView, AccountForm>();
			container.Register<IAccountsView, AccountsControl>();
			container.Register<ITxView, TxControl>();
			container.Register<IHistoryView, HistoryControl>();
			container.Register<IIncomesView, IncomesControl>();
			container.Register<IIncomeView, IncomeControl>();
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
