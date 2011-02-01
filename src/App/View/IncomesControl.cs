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
using Budget.Model;

namespace Budget.App.View
{
	public partial class IncomesControl : UserControl, IIncomesView
	{
		public IncomesControl()
		{
			InitializeComponent();
			IoCContainer.Instance.Inject(this);
		}

		private IIncomesPresenter presenter;

		[Dependency]
		public IIncomesPresenter Presenter
		{
			get { return presenter; }
			set
			{
				if (value == null)
					return;
				presenter = value;
				LoadIncomes();
			}
		}

		Dictionary<Income, ListViewItem> items = new Dictionary<Income,ListViewItem>();

		private void LoadIncomes()
		{
			listView1.Items.Clear();
			items.Clear();
			foreach (Income i in Presenter.Incomes)
				AddIncome(i);
		}

		private void AddIncome(Income i)
		{
			ListViewItem li = new ListViewItem();
			SetItems(i, li);
			li.Tag = i;
			listView1.Items.Add(li);
			items[i] = li;
			i.PropertyChanged += new PropertyChangedEventHandler(Income_PropertyChanged);
		}

		private static void SetItems(Income i, ListViewItem li)
		{
			li.SubItems.Clear();
			li.SubItems.Add(i.Amount.ToString());
			li.SubItems.Add(i.Period2.Format);
			li.SubItems.Add(i.Account.Name);
			li.Text = i.Name;
		}

		private void Income_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			Income i = (Income) sender;
			ListViewItem li = items[i];
			SetItems(i, li);
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			Presenter.CreateIncome();
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count != 1)
				return;
			Income i = (Income) listView1.SelectedItems[0].Tag;
			Presenter.ShowIncome(i);
		}
	}
}
