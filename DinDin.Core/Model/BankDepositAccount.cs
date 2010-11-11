using System;
using System.Collections.Generic;
using System.Text;

namespace DinDin.Core.Model
{
	[Serializable]
	public class BankDepositAccount : IComparable<BankDepositAccount>
	{
		private string shortName;

		public string ShortName
		{
			get { return shortName; }
			set { shortName = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string bankName;

		public string BankName
		{
			get { return bankName; }
			set { bankName = value; }
		}
		private string bankAgencyId;

		public string BankAgencyId
		{
			get { return bankAgencyId; }
			set { bankAgencyId = value; }
		}
		private string bankAccountId;

		public string BankAccountId
		{
			get { return bankAccountId; }
			set { bankAccountId = value; }
		}
		private string currency;

		public string Currency
		{
			get { return currency; }
			set { currency = value; }
		}
		private decimal initialBalance;

		public decimal InitialBalance
		{
			get { return initialBalance; }
			set { initialBalance = value; }
		}

		public decimal FinalBalance
		{
			get { return initialBalance; } // TODO:compute from history transaction or partial balances
		}

		public string FormattedBalance
		{
			get { return string.Format("{0} {1:#,##0.00}", Currency, FinalBalance); }
		}

		private DateTime dateOfCreation;

		public DateTime DateOfCreation
		{
			get { return dateOfCreation; }
			set { dateOfCreation = value; }
		}


		public static BankDepositAccount Create(
			string shortName,
			string name,
			string bankName,
			string bankAgencyId,
			string bankAccountId,
			string currency,
			decimal initialBalance)
		{
			if (string.IsNullOrEmpty(shortName))
				throw new ArgumentException("Parameter shortName cannot be null or empty");
			if (string.IsNullOrEmpty(name))
				throw new ArgumentException("Parameter name cannot be null or empty");
			if (string.IsNullOrEmpty(bankAgencyId))
				throw new ArgumentException("Parameter bankAgencyId cannot be null or empty");
			if (string.IsNullOrEmpty(bankAccountId))
				throw new ArgumentException("Parameter bankAccountId cannot be null or empty");
			if (string.IsNullOrEmpty(currency))
				throw new ArgumentException("Parameter currency cannot be null or empty");
			if (initialBalance <= 0)
				throw new ArgumentException("Parameter initialBalance must greater than zero");
			BankDepositAccount account = new BankDepositAccount();
			account.shortName = shortName.ToUpperInvariant();
			account.name = name;
			account.bankName = bankName;
			account.bankAgencyId = bankAgencyId;
			account.bankAccountId = bankAccountId;
			account.currency = currency;
			account.InitialBalance = initialBalance;
			account.dateOfCreation = DateTime.Now;
			return account;
		}

		public override bool Equals(object obj)
		{
			BankDepositAccount other = obj as BankDepositAccount;
			if (other == null)
				return false;
			return shortName.Equals(other.shortName)
				&& name.Equals(other.name)
				&& bankAccountId.Equals(other.bankAccountId)
				&& bankAgencyId.Equals(other.bankAgencyId)
				&& currency.Equals(other.currency)
				&& initialBalance == other.initialBalance
				&& ((bankName != null && bankName.Equals(other.bankName)) ||
					(bankName == null && other.bankName == null));
		}

		public override int GetHashCode()
		{
			return shortName.GetHashCode();
		}

		public override string ToString()
		{
			return shortName;
		}

		#region IComparable<BankDepositAccount> Members

		public int CompareTo(BankDepositAccount other)
		{
			return other == null ? 1 : shortName.CompareTo(other.shortName);
		}

		#endregion
	}
}
