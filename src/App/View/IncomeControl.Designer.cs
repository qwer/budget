namespace Budget.App.View
{
	partial class IncomeControl
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.iIncomePresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iIncomePresenterBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.11324F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.88676F));
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 362);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iIncomePresenterBindingSource, "Income.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(173, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(451, 28);
			this.textBox1.TabIndex = 0;
			// 
			// iIncomePresenterBindingSource
			// 
			this.iIncomePresenterBindingSource.DataSource = typeof(Budget.App.Presenter.IIncomePresenter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iIncomePresenterBindingSource, "Income.Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown1.DecimalPlaces = 2;
			this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDown1.Location = new System.Drawing.Point(173, 37);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(451, 28);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.ThousandsSeparator = true;
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(173, 71);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(451, 30);
			this.comboBox1.TabIndex = 4;
			// 
			// IncomeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "IncomeControl";
			this.Size = new System.Drawing.Size(627, 362);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iIncomePresenterBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource iIncomePresenterBindingSource;
	}
}
