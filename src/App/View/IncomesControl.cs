using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Budget.App.Presenter;
using Budget.App.IoC;

namespace Budget.App.View
{
	public partial class IncomesControl : UserControl, IIncomesView
	{
		public IncomesControl()
		{
			InitializeComponent();
			if (!DesignMode)
				IoCContainer.Instance.Inject(this);
		}

		private IIncomesPresenter presenter;

		[Dependency]
		public IIncomesPresenter Presenter
		{
			get { return presenter; }
			set
			{
				presenter = value;
			}
		}
	}
}
