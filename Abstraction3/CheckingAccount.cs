using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class CheckingAccount: Account
    {
        public CheckingAccount(string name, int transactionCount, int acctBal, bool open): base(name, transactionCount, acctBal, open)
        {

        }
        public void GetStatus()
        {
            
        }
    }
}
