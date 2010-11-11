using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

using DinDin.Core.Exceptions;
using DinDin.Core.Interfaces;
using DinDin.Core.Model;

namespace DinDin.Repository.Native
{
	public class AccountRepository : IAccountRepository
	{
		#region IAccountRepository Members

		private readonly string filepath;
		private Dictionary<string, BankDepositAccount> accounts;
		private BinaryFormatter bf = new BinaryFormatter();

		public AccountRepository(string basedir)
		{
			if (!Directory.Exists(basedir))
				Directory.CreateDirectory(basedir);
			filepath = Path.Combine(basedir, "Accounts.DinDin");
			if (!File.Exists(filepath)) {
				accounts = new Dictionary<string, BankDepositAccount>();
				WriteAccounts();
			} else {
				ReadAccounts();
			}
		}

		private void ReadAccounts()
		{
			using (FileStream fs = File.OpenRead(filepath))
				accounts = (Dictionary<string, BankDepositAccount>)bf.Deserialize(fs);
		}

		private void WriteAccounts()
		{
			using (FileStream fs = File.Create(filepath))
				bf.Serialize(fs, accounts);
		}

		public bool Exists(string shortName)
		{
			ReadAccounts();
			return accounts.ContainsKey(shortName.ToUpperInvariant());
		}

		public BankDepositAccount Fetch(string shortName)
		{
			ReadAccounts();
			string key = shortName.ToUpperInvariant();
			return accounts.ContainsKey(key) ? accounts[key] : null;
		}

		public void Create(BankDepositAccount account)
		{
			ReadAccounts();
			if (accounts.ContainsKey(account.ShortName))
				throw new DuplicateInstanceException("Account", "ShortName");
			accounts.Add(account.ShortName, account);
			WriteAccounts();
		}

		public void Update(BankDepositAccount account)
		{
			ReadAccounts();
			if (!accounts.ContainsKey(account.ShortName))
				throw new InvalidOperationException();
			accounts[account.ShortName] = account;
			WriteAccounts();
		}

		public BankDepositAccount[] FetchAll()
		{
			ReadAccounts();
			List<BankDepositAccount> result = new List<BankDepositAccount>();
			foreach (BankDepositAccount account in accounts.Values)
				result.Add(account);
			result.Sort();
			return result.ToArray();
		}


		#endregion
	}
}
