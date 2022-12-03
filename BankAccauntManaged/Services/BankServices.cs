using BankAccauntManaged.Main;
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
        readonly IBankRepository _bankRepository;

        public BankServices()
        {
            _bankRepository=new BankRepository();   
        }

        public bool UserList(string email)
        {
            User exicted;
            foreach (User userrr in _bankRepository.Bank.Users)
            {
                if(userrr.Email == email)
                {
                    if (userrr.IsAdmin == true)
                    {
                        exicted = userrr;
                        _bankRepository.UserList();
                        return true;
                    }
                    return false;
                }   
            }
            return false;
        }
        public bool BlockUser(string email)
        {
            User exicted;
            foreach (User userrr in _bankRepository.Bank.Users)
            {
                if (userrr.Email == email)
                {
                    exicted=userrr;
                    _bankRepository.BlockUSer(exicted);
                    return true;
                }
            }
            return false;
        }

        public bool ChangePassword(string oldpass,string newpass)
        {
            User exicted = default;
            foreach (User pass in _bankRepository.Bank.Users)
            {
                if (pass.Password == oldpass)
                {
                    exicted = pass;
                    _bankRepository.ChangePassword(exicted, newpass);
                    return true;
                }
            }
            return false;
        }
        public void LogOut(User user)
        {
            _bankRepository.LogOut(user);
        }

        public bool CheckBalance(string password)
        {
            foreach (User userr in _bankRepository.Bank.Users)
            {
                if (userr.Password == password)
                {
                    _bankRepository.CheckBalance(userr);
                    return true;
                }
            }
            return false;
        }

        public bool TopUpBalance(string password, double newBalance)
        {
            foreach (User userr in _bankRepository.Bank.Users)
            {
                if (userr.Password == password)
                {
                    userr.Balance = newBalance;
                    _bankRepository.TopUpBalance(userr);
                    return true;
                }
            }
            return false;
        }
    }

}
