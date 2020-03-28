using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount hannaChecking = new CheckingAccount("Hanna", 0, "checking", 1000, true);
            SavingsAccount hannaSavings = new SavingsAccount("Hanna", 0, "savings", 2000, true, .07);
            List<Account> bankAccounts = new List<Account>();
            bankAccounts.Add(hannaChecking);
            bankAccounts.Add(hannaSavings);

            BankBalance myBank = new BankBalance(bankAccounts, 0, 0);


            Console.WriteLine(hannaChecking.Name + "'s checking account has a balance of " + hannaChecking.CheckBalance());
            hannaChecking.AddFunds(17);
            hannaChecking.PrintBalance();
            hannaChecking.GetTransactionCount();
            hannaChecking.CloseAccount();

            Console.WriteLine(hannaSavings.Name + "'s savings account has a balance of " + hannaSavings.CheckBalance());
            hannaSavings.AddFunds(-10);
            hannaSavings.PrintBalance();
            hannaSavings.CloseAccount();
            hannaSavings.GetTransactionCount();

            myBank.ListAllMembers();
            Console.WriteLine("This bank has: " + "\n" + "$" +
            myBank.GetBankTotal() + "\n" +
            myBank.GetAcctTypeCount("checking") + " checking accounts" + "\n" + 
            myBank.GetAcctTypeCount("saving") + " savings accounts" + "\n" + 
            myBank.GetTransactionCount() + " total transactions");
            Console.ReadKey();
        }
    }
}
