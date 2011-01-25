namespace Budget.App.View
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Цели", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Счета", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Резерв", System.Windows.Forms.HorizontalAlignment.Left);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.accountsTabPage = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.accountNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.accountBalanceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.accountTargetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.incomesTabPage = new System.Windows.Forms.TabPage();
			this.historyTabPage = new System.Windows.Forms.TabPage();
			this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.statusStrip1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.accountsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 548);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(822, 27);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(176, 22);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.accountsTabPage);
			this.tabControl.Controls.Add(this.incomesTabPage);
			this.tabControl.Controls.Add(this.historyTabPage);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(822, 548);
			this.tabControl.TabIndex = 4;
			// 
			// accountsTabPage
			// 
			this.accountsTabPage.Controls.Add(this.listView1);
			this.accountsTabPage.Location = new System.Drawing.Point(4, 31);
			this.accountsTabPage.Name = "accountsTabPage";
			this.accountsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.accountsTabPage.Size = new System.Drawing.Size(814, 513);
			this.accountsTabPage.TabIndex = 0;
			this.accountsTabPage.Text = "Счета";
			this.accountsTabPage.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountNameColumn,
            this.accountBalanceColumn,
            this.accountTargetColumn});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.listView1.Location = new System.Drawing.Point(3, 3);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(808, 507);
			this.listView1.TabIndex = 3;
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
			this.accountBalanceColumn.Width = 287;
			// 
			// accountTargetColumn
			// 
			this.accountTargetColumn.Text = "Цель";
			this.accountTargetColumn.Width = 231;
			// 
			// incomesTabPage
			// 
			this.incomesTabPage.Location = new System.Drawing.Point(4, 31);
			this.incomesTabPage.Name = "incomesTabPage";
			this.incomesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.incomesTabPage.Size = new System.Drawing.Size(814, 513);
			this.incomesTabPage.TabIndex = 1;
			this.incomesTabPage.Text = "Доходы";
			this.incomesTabPage.UseVisualStyleBackColor = true;
			// 
			// historyTabPage
			// 
			this.historyTabPage.Location = new System.Drawing.Point(4, 31);
			this.historyTabPage.Name = "historyTabPage";
			this.historyTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.historyTabPage.Size = new System.Drawing.Size(814, 513);
			this.historyTabPage.TabIndex = 2;
			this.historyTabPage.Text = "История";
			this.historyTabPage.UseVisualStyleBackColor = true;
			// 
			// accountBindingSource
			// 
			this.accountBindingSource.DataSource = typeof(Budget.Model.Account);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 575);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 8.099999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "Form1";
			this.Text = "Form1";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.accountsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.BindingSource accountBindingSource;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage accountsTabPage;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TabPage incomesTabPage;
		private System.Windows.Forms.TabPage historyTabPage;
		private System.Windows.Forms.ColumnHeader accountNameColumn;
		private System.Windows.Forms.ColumnHeader accountBalanceColumn;
		private System.Windows.Forms.ColumnHeader accountTargetColumn;
	}
}

