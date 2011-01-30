namespace Budget.App.View
{
	partial class MainForm
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.accountsTabPage = new System.Windows.Forms.TabPage();
			this.accountsControl1 = new Budget.App.View.AccountsControl();
			this.incomesTabPage = new System.Windows.Forms.TabPage();
			this.historyTabPage = new System.Windows.Forms.TabPage();
			this.historyControl1 = new Budget.App.View.HistoryControl();
			this.incomesControl1 = new Budget.App.View.IncomesControl();
			this.statusStrip1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.accountsTabPage.SuspendLayout();
			this.incomesTabPage.SuspendLayout();
			this.historyTabPage.SuspendLayout();
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
			this.accountsTabPage.Controls.Add(this.accountsControl1);
			this.accountsTabPage.Location = new System.Drawing.Point(4, 31);
			this.accountsTabPage.Name = "accountsTabPage";
			this.accountsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.accountsTabPage.Size = new System.Drawing.Size(814, 513);
			this.accountsTabPage.TabIndex = 0;
			this.accountsTabPage.Text = "Счета";
			this.accountsTabPage.UseVisualStyleBackColor = true;
			// 
			// accountsControl1
			// 
			this.accountsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accountsControl1.Location = new System.Drawing.Point(3, 3);
			this.accountsControl1.Name = "accountsControl1";
			this.accountsControl1.Presenter = null;
			this.accountsControl1.Size = new System.Drawing.Size(808, 507);
			this.accountsControl1.TabIndex = 0;
			// 
			// incomesTabPage
			// 
			this.incomesTabPage.Controls.Add(this.incomesControl1);
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
			this.historyTabPage.Controls.Add(this.historyControl1);
			this.historyTabPage.Location = new System.Drawing.Point(4, 31);
			this.historyTabPage.Name = "historyTabPage";
			this.historyTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.historyTabPage.Size = new System.Drawing.Size(814, 513);
			this.historyTabPage.TabIndex = 2;
			this.historyTabPage.Text = "История";
			this.historyTabPage.UseVisualStyleBackColor = true;
			// 
			// historyControl1
			// 
			this.historyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.historyControl1.Location = new System.Drawing.Point(3, 3);
			this.historyControl1.Name = "historyControl1";
			this.historyControl1.Presenter = null;
			this.historyControl1.Size = new System.Drawing.Size(808, 507);
			this.historyControl1.TabIndex = 0;
			// 
			// incomesControl1
			// 
			this.incomesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.incomesControl1.Location = new System.Drawing.Point(3, 3);
			this.incomesControl1.Name = "incomesControl1";
			this.incomesControl1.Presenter = null;
			this.incomesControl1.Size = new System.Drawing.Size(808, 507);
			this.incomesControl1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 575);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 8.099999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "MainForm";
			this.Text = "Form1";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.accountsTabPage.ResumeLayout(false);
			this.incomesTabPage.ResumeLayout(false);
			this.historyTabPage.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage accountsTabPage;
		private System.Windows.Forms.TabPage incomesTabPage;
		private System.Windows.Forms.TabPage historyTabPage;
		private AccountsControl accountsControl1;
		private HistoryControl historyControl1;
		private IncomesControl incomesControl1;
	}
}

