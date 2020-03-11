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
            Account hannaChecking = new CheckingAccount("Hanna", 0, 1000, true);
            Account hannaSavings = new SavingsAccount("Hanna", 0, 2000, false, .07);
            List<Account> bankAccounts = new List<Account>();
            bankAccounts.Add(hannaChecking);
            bankAccounts.Add(hannaSavings);

            BankBalance myBank = new BankBalance(bankAccounts, 0, 0);
            
            
            Console.WriteLine(hannaChecking.Name + "'s checking account has a balance of " + hannaChecking.CheckBalance());
            Console.WriteLine(hannaChecking.Name + "'s checking account has a balance of " + hannaChecking.AddFunds(17));
            Console.WriteLine(hannaChecking.Name + "'s checking account has had " + hannaChecking.GetTransactionCount() + " transaction(s)");
            hannaChecking.CloseAccount();

            Console.WriteLine(hannaSavings.Name + "'s savings account has a balance of " + hannaSavings.CheckBalance());
            Console.WriteLine(hannaSavings.Name + "'s savings account has a balance of " + hannaSavings.AddFunds(-10));
            Console.WriteLine(hannaSavings.Name + "'s savings account has had " + hannaSavings.GetTransactionCount() + " transaction(s)");
            hannaSavings.CloseAccount();

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
