using System;
using System.Collections.Generic;
using System.Text;

using DinDin.Core.Exceptions;
using DinDin.Core.Interfaces;
using DinDin.Core.Model;

namespace DinDin.Core.Services
{
	public class AccountServices : IAccountServices
	{
		private readonly IAccountRepository repository;

		public AccountServices(IAccountRepository repository)
		{
			this.repository = repository;
		}

		public BankDepositAccount CreateBankDepositAccount(
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
			if (repository.Exists(shortName))
				throw new DuplicateInstanceException("Account", "ShortName");
			BankDepositAccount account = BankDepositAccount.Create(
				shortName,
				name,
				bankName,
				bankAgencyId,
				bankAccountId,
				currency,
				initialBalance);
			repository.Create(account);
			return account;
		}

		public BankDepositAccount[] ListOfAccounts
		{
			get { return repository.FetchAll(); }
		}
	}
}
