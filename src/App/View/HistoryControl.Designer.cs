namespace Budget.App.View
{
	partial class HistoryControl
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SrcAccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DestAccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iHistoryPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.accountComboBox = new System.Windows.Forms.ComboBox();
			this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.accountLabel = new System.Windows.Forms.Label();
			this.startDateLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iHistoryPresenterBindingSource)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 452);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.AmountColumn,
            this.SrcAccountColumn,
            this.DestAccountColumn,
            this.DescriptionColumn});
			this.dataGridView1.DataMember = "History";
			this.dataGridView1.DataSource = this.iHistoryPresenterBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 113);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 30;
			this.dataGridView1.Size = new System.Drawing.Size(780, 336);
			this.dataGridView1.TabIndex = 0;
			// 
			// DateColumn
			// 
			this.DateColumn.DataPropertyName = "Date";
			this.DateColumn.HeaderText = "Дата";
			this.DateColumn.Name = "DateColumn";
			this.DateColumn.ReadOnly = true;
			// 
			// AmountColumn
			// 
			this.AmountColumn.DataPropertyName = "Amount";
			this.AmountColumn.HeaderText = "Сумма";
			this.AmountColumn.Name = "AmountColumn";
			this.AmountColumn.ReadOnly = true;
			// 
			// SrcAccountColumn
			// 
			this.SrcAccountColumn.DataPropertyName = "AccountSrc";
			this.SrcAccountColumn.HeaderText = "Cчет 1";
			this.SrcAccountColumn.Name = "SrcAccountColumn";
			this.SrcAccountColumn.ReadOnly = true;
			// 
			// DestAccountColumn
			// 
			this.DestAccountColumn.DataPropertyName = "AccountDest";
			this.DestAccountColumn.HeaderText = "Счет 2";
			this.DestAccountColumn.Name = "DestAccountColumn";
			this.DestAccountColumn.ReadOnly = true;
			// 
			// DescriptionColumn
			// 
			this.DescriptionColumn.DataPropertyName = "Description";
			this.DescriptionColumn.HeaderText = "Описание";
			this.DescriptionColumn.Name = "DescriptionColumn";
			this.DescriptionColumn.ReadOnly = true;
			this.DescriptionColumn.Width = 200;
			// 
			// iHistoryPresenterBindingSource
			// 
			this.iHistoryPresenterBindingSource.DataSource = typeof(Budget.App.Presenter.IHistoryPresenter);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58974F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.41026F));
			this.tableLayoutPanel2.Controls.Add(this.accountComboBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.startDateTimePicker, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.endDateTimePicker, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.accountLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.startDateLabel, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 104);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// accountComboBox
			// 
			this.accountComboBox.DataSource = this.iHistoryPresenterBindingSource;
			this.accountComboBox.DisplayMember = "Accounts";
			this.accountComboBox.FormattingEnabled = true;
			this.accountComboBox.Location = new System.Drawing.Point(186, 3);
			this.accountComboBox.Name = "accountComboBox";
			this.accountComboBox.Size = new System.Drawing.Size(200, 30);
			this.accountComboBox.TabIndex = 0;
			// 
			// startDateTimePicker
			// 
			this.startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iHistoryPresenterBindingSource, "StartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.startDateTimePicker.Location = new System.Drawing.Point(186, 39);
			this.startDateTimePicker.Name = "startDateTimePicker";
			this.startDateTimePicker.Size = new System.Drawing.Size(200, 28);
			this.startDateTimePicker.TabIndex = 1;
			// 
			// endDateTimePicker
			// 
			this.endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iHistoryPresenterBindingSource, "EndDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.endDateTimePicker.Location = new System.Drawing.Point(186, 73);
			this.endDateTimePicker.Name = "endDateTimePicker";
			this.endDateTimePicker.Size = new System.Drawing.Size(200, 28);
			this.endDateTimePicker.TabIndex = 2;
			// 
			// accountLabel
			// 
			this.accountLabel.AutoSize = true;
			this.accountLabel.Location = new System.Drawing.Point(3, 0);
			this.accountLabel.Name = "accountLabel";
			this.accountLabel.Size = new System.Drawing.Size(51, 22);
			this.accountLabel.TabIndex = 3;
			this.accountLabel.Text = "Счет";
			// 
			// startDateLabel
			// 
			this.startDateLabel.AutoSize = true;
			this.startDateLabel.Location = new System.Drawing.Point(3, 36);
			this.startDateLabel.Name = "startDateLabel";
			this.startDateLabel.Size = new System.Drawing.Size(146, 22);
			this.startDateLabel.TabIndex = 4;
			this.startDateLabel.Text = "Начальная дата";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Конечная дата";
			// 
			// HistoryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "HistoryControl";
			this.Size = new System.Drawing.Size(786, 452);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iHistoryPresenterBindingSource)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource iHistoryPresenterBindingSource;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ComboBox accountComboBox;
		private System.Windows.Forms.DateTimePicker startDateTimePicker;
		private System.Windows.Forms.DateTimePicker endDateTimePicker;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SrcAccountColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DestAccountColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
		private System.Windows.Forms.Label accountLabel;
		private System.Windows.Forms.Label startDateLabel;
		private System.Windows.Forms.Label label3;
	}
}
