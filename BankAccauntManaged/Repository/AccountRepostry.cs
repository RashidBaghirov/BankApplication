using BankAccauntManaged.ILogin;
using BankAccauntManaged.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.Repository
{
    internal class AccountRepostry:IAccountRepostiry
    {
        private Bank _bank;

        public Bank Bank
        {
            get
            {
                return _bank;
            }
        }

        public AccountRepostry(Bank bank)
        {
            _bank = bank;
        }

        public void Registration(User user)
        {

            Array.Resize(ref _bank.Users, _bank.Users.Length + 1);

            _bank.Users[_bank.Users.Length - 1] = user;

            Console.WriteLine("registration was successful");

            Thread.Sleep(3000);


        }

        public void Login(User user)
        {
            user.IsLogged = true;
            Console.WriteLine($"user:{user.Name} {user.Surname} {user.Id} {user.IsAdmin}");
            Thread.Sleep(2000);
        }

        public void FindUser(User user)
        {
            Console.WriteLine($"User: {user.Name} {user.Surname}");
            Thread.Sleep(2000);
        }


    }
}

