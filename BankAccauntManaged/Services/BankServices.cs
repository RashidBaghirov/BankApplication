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

        public bool UserList(User user)
        {
            if (user.IsAdmin==true)
            {
            _bankRepository.UserList();
            }
            return false;
        }
        public bool BlockUser(User user)
        {
            if (user.IsAdmin == true)
            {
                foreach (User userr in _bankRepository.Bank.Users)
                {
                    _bankRepository.BlockUSer(user);
                    return true;
                }
            }
            return false ;
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
       
    }

}
