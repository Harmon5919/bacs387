﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        public A(string name, string account)
        {
            this.Name = name;
            this.Account = account;
        }
        public string Name { get; set; }
        public string Account { get; set; }
    }
}
