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
        public int TransactionNum { get; set; }
        public void ListAllMembers()
        {
            Console.WriteLine("List of Accounts:");
            for (int count = 0; count < this.Customers.Count; count++)
            {
                Console.WriteLine(this.Customers[count].Name + " " + this.Customers[count].AcctType);
            }
        }
    }
}
