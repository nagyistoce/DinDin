using System;
using System.Collections.Generic;
using System.Text;

using DinDin.Core.Model;

namespace DinDin.Core.Interfaces
{
	public interface IAccountRepository
	{
		bool Exists(string shortName);

		BankDepositAccount Fetch(string shortName);

		void Create(BankDepositAccount account);
		void Update(BankDepositAccount account);

		BankDepositAccount[] FetchAll();
	}
}
