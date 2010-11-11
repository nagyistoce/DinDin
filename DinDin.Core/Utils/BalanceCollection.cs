using System;
using System.Collections.Generic;
using System.Text;

using DinDin.Core.Model;

namespace DinDin.Core.Utils
{
	public class BalanceCollection
	{
		private readonly Dictionary<string, decimal> balances = new Dictionary<string, decimal>();
		private string separator = "\n    ";

		public void AccumulateBalance(BankDepositAccount account)
		{
			if (balances.ContainsKey(account.Currency)) {
				balances[account.Currency] += account.FinalBalance;
			} else {
				balances.Add(account.Currency, account.FinalBalance);
			}
		}

		public string Formatted
		{
			get
			{
				StringBuilder sb = new StringBuilder();
				foreach (string currency in balances.Keys)
					sb.AppendFormat("{2}{0} {1:#,##0.00}", currency, balances[currency], separator);
				return sb.ToString();
			}
		}
	}
}
