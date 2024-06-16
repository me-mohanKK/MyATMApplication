ATM Application

Project Structure
Classes: 
Account - Represents a bank account.
Fields: AccountNumber, Balance, InterestRate, AccountHolderName, transactions.
Methods: Deposit, Withdraw, GetBalance, GetTransactions.

Bank - Manages a collection of accounts.
Fields: accounts.
Methods: AddAccount, RetrieveAccount, GetAccounts.

AtmApplication - Handles user interaction.
Fields: bank, selectedAccount.
Methods: Run, DisplayMainMenu, CreateAccount, SelectAccount, DisplayAccountMenu, Deposit, Withdraw, DisplayTransactions.
Program

Entry point of the application.
Methods: Main.

Features
Create Account: Add a new account with specific details.
Select Account: Choose an existing account to:
Check Balance: View current balance.
Deposit: Add funds to the account.
Withdraw: Remove funds from the account.
Display Transactions: View transaction history.
Exit: Confirm before exiting and display a thank you message.


Setup Instructions

Prerequisites
Visual Studio or any C# compatible IDE.
.NET Framework.

Installation
Clone the repository:
Copy code
git clone https://github.com/me-mohanKK/MyATMApplication.git
Video Link - https://drive.google.com/file/d/1fjOU9zx4AJze4qZx7wcPPuH3YCMllmPC/view?usp=drive_link
