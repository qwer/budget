namespace Budget.App.View
{
	partial class AccountControl
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
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameLabel = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.checkBox = new System.Windows.Forms.CheckBox();
			this.isTargetLabel = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.targetLabel = new System.Windows.Forms.Label();
			this.iAccountPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iAccountPresenterBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.97393F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.02607F));
			this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.isTargetLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.targetLabel, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 215);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Name", true));
			this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nameTextBox.Location = new System.Drawing.Point(125, 3);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(431, 28);
			this.nameTextBox.TabIndex = 0;
			// 
			// accountBindingSource
			// 
			this.accountBindingSource.DataSource = typeof(Budget.Model.Account);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(3, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(92, 22);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Название";
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox2.Location = new System.Drawing.Point(125, 37);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(431, 113);
			this.textBox2.TabIndex = 2;
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(3, 34);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(93, 22);
			this.descriptionLabel.TabIndex = 3;
			this.descriptionLabel.Text = "Описание";
			// 
			// checkBox
			// 
			this.checkBox.AutoSize = true;
			this.checkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.iAccountPresenterBindingSource, "IsTarget", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBox.Location = new System.Drawing.Point(125, 156);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(23, 22);
			this.checkBox.TabIndex = 4;
			this.checkBox.UseVisualStyleBackColor = true;
			// 
			// isTargetLabel
			// 
			this.isTargetLabel.AutoSize = true;
			this.isTargetLabel.Location = new System.Drawing.Point(3, 153);
			this.isTargetLabel.Name = "isTargetLabel";
			this.isTargetLabel.Size = new System.Drawing.Size(83, 22);
			this.isTargetLabel.TabIndex = 5;
			this.isTargetLabel.Text = "Целевой";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "Target", true));
			this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.iAccountPresenterBindingSource, "IsTarget", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.iAccountPresenterBindingSource, "IsTarget", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.numericUpDown1.DecimalPlaces = 2;
			this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown1.Location = new System.Drawing.Point(125, 184);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(431, 28);
			this.numericUpDown1.TabIndex = 6;
			this.numericUpDown1.ThousandsSeparator = true;
			// 
			// targetLabel
			// 
			this.targetLabel.AutoSize = true;
			this.targetLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.iAccountPresenterBindingSource, "IsTarget", true));
			this.targetLabel.Location = new System.Drawing.Point(3, 181);
			this.targetLabel.Name = "targetLabel";
			this.targetLabel.Size = new System.Drawing.Size(52, 22);
			this.targetLabel.TabIndex = 7;
			this.targetLabel.Text = "Цель";
			// 
			// iAccountPresenterBindingSource
			// 
			this.iAccountPresenterBindingSource.DataSource = typeof(Budget.App.Presenter.IAccountPresenter);
			// 
			// AccountControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AccountControl";
			this.Size = new System.Drawing.Size(559, 262);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iAccountPresenterBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.CheckBox checkBox;
		private System.Windows.Forms.Label isTargetLabel;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label targetLabel;
		private System.Windows.Forms.BindingSource accountBindingSource;
		private System.Windows.Forms.BindingSource iAccountPresenterBindingSource;
	}
}
