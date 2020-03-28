using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class SavingsAccount: Account
    {
        public SavingsAccount(string name, int transactionCount, string acctType, int acctBal, bool open, double interestRate) : base(name, transactionCount, acctType, acctBal, open)
        {
            this.InterestRate = interestRate;
        }
        public double InterestRate { get; set; }
        public double GetInterestRate()
        {
            return this.InterestRate;
        }
    }
}
