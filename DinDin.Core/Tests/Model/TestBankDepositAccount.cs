using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace DinDin.Core.Model
{
	[TestFixture]
	public class TestBankDepositAccount
	{
		#region Issue 4: User Story: Add a bank deposit account with initial balance

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailNoShortname()
		{
			BankDepositAccount.Create(null, "name","bankname","001", "999-9","R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailEmptyShortname()
		{
			BankDepositAccount.Create(string.Empty, "name", "bankname", "001", "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailNoName()
		{
			BankDepositAccount.Create("myBANK_01", null, "bankname", "001", "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailEmptyName()
		{
			BankDepositAccount.Create("myBANK_02", string.Empty, "bankname", "001", "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailNoAgencyId()
		{
			BankDepositAccount.Create("myBANK_03", "name", "bankname", null, "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailEmptyAgencyId()
		{
			BankDepositAccount.Create("myBANK_04", "name", "bankname", string.Empty, "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailNoAccountId()
		{
			BankDepositAccount.Create("myBANK_05", "name", "bankname", "001", null, "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailEmptyAccountId()
		{
			BankDepositAccount.Create("myBANK_06", "name", "bankname", "001", string.Empty, "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailZeroedInitialBalance()
		{
			BankDepositAccount.Create("myBANK_08", "name", "bankname", "001", "999-9", "R$", 0m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailNegativeInitialBalance()
		{
			BankDepositAccount.Create("myBANK_09", "name", "bankname", "001", "999-9", "R$", -1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailNoCurrency()
		{
			BankDepositAccount.Create("myBANK_10", "name", "bankname", "001", "999-9", null, 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateAccount_FailEmptyCurrency()
		{
			BankDepositAccount.Create("myBANK_11", "name", "bankname", "001", "999-9", string.Empty, 1m);
		}

		[Test]
		public void CreateAccount_SucceedNoDefaults()
		{
			BankDepositAccount account = BankDepositAccount.Create("myBANK_12", "name", "bankname", "001", "999-9", "R$", 1m);
			Assert.IsNotNull(account);
			Assert.AreEqual("MYBANK_12", account.ShortName); // Uppercase
			Assert.AreEqual("name", account.Name);
			Assert.AreEqual("bankname", account.BankName);
			Assert.AreEqual("001", account.BankAgencyId);
			Assert.AreEqual("999-9", account.BankAccountId);
			Assert.AreEqual("R$", account.Currency);
			Assert.AreEqual(1m, account.InitialBalance);
			Assert.GreaterOrEqual(DateTime.Now, account.DateOfCreation);
			Assert.Less(DateTime.Now.AddMinutes(-5), account.DateOfCreation);
		}

		[Test]
		public void CreateAccounts_TestEqualsNot()
		{
			BankDepositAccount account1 = BankDepositAccount.Create("myBANK_13", "name", "bankname", "001", "999-9", "R$", 1m);
			Assert.AreNotEqual(account1, null);
			Assert.AreNotEqual(account1, "notAnAccount");
			BankDepositAccount account2 = BankDepositAccount.Create("myBANK_14", "name", "bankname", "001", "999-9", "R$", 1m);
			Assert.IsNotNull(account1);
			Assert.IsNotNull(account2);
			Assert.AreNotEqual(account1,account2);
			account2 = BankDepositAccount.Create("myBANK_13", "nameother", "bankname", "001", "999-9", "R$", 1m);
			Assert.IsNotNull(account2);
			Assert.AreNotEqual(account1, account2);
			account2 = BankDepositAccount.Create("myBANK_13", "name", "banknameother", "001", "999-9", "R$", 1m);
			Assert.IsNotNull(account2);
			Assert.AreNotEqual(account1, account2);
			account2 = BankDepositAccount.Create("myBANK_13", "name", "bankname", "001other", "999-9", "R$", 1m);
			Assert.IsNotNull(account2);
			Assert.AreNotEqual(account1, account2);
			account2 = BankDepositAccount.Create("myBANK_13", "name", "bankname", "001", "999-9other", "R$", 1m);
			Assert.IsNotNull(account2);
			Assert.AreNotEqual(account1, account2);
			account2 = BankDepositAccount.Create("myBANK_13", "name", "bankname", "001", "999-9", "R$other", 1m);
			Assert.IsNotNull(account2);
			Assert.AreNotEqual(account1, account2);
			account2 = BankDepositAccount.Create("myBANK_13", "name", "bankname", "001", "999-9", "R$", 3m);
			Assert.IsNotNull(account2);
			Assert.AreNotEqual(account1, account2);
		}

		[Test]
		public void CreateAccount_TestEquals()
		{
			BankDepositAccount account1 = BankDepositAccount.Create("myBANK_15", "name", "bankname", "001", "999-9", "R$", 1m);
			BankDepositAccount account2 = BankDepositAccount.Create("myBANK_15", "name", "bankname", "001", "999-9", "R$", 1m);
			Assert.IsNotNull(account1);
			Assert.IsNotNull(account2);
			Assert.AreEqual(account1, account2);
		}
		#endregion
	}
}
