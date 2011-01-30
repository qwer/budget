namespace Budget.App.View
{
	partial class AccountForm
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
			this.accountControl1 = new Budget.App.View.AccountControl();
			this.saveButton = new System.Windows.Forms.Button();
			this.iAccountViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.iAccountViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// accountControl1
			// 
			this.accountControl1.Account = null;
			this.accountControl1.AutoSize = true;
			this.accountControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.accountControl1.Location = new System.Drawing.Point(0, 0);
			this.accountControl1.Name = "accountControl1";
			this.accountControl1.Size = new System.Drawing.Size(578, 217);
			this.accountControl1.TabIndex = 0;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.AutoSize = true;
			this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.saveButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.iAccountViewBindingSource, "SaveCommand.CanExecute", true));
			this.saveButton.Location = new System.Drawing.Point(190, 232);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(106, 32);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "Сохранить";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// iAccountViewBindingSource
			// 
			this.iAccountViewBindingSource.DataSource = typeof(Budget.App.Presenter.IAccountPresenter);
			// 
			// button1
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.AutoSize = true;
			this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cancelButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.iAccountViewBindingSource, "UndoCommand.CanExecute", true));
			this.cancelButton.Location = new System.Drawing.Point(311, 232);
			this.cancelButton.Name = "button1";
			this.cancelButton.Size = new System.Drawing.Size(81, 32);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 276);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.accountControl1);
			this.Font = new System.Drawing.Font("Tahoma", 8.099999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "AccountForm";
			this.Text = "AccountForm";
			((System.ComponentModel.ISupportInitialize)(this.iAccountViewBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AccountControl accountControl1;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.BindingSource iAccountViewBindingSource;
	}
}