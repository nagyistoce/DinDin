namespace DinDin.Desktop
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrips = new System.Windows.Forms.ToolStripContainer();
			this.tabControlAccounts = new System.Windows.Forms.TabControl();
			this.tabPageHome = new System.Windows.Forms.TabPage();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.accountsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newAccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelBalance = new System.Windows.Forms.Label();
			this.toolStrips.ContentPanel.SuspendLayout();
			this.toolStrips.TopToolStripPanel.SuspendLayout();
			this.toolStrips.SuspendLayout();
			this.tabControlAccounts.SuspendLayout();
			this.tabPageHome.SuspendLayout();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrips
			// 
			// 
			// toolStrips.ContentPanel
			// 
			this.toolStrips.ContentPanel.AutoScroll = true;
			this.toolStrips.ContentPanel.Controls.Add(this.tabControlAccounts);
			this.toolStrips.ContentPanel.Size = new System.Drawing.Size(454, 307);
			this.toolStrips.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrips.Location = new System.Drawing.Point(0, 0);
			this.toolStrips.Name = "toolStrips";
			this.toolStrips.Size = new System.Drawing.Size(454, 334);
			this.toolStrips.TabIndex = 1;
			this.toolStrips.Text = "toolStrips";
			// 
			// toolStrips.TopToolStripPanel
			// 
			this.toolStrips.TopToolStripPanel.Controls.Add(this.menu);
			// 
			// tabControlAccounts
			// 
			this.tabControlAccounts.Controls.Add(this.tabPageHome);
			this.tabControlAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlAccounts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControlAccounts.Location = new System.Drawing.Point(0, 0);
			this.tabControlAccounts.Name = "tabControlAccounts";
			this.tabControlAccounts.SelectedIndex = 0;
			this.tabControlAccounts.Size = new System.Drawing.Size(454, 307);
			this.tabControlAccounts.TabIndex = 0;
			// 
			// tabPageHome
			// 
			this.tabPageHome.BackColor = System.Drawing.Color.LightYellow;
			this.tabPageHome.Controls.Add(this.labelBalance);
			this.tabPageHome.Location = new System.Drawing.Point(4, 28);
			this.tabPageHome.Name = "tabPageHome";
			this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHome.Size = new System.Drawing.Size(446, 275);
			this.tabPageHome.TabIndex = 0;
			this.tabPageHome.Text = "Home";
			// 
			// menu
			// 
			this.menu.Dock = System.Windows.Forms.DockStyle.None;
			this.menu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsMenuItem});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(454, 27);
			this.menu.TabIndex = 0;
			this.menu.Text = "menus";
			// 
			// accountsMenuItem
			// 
			this.accountsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountMenuItem,
            this.toolStripSeparator,
            this.exitMenuItem});
			this.accountsMenuItem.Name = "accountsMenuItem";
			this.accountsMenuItem.Size = new System.Drawing.Size(85, 23);
			this.accountsMenuItem.Text = "Acco&unts";
			// 
			// newAccountMenuItem
			// 
			this.newAccountMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newAccountMenuItem.Image")));
			this.newAccountMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newAccountMenuItem.Name = "newAccountMenuItem";
			this.newAccountMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newAccountMenuItem.Size = new System.Drawing.Size(325, 24);
			this.newAccountMenuItem.Text = "&New Bank Deposit Account";
			this.newAccountMenuItem.Click += new System.EventHandler(this.newAccountMenuItem_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(322, 6);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(325, 24);
			this.exitMenuItem.Text = "E&xit";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// labelBalance
			// 
			this.labelBalance.AutoSize = true;
			this.labelBalance.Location = new System.Drawing.Point(8, 13);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.Size = new System.Drawing.Size(119, 19);
			this.labelBalance.TabIndex = 0;
			this.labelBalance.Text = "Balance: $ 0.00";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 334);
			this.Controls.Add(this.toolStrips);
			this.MainMenuStrip = this.menu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DinDin Home Finance";
			this.toolStrips.ContentPanel.ResumeLayout(false);
			this.toolStrips.TopToolStripPanel.ResumeLayout(false);
			this.toolStrips.TopToolStripPanel.PerformLayout();
			this.toolStrips.ResumeLayout(false);
			this.toolStrips.PerformLayout();
			this.tabControlAccounts.ResumeLayout(false);
			this.tabPageHome.ResumeLayout(false);
			this.tabPageHome.PerformLayout();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStrips;
		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem accountsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newAccountMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.TabControl tabControlAccounts;
		private System.Windows.Forms.TabPage tabPageHome;
		private System.Windows.Forms.Label labelBalance;
	}
}

