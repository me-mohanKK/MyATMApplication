using AtmApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyATMApplication
{
    public class AtmApplication
    {
        private Bank bank;
        private Account selectedAccount;

        public AtmApplication()
        {
            bank = new Bank();
        }

        public void Run()
        {
            while (true)
            {
                DisplayMainMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateAccount();
                        break;
                    case "2":
                        SelectAccount();
                        break;
                    case "3":
                        Console.Write("Are you sure you want to exit? (y/n): ");
                        string confirm = Console.ReadLine().ToLower();
                        if (confirm == "y")
                        {
                            Console.Write("Thanks for using the ATM Application");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("!! ATM Main Menu !!");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Select Account");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
        }

        private void CreateAccount()
        {
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            Console.Write("Enter annual interest rate (in percentage): ");
            double interestRate = double.Parse(Console.ReadLine()) / 100.0;

            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();

            Account newAccount = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
            bank.AddAccount(newAccount);

            Console.WriteLine("Account created successfully.");
        }

        private void SelectAccount()
        {
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            selectedAccount = bank.RetrieveAccount(accountNumber);
            if (selectedAccount == null)
            {
                Console.WriteLine("Account not found.");
                return;

            }

            // Welcome message
            Console.WriteLine($"Welcome, {selectedAccount.AccountHolderName}!!!!!");

            while (true)
            {
                DisplayAccountMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        Console.WriteLine($"Balance: {selectedAccount.GetBalance()}");
                        break;
                    case "b":
                        Deposit();
                        break;
                    case "c":
                        Withdraw();
                        break;
                    case "d":
                        DisplayTransactions();
                        break;
                    case "e":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void DisplayAccountMenu()
        {
            Console.WriteLine("Account Menu");
            Console.WriteLine("a. Check Balance");
            Console.WriteLine("b. Deposit");
            Console.WriteLine("c. Withdraw");
            Console.WriteLine("d. Display Transactions");
            Console.WriteLine("e. Exit Account");
            Console.Write("Enter choice: ");
        }

        private void Deposit()
        {
            Console.Write("Enter amount to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            selectedAccount.Deposit(amount);
            Console.WriteLine("Deposit successful.");
        }

        private void Withdraw()
        {
            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            if (selectedAccount.Withdraw(amount))
            {
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        private void DisplayTransactions()
        {
            var transactions = selectedAccount.GetTransactions();
            Console.WriteLine("Transactions:");
            foreach (var transaction in transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
