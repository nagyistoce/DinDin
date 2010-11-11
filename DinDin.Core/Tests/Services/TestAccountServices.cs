using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using DinDin.Core.Exceptions;
using DinDin.Core.Interfaces;
using DinDin.Core.Model;

namespace DinDin.Core.Services
{
	[TestFixture]
	public class TestAccountServices : IAccountRepository
	{
		IAccountServices services;

		#region Issue 4: User Story: Add a bank deposit account with initial balance

		[TestFixtureSetUp]
		public void Initialize()
		{
			services = new AccountServices(this);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailNoShortname()
		{
			services.CreateBankDepositAccount(null, "name", "bankname", "001", "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailEmptyShortname()
		{
			services.CreateBankDepositAccount(string.Empty, "name", "bankname", "001", "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailNoName()
		{
			services.CreateBankDepositAccount("myBANK_01", null, "bankname", "001", "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailEmptyName()
		{
			services.CreateBankDepositAccount("myBANK_02", string.Empty, "bankname", "001", "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailNoAgencyId()
		{
			services.CreateBankDepositAccount("myBANK_03", "name", "bankname", null, "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailEmptyAgencyId()
		{
			services.CreateBankDepositAccount("myBANK_04", "name", "bankname", string.Empty, "999-9", "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailNoAccountId()
		{
			services.CreateBankDepositAccount("myBANK_05", "name", "bankname", "001", null, "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailEmptyAccountId()
		{
			services.CreateBankDepositAccount("myBANK_06", "name", "bankname", "001", string.Empty, "R$", 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailZeroedInitialBalance()
		{
			services.CreateBankDepositAccount("myBANK_08", "name", "bankname", "001", "999-9", "R$", 0m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailNegativeInitialBalance()
		{
			services.CreateBankDepositAccount("myBANK_09", "name", "bankname", "001", "999-9", "R$", -1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailNoCurrency()
		{
			services.CreateBankDepositAccount("myBANK_10", "name", "bankname", "001", "999-9", null, 1m);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateBankDepositAccount_FailEmptyCurrency()
		{
			services.CreateBankDepositAccount("myBANK_11", "name", "bankname", "001", "999-9", string.Empty, 1m);
		}

		[Test]
		public void CreateBankDepositAccount_SucceedNoDefaults()
		{
			BankDepositAccount account = services.CreateBankDepositAccount("myBANK_12", "name", "bankname", "001", "999-9", "R$", 1m);
			Assert.IsNotNull(account);
			Assert.AreEqual("MYBANK_12", account.ShortName); // uppercase
			Assert.AreEqual("name", account.Name);
			Assert.AreEqual("bankname", account.BankName);
			Assert.AreEqual("001", account.BankAgencyId);
			Assert.AreEqual("999-9", account.BankAccountId);
			Assert.AreEqual("R$", account.Currency);
			Assert.AreEqual(1m, account.InitialBalance);
			Assert.GreaterOrEqual(DateTime.Now, account.DateOfCreation);
			Assert.Less(DateTime.Now.AddMinutes(-5), account.DateOfCreation);
		}

		[Test, ExpectedException(typeof(DuplicateInstanceException))]
		public void CreateBankDepositAccount_FailsDuplicateShortName()
		{
			BankDepositAccount account = services.CreateBankDepositAccount("myBANK_13", "name", "bankname", "001", "999-9", "R$", 1m);
			Assert.IsNotNull(account);
			services.CreateBankDepositAccount("myBANK_13", "name", "bankname", "001", "999-9", "R$", 1m);
		}

		#endregion

		[Test]
		public void ListAccounts_EmptyRepo_EmptyResult()
		{
			accounts.Clear();
			BankDepositAccount[] list = services.ListOfAccounts;
			Assert.IsEmpty(list);
		}

		[Test]
		public void ListAccounts_OneAccountRepo_OneAccountResult()
		{
			accounts.Clear();
			BankDepositAccount account = services.CreateBankDepositAccount("myBANK_14", "name", "bankname", "001", "999-9", "R$", 1m);
			BankDepositAccount[] list = services.ListOfAccounts;
			Assert.IsNotNull(list);
			Assert.AreEqual(1,list.Length);
			Assert.AreEqual(account.ShortName, list[0].ShortName);
		}

		[Test]
		public void ListAccounts_UnorderedAccountsRepo_OrderedAccountsResult()
		{
			accounts.Clear();
			string[] names = new string[] { "BANK_C", "Bank_B", "BanK_A" };
			foreach(string name in names)
				services.CreateBankDepositAccount(name, "name", "bankname", "001", "999-9", "R$", 1m);
			BankDepositAccount[] list = services.ListOfAccounts;
			Assert.IsNotNull(list);
			Assert.AreEqual(names.Length, list.Length);
			Array.Sort(names);
			int i = 0;
			foreach(string name in names)
				Assert.AreEqual(name.ToUpperInvariant(), list[i++].ShortName);
		}

		#region IAccountRepository Members

		private Dictionary<string, BankDepositAccount> accounts = new Dictionary<string,BankDepositAccount>();

		bool IAccountRepository.Exists(string shortName)
		{
			return accounts.ContainsKey(shortName.ToUpperInvariant());
		}

		BankDepositAccount IAccountRepository.Fetch(string shortName)
		{
			return accounts[shortName.ToUpperInvariant()];
		}

		void IAccountRepository.Create(BankDepositAccount account)
		{
			if (accounts.ContainsKey(account.ShortName))
				throw new InvalidOperationException();
			accounts.Add(account.ShortName, account);
		}

		void IAccountRepository.Update(BankDepositAccount account)
		{
			if (!accounts.ContainsKey(account.ShortName))
				throw new InvalidOperationException();
			accounts[account.ShortName] = account;
		}

		public BankDepositAccount[] FetchAll()
		{
			List<BankDepositAccount> result = new List<BankDepositAccount>();
			foreach (BankDepositAccount account in accounts.Values)
				result.Add(account);
			result.Sort();
			return result.ToArray();
		}

		#endregion
	}
}
