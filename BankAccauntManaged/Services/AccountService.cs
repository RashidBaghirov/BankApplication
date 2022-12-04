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
        public AccountService()
        {
            _repository = new AccountRepostry();
        }


        public bool? Registration(string name, string surname, string password, string email, bool isadmin)
        {

            foreach (User user in _repository.Bank.Users)
            {
                if (user.Email == email)
                {
                    Console.WriteLine("Bu Adda Email Movcutdur");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuServices.Registration();
                    return false;
                }
            }
            User newUser = new User(name, surname, password, email, isadmin);
            _repository.Registration(newUser);
            return true;

        }

        public bool FindUser(string email)
        {
            User exicted = default;
            foreach (User mail in _repository.Bank.Users)
            {
                if (mail.Email == email)
                {
                    exicted = mail;
                    _repository.FindUser(exicted);
                    return false;
                }
            }

            Console.WriteLine("Istifadeci tapilmadi");
            return true;
        }


        public bool Login(string email, string password)
        {
            foreach (User userList in _repository.Bank.Users)
            {
                if (userList.Email.Equals(email) && userList.Password.Equals(password))
                {
                    _repository.Login(userList);
                    return false;
                }
            }
            Console.WriteLine("User Tapilmadi");
            Thread.Sleep(2000);
            Console.Clear();
            MenuServices.Login();
            return true;
        }
    }
    
}
