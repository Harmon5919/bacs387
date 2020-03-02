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
            Account hannaChecking = new Account("Hanna", "Checking", 0, 1000, true);
            Account hannaSavings = new Account("Hanna", "Savings", 0, 2000, false);
            List<Account> bankAccounts = new List<Account>();
            bankAccounts.Add(hannaChecking);
            bankAccounts.Add(hannaSavings);

            BankBalance myBank = new BankBalance(bankAccounts, 0, 0);
            

            
            Console.WriteLine(hannaChecking.Name + "'s " + hannaChecking.AcctType + " account has a balance of " + hannaChecking.CheckBalance());
            Console.WriteLine(hannaChecking.Name + "'s " + hannaChecking.AcctType + " account has a balance of " + hannaChecking.AddFunds(17));
            Console.WriteLine(hannaChecking.Name + "'s " + hannaChecking.AcctType + " account has had " + hannaChecking.TransactionCount + " transaction(s)");
            hannaChecking.CloseAccount();

            Console.WriteLine(hannaSavings.Name + "'s " + hannaSavings.AcctType + " account has a balance of " + hannaSavings.CheckBalance());
            Console.WriteLine(hannaSavings.Name + "'s " + hannaSavings.AcctType + " account has a balance of " + hannaSavings.AddFunds(-10));
            Console.WriteLine(hannaSavings.Name + "'s " + hannaSavings.AcctType + " account has had " + hannaSavings.TransactionCount + " transaction(s)");
            hannaSavings.CloseAccount();
            Console.ReadKey();
        }
    }
}
