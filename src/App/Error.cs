using System;
using System.Windows.Forms;

namespace Budget.App
{
	class Error
	{
		public static void Show(Exception e)
		{
			MessageBox.Show(
				e.Message + "\n\n" + e.ToString(),
				"Error",
				MessageBoxButtons.OK);
		}
	}
}
