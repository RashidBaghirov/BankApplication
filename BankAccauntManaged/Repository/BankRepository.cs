using BankAccauntManaged.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.Repository
{
    internal class BankRepository : IBankRepository
    {
        Bank _bank;
        public Bank Bank { get => _bank; }
        public BankRepository()
        {
            _bank=new Bank();
        }

        public bool BlockUSer(User user)
        {
          return user.IsBlocked = true;   
        }

        public string ChangePassword(User user, string newPassword)
        {
            user.Password=newPassword;
            return user.Password;
        }

        public void CheckBalance(User user)
        {
            C
            Console.WriteLine(user.Balance); 
        }

        public void TopUpBalance(User user)
        {
 
            Console.WriteLine(user.Balance); 
        }

        public void UserList()
        {
            foreach (User item in _bank.Users)
            {
                    Console.WriteLine(item.Name,item.Surname);
            }
        }

       public bool LogOut(User user)
        {
            return user.IsLogged = false;
        }
    }
}
