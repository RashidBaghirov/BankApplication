﻿using BankAccauntManaged.Main;
using BankAccauntManaged.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.Services
{
    internal class BankServices
    {
        readonly IBankRepository _bankrepository;
        Bank Bank;
        public BankServices(Bank bank)
        {
            Bank = bank;
            _bankrepository = new BankRepository(Bank);
        }

        public bool UserList(string email)
        {
            foreach (User userrr in Bank.Users)
            {
                if (userrr.Email == email)
                {
                    if (userrr.IsAdmin == true)
                    {
                        _bankrepository.UserList(userrr);
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ChangePassword(string currentpassword, string newPassword)
        {
            User existed = null;

            foreach (User pass in Bank.Users)
            {
                if (pass.Password == currentpassword)
                {
                    existed = pass;
                    _bankrepository.ChangePassword(existed, newPassword);
                    return true;
                }             
            }
            Console.WriteLine("Password error");
            return false;
        }
        public bool BlockUser(string email)
        {
            User exicted;
            foreach (User userrr in Bank.Users)
            {
                if (userrr.Email == email)
                {
                    exicted = userrr;
                    _bankrepository.BlockUser(exicted);
                    return true;
                }
            }
            return false;
        }
        public bool CheckBalance(string password)
        {
            foreach (User user in Bank.Users)
            {
                if (user.Password == password)
                {
                    double balance = 0.0;
                    _bankrepository.CheckBalance(balance);
                    return true;
                }
            }
            return false;
        }

        public bool TopUpBalance(string password, double newbalance)
        {
            foreach (User userrr in _bankrepository.Bank.Users)
            {
                if (userrr.Password == password)
                {
                    userrr.Balance += newbalance;
                    _bankrepository.ToUpBalance(userrr);
                    return true;
                }
            }
            return true;
        }


        public void LogOut(User user)
        {
            _bankrepository.LogOut(user);
        }

    }
}
