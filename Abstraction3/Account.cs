using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class Account
    {
        public Account(string name, string acctType, double acctBal, bool open)
        {
            this.Name = name;
            this.AcctType = acctType;
            this.AcctBal = acctBal;
            this.Open = open;
        }
        public string Name { get; set; }
        public string AcctType { get; set; }
        public double AcctBal { get; set; }
        public bool Open { get; set; }
        public void CloseAccount()
        {
            if (this.Open == false)
            {
                this.AcctType = "Closed";
                Console.WriteLine("This account has been closed");
            }
        }
        public void AddFunds()
        {
            int acctTransactions = 0;
            this.AcctBal += 17.63;
            acctTransactions++;
        }
        public void CheckBalance()
        {
            Console.WriteLine(this.Name + "'s " + this.AcctType + " account has a balance of " + this.AcctBal);
        }
    }
}
