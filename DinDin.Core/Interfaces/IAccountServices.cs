using System;

using DinDin.Core.Model;

namespace DinDin.Core.Interfaces
{
	public interface IAccountServices
	{
		BankDepositAccount CreateBankDepositAccount(string shortName, string name, string bankName, string bankAgencyId, string bankAccountId, string currency, decimal initialBalance);
		BankDepositAccount[] ListOfAccounts { get; }
	}
}
