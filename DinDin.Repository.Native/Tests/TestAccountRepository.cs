using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using NUnit.Framework;

using DinDin.Core.Interfaces;
using DinDin.Core.Model;
using DinDin.Repository.Native;

namespace Tests
{
	[TestFixture]
	public class TestAccountRepository
	{
		IAccountRepository repository;
		IAccountRepository repositoryAlternate;

		[TestFixtureSetUp]
		public void Initialize()
		{
			string basedir = Path.Combine(Path.GetTempPath(), "TestAccountRepository");
			if (Directory.Exists(basedir))
				Directory.Delete(basedir, true);
			Directory.CreateDirectory(basedir);
			repository = new AccountRepository(basedir);
			repositoryAlternate = new AccountRepository(basedir);
		}

		[Test]
		public void CreateAccount_FetchSameWithOtherRepositoryInstance()
		{
			BankDepositAccount account = BankDepositAccount.Create("ABCDEF", "abc", "abc", "001", "00099-9", "R$", 1m);
			repository.Create(account);
			BankDepositAccount readAccount = repositoryAlternate.Fetch(account.ShortName);
			Assert.AreEqual(account, readAccount);
		}

		[Test]
		public void CreateAccount_ExistsSameInOtherRepositoryInstance()
		{
			BankDepositAccount account = BankDepositAccount.Create("XYZDEF", "abc", "abc", "001", "00099-9", "R$", 1m);
			repository.Create(account);
			Assert.IsTrue(repositoryAlternate.Exists(account.ShortName));
		}

		[Test]
		public void CreateAccount_ListReturnsAtLeastIt_InOtherRepositoryInstance()
		{
			BankDepositAccount account = BankDepositAccount.Create("XYZWWW", "abc", "abc", "001", "00099-9", "R$", 1m);
			repository.Create(account);
			BankDepositAccount[] list = repositoryAlternate.FetchAll();
			Assert.IsNotNull(list);
			Assert.IsNotEmpty(list);
			bool found = false;
			foreach (BankDepositAccount readAccount in list)
				if (account.Equals(readAccount)) {
					found = true;
					break;
				}
			Assert.IsTrue(found, "Account not found in read list");
		}
	}
}
