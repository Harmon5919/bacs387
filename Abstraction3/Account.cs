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
            Console.WriteLine(this.Name + "'s " + this.AcctType + " is closed.");
            this.TransactionCount++;
        }
        public double AddFunds(double increase)
        {
            this.AcctBal += increase;
            Console.WriteLine(this.Name + "'s " + this.AcctType + " balance has changed by " + increase);
            this.TransactionCount++;
            return this.AcctBal;
        }
        public double CheckBalance()
        {
            this.TransactionCount++;
            return this.AcctBal;
        }
        public int GetTransactionCount()
        {
            Console.WriteLine(this.Name + "'s " + this.AcctType + " has had " + this.TransactionCount + " transactions.");
            return this.TransactionCount;
        }
        public void PrintBalance()
        {
            Console.WriteLine(this.Name + "'s " + this.AcctType + " balance is " + this.AcctBal);
            this.TransactionCount++;
        }
    }
}
