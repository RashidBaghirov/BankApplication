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
        public void UserList(User user)
        {
            foreach (User userr in Bank.Users)
            {
                Console.WriteLine(user.Name, user.Surname);
                Thread.Sleep(3000);
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

        public void CheckBalance(User user)
        {

            Console.WriteLine(user.Balance);
        }

        public void ToUpBalance(User user, double balance)
        {
            user.Balance += balance;
            Console.WriteLine("Successfully Added. New Balance: " + user.Balance);

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
