using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Budget.App
{
	static class Program
	{
		static Db db = new Db();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Task task = new Task(Connect);
			task.Start();

			AccountsView view = new AccountsView(db);
			Application.Run(new Form1(view));
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
