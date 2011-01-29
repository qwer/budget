namespace Budget.App.View
{
	partial class AccountsControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Цели", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Счета", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Резерв", System.Windows.Forms.HorizontalAlignment.Left);
			this.listView1 = new System.Windows.Forms.ListView();
			this.accountNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.accountBalanceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.accountTargetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountNameColumn,
            this.accountBalanceColumn,
            this.accountTargetColumn});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			listViewGroup1.Header = "Цели";
			listViewGroup1.Name = "targetsGroup";
			listViewGroup2.Header = "Счета";
			listViewGroup2.Name = "accountsGroup";
			listViewGroup3.Header = "Резерв";
			listViewGroup3.Name = "reservesGroup";
			this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
			this.listView1.HotTracking = true;
			this.listView1.HoverSelection = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(758, 458);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// accountNameColumn
			// 
			this.accountNameColumn.Text = "Название";
			this.accountNameColumn.Width = 226;
			// 
			// accountBalanceColumn
			// 
			this.accountBalanceColumn.Text = "Баланс";
			this.accountBalanceColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.accountBalanceColumn.Width = 287;
			// 
			// accountTargetColumn
			// 
			this.accountTargetColumn.Text = "Цель";
			this.accountTargetColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.accountTargetColumn.Width = 231;
			// 
			// AccountsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.listView1);
			this.Name = "AccountsControl";
			this.Size = new System.Drawing.Size(758, 458);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader accountNameColumn;
		private System.Windows.Forms.ColumnHeader accountBalanceColumn;
		private System.Windows.Forms.ColumnHeader accountTargetColumn;
	}
}
