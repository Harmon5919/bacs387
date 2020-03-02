using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> memberList = new List<Account>();
            memberList.Add(new Account("Hanna", "Checking", 100, true));
            memberList[0].CheckBalance();
            memberList[0].AddFunds();
            memberList[0].CheckBalance();
            memberList[0].CloseAccount();
            Console.ReadKey();
        }
    }
}
