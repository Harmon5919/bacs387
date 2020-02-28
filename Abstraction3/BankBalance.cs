using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class BankBalance
    {
        public BankBalance(List<Account> customerCount, double totalBal, int transactionNum)
        {
            this.CustomerCount = customerCount;
            this.TotalBal = totalBal;
            this.TransactionNumb = transactionNum;
        }
        public List<Account> CustomerCount { get; set; }
        public double TotalBal { get; set; }
        public int TransactionNumb { get; set; }
    }
}
