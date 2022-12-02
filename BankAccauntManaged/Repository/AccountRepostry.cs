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
        Bank _bank;

        public Bank Bank { get => _bank; }

        public AccountRepostry()
        {
            _bank = new Bank();
        }

       

        public bool Login(string email,string password)
        {
            foreach (User userr in _bank.Users)
            {
                if(userr.Email==email && userr.Password == password)
                {
                    userr.IsLogged = true;
                    return true;
                        
                }
                
            }
            return false;
        }

       

        public void Registration(string name, string surname, string email, string password, bool isadmin)
        {
            User user = new User(name,surname,email,password);
            Array.Resize(ref _bank.Users, _bank.Users.Length + 1);
            _bank.Users[_bank.Users.Length - 1] =user;
        }

        

        public void FindUser(User user)
        {
            if (user is not null)
            {
                foreach (User userr in _bank.Users)
                {
                    Console.WriteLine(userr);
                }
            }
            else
            {
                Console.WriteLine("There is no user");
            }
        }

      
      
    }
}
