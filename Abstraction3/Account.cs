using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class Account
    {
        public Account(string name, int transactionCount, string acctType, double acctBal, bool open)
        {
            this.Name = name;
            this.TransactionCount = transactionCount;
            this.AcctType = acctType;
            this.AcctBal = acctBal;
            this.Open = open;
        }
        public string Name { get; set; }
        private int TransactionCount { get; set; }
        public string AcctType { get; set; }
        private double AcctBal { get; set; }
        private bool Open { get; set; }
        public void CloseAccount()
        {
            this.Open = false;
        }
        public double AddFunds(double increase)
        {
            this.AcctBal += increase;
            this.TransactionCount++;
            return this.AcctBal;
        }
        public double CheckBalance()
        {
            double balance = this.AcctBal;
            this.TransactionCount++;
            return balance;
        }
        public int GetTransactionCount()
        {
            int acctTransactions = this.TransactionCount;
            return acctTransactions;
        }
        public void PrintBalance()
        {
            Console.WriteLine("The account balance is " + this.AcctBal);
        }
    }
}
