using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class Account
    {
        public Account(string name, string acctType, int transactionCount, double acctBal, bool open)
        {
            this.Name = name;
            this.AcctType = acctType;
            this.TransactionCount = transactionCount;
            this.AcctBal = acctBal;
            this.Open = open;
        }
        public string Name { get; set; }
        public string AcctType { get; set; }
        private int TransactionCount { get; set; }
        private double AcctBal { get; set; }
        private bool Open { get; set; }
        public void CloseAccount()
        {
            if (this.Open == false)
            {
                Console.WriteLine(this.Name + "'s " + this.AcctType + " account has been closed");
            }
            if (this.Open == true)
            {
                Console.WriteLine(this.Name + "'s " + this.AcctType + " account is active");
            }
        }
        public double AddFunds(double increase)
        {
            double balance = this.AcctBal;
            balance += increase;
            this.TransactionCount++;
            return balance;
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
    }
}
