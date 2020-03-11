using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class SavingsAccount: Account
    {
        public SavingsAccount(string name, int transactionCount, int acctBal, bool open, double interestRate): base(name, transactionCount, acctBal, open)
        {
            this.InterestRate = interestRate;
        }
        public double InterestRate { get; set; }
    }
}
