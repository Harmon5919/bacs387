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
            Console.WriteLine(hannaChecking.Name + "'s " + hannaChecking.AcctType + " account has had " + hannaChecking.GetTransactionCount() + " transaction(s)");
            hannaChecking.CloseAccount();

            Console.WriteLine(hannaSavings.Name + "'s " + hannaSavings.AcctType + " account has a balance of " + hannaSavings.CheckBalance());
            Console.WriteLine(hannaSavings.Name + "'s " + hannaSavings.AcctType + " account has a balance of " + hannaSavings.AddFunds(-10));
            Console.WriteLine(hannaSavings.Name + "'s " + hannaSavings.AcctType + " account has had " + hannaSavings.GetTransactionCount() + " transaction(s)");
            hannaSavings.CloseAccount();

            myBank.ListAllMembers();
            Console.WriteLine("This bank has: " + "\n" + "$" +
                    myBank.GetBankTotal() + "\n" +
                    myBank.GetAcctTypeCount("checking") + " checking accounts" + "\n" + 
                    myBank.GetAcctTypeCount("saving") + " savings accounts" + "\n" + 
                    myBank.GetTransactionCount() + " total transactions");
            Console.ReadKey();
            //1 AcctBal property is private to keep the account balances from being arbitrarily changed without user deposits or withdrawls
            //2 Open property is private to keep accounts from being closed without user/official permission
            //3 BankBal property is private to keep the bank's total balance from being visible to unauthorized users, and to keep it from being changed arbitrarily
            //4 TransactionCount (Account) and 5 TransactionNum (BankBalance) are private to prevent arbitrary changes, because they are calculated as transactions occur, no reason for user to change.
        }
    }
}
