using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.Objects;

using Budget.Model;
using Budget.App.Presenter;

namespace Budget.App.View
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Presenter_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (InvokeRequired)
			{
				Invoke(new PropertyChangedEventHandler(Presenter_PropertyChanged), sender, e);
				return;
			}

			//if (e.PropertyName == "Status") 
			//	toolStripStatusLabel1.Text = presenter.Status;
		}
	}
}
