using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DinDin.Core.Interfaces;
using DinDin.Core.Model;
using DinDin.Core.Utils;

namespace DinDin.Desktop
{
	public partial class MainForm : Form
	{
		private IAccountServices accountServices;

		public MainForm()
		{
			accountServices = Program.GetService<IAccountServices>();
			InitializeComponent();
			PopulateAccountsTabControl();
		}

		private void newAccountMenuItem_Click(object sender, EventArgs e)
		{
			AddAccountDialog dialog = new AddAccountDialog(accountServices);
			dialog.ShowDialog(this);
			PopulateAccountsTabControl();
		}

		private void PopulateAccountsTabControl()
		{
			tabControlAccounts.SuspendLayout();
			BalanceCollection balancesByCurrency = new BalanceCollection();
			while (tabControlAccounts.TabPages.Count > 1)
				tabControlAccounts.TabPages.RemoveAt(1);
			foreach (BankDepositAccount account in accountServices.ListOfAccounts) {
				TabPage accountPage = new TabPage();
				accountPage.Text = account.Name;
				accountPage.BackColor = System.Drawing.Color.MintCream;
				accountPage.Location = new System.Drawing.Point(4, 28);
				accountPage.Name = "tabPage" + account.ShortName;
				accountPage.Padding = new System.Windows.Forms.Padding(3);
				accountPage.Size = new System.Drawing.Size(446, 275);
				accountPage.TabIndex = tabControlAccounts.TabPages.Count;
				Label labelAccountBalance = new Label();
				labelAccountBalance.AutoSize = true;
				labelAccountBalance.Location = new System.Drawing.Point(8, 13);
				labelAccountBalance.Name = "label" + account.ShortName + "Balance";
				labelAccountBalance.Size = new System.Drawing.Size(119, 19);
				labelAccountBalance.TabIndex = 0;
				labelAccountBalance.Text = "Balance: "+ account.FormattedBalance;
				balancesByCurrency.AccumulateBalance(account);
				accountPage.Controls.Add(labelAccountBalance);
				tabControlAccounts.TabPages.Add(accountPage);
			}
			labelBalance.Text = "Balance: " + balancesByCurrency.Formatted;
			tabControlAccounts.ResumeLayout(true);
		}


		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}