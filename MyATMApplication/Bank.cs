using MyATMApplication;
using System;
using System.Collections.Generic;

namespace AtmApplication
{
    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            accounts = new List<Account>();
            for (int i = 100; i < 110; i++)
            {
                accounts.Add(new Account(i, 100.0, 0.03, $"Default Account {i}"));
            }
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public Account RetrieveAccount(int accountNumber)
        {
            return accounts.Find(a => a.AccountNumber == accountNumber);
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }
    }
}
