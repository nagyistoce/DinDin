namespace DinDin.Desktop
{
	partial class AddAccountDialog
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
			if (disposing && (components != null)) {
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
			this.panelButtons = new System.Windows.Forms.Panel();
			this.labelStatus = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelInitialBalance = new System.Windows.Forms.Label();
			this.labelCurrency = new System.Windows.Forms.Label();
			this.labelBankAccountId = new System.Windows.Forms.Label();
			this.labelBankAgencyId = new System.Windows.Forms.Label();
			this.labelBankName = new System.Windows.Forms.Label();
			this.textBoxBankAccountId = new System.Windows.Forms.TextBox();
			this.textBoxBankAgencyId = new System.Windows.Forms.TextBox();
			this.textBoxBankName = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelShortName = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxShortName = new System.Windows.Forms.TextBox();
			this.textBoxInitialBalance = new System.Windows.Forms.TextBox();
			this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
			this.panelButtons.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelButtons
			// 
			this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelButtons.Controls.Add(this.labelStatus);
			this.panelButtons.Controls.Add(this.buttonCancel);
			this.panelButtons.Controls.Add(this.buttonOk);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelButtons.Location = new System.Drawing.Point(0, 266);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(616, 68);
			this.panelButtons.TabIndex = 0;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoEllipsis = true;
			this.labelStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.ForeColor = System.Drawing.Color.Firebrick;
			this.labelStatus.Location = new System.Drawing.Point(8, 7);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(423, 51);
			this.labelStatus.TabIndex = 2;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCancel.Location = new System.Drawing.Point(523, 17);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 33);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOk.Location = new System.Drawing.Point(437, 17);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(80, 33);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "Add";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.82403F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.17597F));
			this.tableLayoutPanel.Controls.Add(this.labelInitialBalance, 0, 6);
			this.tableLayoutPanel.Controls.Add(this.labelCurrency, 0, 5);
			this.tableLayoutPanel.Controls.Add(this.labelBankAccountId, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.labelBankAgencyId, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.labelBankName, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.textBoxBankAccountId, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.textBoxBankAgencyId, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.textBoxBankName, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelShortName, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelName, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.textBoxShortName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.textBoxInitialBalance, 1, 6);
			this.tableLayoutPanel.Controls.Add(this.comboBoxCurrency, 1, 5);
			this.tableLayoutPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 7;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(592, 240);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// labelInitialBalance
			// 
			this.labelInitialBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelInitialBalance.AutoSize = true;
			this.labelInitialBalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInitialBalance.Location = new System.Drawing.Point(3, 212);
			this.labelInitialBalance.Name = "labelInitialBalance";
			this.labelInitialBalance.Size = new System.Drawing.Size(107, 19);
			this.labelInitialBalance.TabIndex = 21;
			this.labelInitialBalance.Text = "Initial Balance";
			// 
			// labelCurrency
			// 
			this.labelCurrency.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelCurrency.AutoSize = true;
			this.labelCurrency.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCurrency.Location = new System.Drawing.Point(3, 177);
			this.labelCurrency.Name = "labelCurrency";
			this.labelCurrency.Size = new System.Drawing.Size(72, 19);
			this.labelCurrency.TabIndex = 20;
			this.labelCurrency.Text = "Currency";
			// 
			// labelBankAccountId
			// 
			this.labelBankAccountId.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelBankAccountId.AutoSize = true;
			this.labelBankAccountId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBankAccountId.Location = new System.Drawing.Point(3, 143);
			this.labelBankAccountId.Name = "labelBankAccountId";
			this.labelBankAccountId.Size = new System.Drawing.Size(105, 19);
			this.labelBankAccountId.TabIndex = 19;
			this.labelBankAccountId.Text = "Bank Account";
			// 
			// labelBankAgencyId
			// 
			this.labelBankAgencyId.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelBankAgencyId.AutoSize = true;
			this.labelBankAgencyId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBankAgencyId.Location = new System.Drawing.Point(3, 109);
			this.labelBankAgencyId.Name = "labelBankAgencyId";
			this.labelBankAgencyId.Size = new System.Drawing.Size(100, 19);
			this.labelBankAgencyId.TabIndex = 18;
			this.labelBankAgencyId.Text = "Bank Agency";
			// 
			// labelBankName
			// 
			this.labelBankName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelBankName.AutoSize = true;
			this.labelBankName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBankName.Location = new System.Drawing.Point(3, 75);
			this.labelBankName.Name = "labelBankName";
			this.labelBankName.Size = new System.Drawing.Size(89, 19);
			this.labelBankName.TabIndex = 17;
			this.labelBankName.Text = "Bank Name";
			// 
			// textBoxBankAccountId
			// 
			this.textBoxBankAccountId.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxBankAccountId.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textBoxBankAccountId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxBankAccountId.Location = new System.Drawing.Point(161, 139);
			this.textBoxBankAccountId.MaxLength = 10;
			this.textBoxBankAccountId.Name = "textBoxBankAccountId";
			this.textBoxBankAccountId.Size = new System.Drawing.Size(106, 27);
			this.textBoxBankAccountId.TabIndex = 10;
			// 
			// textBoxBankAgencyId
			// 
			this.textBoxBankAgencyId.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxBankAgencyId.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textBoxBankAgencyId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxBankAgencyId.Location = new System.Drawing.Point(161, 105);
			this.textBoxBankAgencyId.MaxLength = 10;
			this.textBoxBankAgencyId.Name = "textBoxBankAgencyId";
			this.textBoxBankAgencyId.Size = new System.Drawing.Size(106, 27);
			this.textBoxBankAgencyId.TabIndex = 8;
			// 
			// textBoxBankName
			// 
			this.textBoxBankName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxBankName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxBankName.Location = new System.Drawing.Point(161, 71);
			this.textBoxBankName.MaxLength = 10;
			this.textBoxBankName.Name = "textBoxBankName";
			this.textBoxBankName.Size = new System.Drawing.Size(336, 27);
			this.textBoxBankName.TabIndex = 5;
			// 
			// textBoxName
			// 
			this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxName.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textBoxName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.Location = new System.Drawing.Point(161, 37);
			this.textBoxName.MaxLength = 50;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(336, 27);
			this.textBoxName.TabIndex = 3;
			// 
			// labelShortName
			// 
			this.labelShortName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelShortName.AutoSize = true;
			this.labelShortName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelShortName.Location = new System.Drawing.Point(3, 7);
			this.labelShortName.Name = "labelShortName";
			this.labelShortName.Size = new System.Drawing.Size(148, 19);
			this.labelShortName.TabIndex = 0;
			this.labelShortName.Text = "Unique Short Name";
			// 
			// labelName
			// 
			this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(3, 41);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(50, 19);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Name";
			// 
			// textBoxShortName
			// 
			this.textBoxShortName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxShortName.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textBoxShortName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxShortName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxShortName.Location = new System.Drawing.Point(161, 3);
			this.textBoxShortName.MaxLength = 10;
			this.textBoxShortName.Name = "textBoxShortName";
			this.textBoxShortName.Size = new System.Drawing.Size(133, 27);
			this.textBoxShortName.TabIndex = 1;
			// 
			// textBoxInitialBalance
			// 
			this.textBoxInitialBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxInitialBalance.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textBoxInitialBalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInitialBalance.Location = new System.Drawing.Point(161, 208);
			this.textBoxInitialBalance.MaxLength = 50;
			this.textBoxInitialBalance.Name = "textBoxInitialBalance";
			this.textBoxInitialBalance.Size = new System.Drawing.Size(336, 27);
			this.textBoxInitialBalance.TabIndex = 14;
			// 
			// comboBoxCurrency
			// 
			this.comboBoxCurrency.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxCurrency.BackColor = System.Drawing.SystemColors.ControlLight;
			this.comboBoxCurrency.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxCurrency.FormattingEnabled = true;
			this.comboBoxCurrency.Location = new System.Drawing.Point(161, 173);
			this.comboBoxCurrency.Name = "comboBoxCurrency";
			this.comboBoxCurrency.Size = new System.Drawing.Size(133, 27);
			this.comboBoxCurrency.TabIndex = 12;
			// 
			// AddAccountDialog
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(616, 334);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.panelButtons);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddAccountDialog";
			this.Text = "Add Bank Deposit Account";
			this.Shown += new System.EventHandler(this.AddAccountDialog_Shown);
			this.panelButtons.ResumeLayout(false);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelShortName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxShortName;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label labelBankName;
		private System.Windows.Forms.TextBox textBoxInitialBalance;
		private System.Windows.Forms.TextBox textBoxBankAccountId;
		private System.Windows.Forms.TextBox textBoxBankAgencyId;
		private System.Windows.Forms.TextBox textBoxBankName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelInitialBalance;
		private System.Windows.Forms.Label labelCurrency;
		private System.Windows.Forms.Label labelBankAccountId;
		private System.Windows.Forms.Label labelBankAgencyId;
		private System.Windows.Forms.ComboBox comboBoxCurrency;

	}
}