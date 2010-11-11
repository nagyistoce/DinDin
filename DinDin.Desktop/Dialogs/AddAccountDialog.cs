using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DinDin.Core.Interfaces;
using DinDin.Core.Model;
using DinDin.Core.Services;
using System.Threading;

namespace DinDin.Desktop
{
	public partial class AddAccountDialog : Form
	{
		private readonly IAccountServices services;

		public AddAccountDialog(IAccountServices services)
		{
			this.services = services;
			InitializeComponent();
			comboBoxCurrency.Items.Add("US$");
			comboBoxCurrency.Items.Add("R$");
			comboBoxCurrency.SelectedIndex = 0;
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			try {
				Decimal value = Decimal.Parse(textBoxInitialBalance.Text);
				services.CreateBankDepositAccount(
					textBoxShortName.Text,
					textBoxName.Text, 
					textBoxBankName.Text, 
					textBoxBankAgencyId.Text, 
					textBoxBankAccountId.Text, 
					comboBoxCurrency.SelectedItem as string, 
					value);
				Close();
			} catch (FormatException) {
				labelStatus.Text = "Initial Balance isn't a valid number";
			} catch (Exception ex) {
				labelStatus.Text = ex.Message;
			}
		}

		private void AddAccountDialog_Shown(object sender, EventArgs e)
		{
			textBoxShortName.Focus();
		}
	}
}