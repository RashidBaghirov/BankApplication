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
        public Bank Bank
        {
            get
            {
                return _bank;
            }
        }

        public BankRepository(Bank bank)
        {
            _bank = Bank;
        }
        public void UserList()
        {
            foreach (User user in _bank.Users)
            {
                Console.WriteLine(user.Name, user.Surname);
            }
        }

        public bool BlockUser(User user)
        {
            user.IsBlocked = true;
            return true;

        }

        public string ChangePassword(User user, string newPassword)
        {
            user.Password = newPassword;
            Console.WriteLine("password changed successfully");
            return user.Password;
        }

        public void CheckBalance(double balance)
        {

            Console.WriteLine(balance);
            Thread.Sleep(2000);
        }

        public void ToUpBalance(User user, double newbalance)
        {
            
            Console.WriteLine($" new balance {user.Balance+newbalance}");
        }

        public bool LogOut(User user)
        {
            return user.IsLogged = false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
