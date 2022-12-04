using BankAccauntManaged.ILogin;
using BankAccauntManaged.Main;
using BankAccauntManaged.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.Services
{
    internal class AccountService
    {
        readonly IAccountRepostiry _repository;
        Bank Bank;
        public AccountService(Bank bank)
        {
            Bank = bank;
           _repository = new AccountRepostry(Bank);
        }


        public bool? Registration(string name, string surname, string password, string email, bool isadmin)
        {

            foreach (User user in Bank.Users)
            {
                if (user.Email == email)
                {
                    Console.WriteLine("This email has been used");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuServices.Registration();
                    return false;
                }
            }
            User newUser = new User(name, surname, password, email, isadmin);
            _repository.Registration(newUser);
            Console.Clear();
            return true;

        }

        public bool FindUser(string email)
        {
            User exicted = default;
            foreach (User mail in Bank.Users)
            {
                if (mail.Email == email)
                {
                    exicted = mail;
                    _repository.FindUser(exicted);
                    return false;
                }
            }

            Console.WriteLine("User not found");
            return false;
        }


        public bool Login(string email, string password)
        {
            foreach (User user in Bank.Users)
            {
                if (user.Email.Equals(email) && user.Password.Equals(password))
                {
                    _repository.Login(user);
                    MenuServices.AllServicess();
                    return true;
                }
            }
            Console.WriteLine("User not found");
            Thread.Sleep(2000);
            Console.Clear();
            MenuServices.Login();
            return false;
        }

    }
}
