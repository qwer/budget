namespace Budget.App.View
{
	partial class IncomesControl
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.createButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(0, 33);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(675, 389);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Название";
			this.columnHeader1.Width = 127;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Сумма";
			this.columnHeader2.Width = 139;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Периодичность";
			this.columnHeader3.Width = 210;
			// 
			// createButton
			// 
			this.createButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.createButton.Location = new System.Drawing.Point(0, 0);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(675, 33);
			this.createButton.TabIndex = 1;
			this.createButton.Text = "Создать";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// IncomesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.createButton);
			this.Name = "IncomesControl";
			this.Size = new System.Drawing.Size(675, 422);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button createButton;
	}
}
