using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.Main
{
    internal class Bank
    {
        public int ID;
        static int _count;
       public User[] Users;

        public Bank()
        {
           ID=++_count;
        }
        static Bank()
        {
            _count = 1000;
        }


    }

}
