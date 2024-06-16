using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyATMApplication
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public double InterestRate { get; private set; }
        public string AccountHolderName { get; private set; }
        private List<string> transactions;

        public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            InterestRate = interestRate;
            AccountHolderName = accountHolderName;
            transactions = new List<string>();
            transactions.Add($"Account created with balance {Balance:C}");
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            transactions.Add($"Deposited {amount:C}, New Balance: {Balance:C}");
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                transactions.Add($"Withdrew {amount:C}, New Balance: {Balance:C}");
                return true;
            }
            transactions.Add($"Failed Withdrawal of {amount:C}, Balance: {Balance:C}");
            return false;
        }

        public string GetBalance()
        {
            return Balance.ToString("C");
        }

        public List<string> GetTransactions()
        {
            return transactions;
        }
    }
}

