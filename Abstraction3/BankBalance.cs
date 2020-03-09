using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class BankBalance
    {
        public BankBalance(List<Account> customers, double totalBal, int transactionNum)
        {
            this.Customers = customers;
            this.TotalBal = totalBal;
            this.TransactionNum = transactionNum;
        }
        public List<Account> Customers { get; set; }
        private double TotalBal { get; set; }
        private int TransactionNum { get; set; }
        public double GetBankTotal()
        {
            double totalBal = 0;
            for (int count = 0; count < this.Customers.Count; count++)
            {
                this.TotalBal += Customers[count].CheckBalance();
                totalBal = this.TotalBal;
            }
            return totalBal;
        }
        public void ListAllMembers()
        {
            Console.WriteLine("List of Accounts:");
            for (int count = 0; count < this.Customers.Count; count++)
            {
                Console.WriteLine(this.Customers[count].Name + " " + this.Customers[count].AcctType);
            }
        }
        public int GetAcctTypeCount(string request)
        {
            int checkingCount = 0;
            int savingsCount = 0;
            int requestedCount = 0;
            for (int i = 0; i < this.Customers.Count; i++)
            {
                if (this.Customers[i].AcctType == "Checking")
                {
                    checkingCount++;
                }
                else
                {
                    savingsCount++;
                }
            }
            if (request == "checking")
            {
                requestedCount = checkingCount;
            }
            else if (request == "saving")
            {
                requestedCount = savingsCount;
            }
            return requestedCount;
        }
        public int GetTransactionCount()
        {
            int transactionCount = 0;
            for (int i = 0; i < Customers.Count; i++)
            {
                transactionCount += Customers[1].GetTransactionCount();
            }
            return transactionCount;
        }
    }
}
