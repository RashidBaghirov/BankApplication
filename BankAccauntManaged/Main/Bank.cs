using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.Main
{
    internal class Bank
    {
        public int Id;

        public User[] Users = new User[0];

        static int count = 0;


        public Bank()
        {
            Id = ++count;

        }
        static Bank()
        {
            count = 0;
        }

    }

}
