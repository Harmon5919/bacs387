using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class CheckingAccount: Account
    {
        public CheckingAccount(string name, int transactionCount, string acctType, int acctBal, bool open) : base(name, transactionCount, acctType, acctBal, open)
        {

        }
    }
}
