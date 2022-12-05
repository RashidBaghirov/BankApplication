using BankAccauntManaged.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.Repository
{
    internal interface IBankRepository
    {
        public Bank Bank { get; }  
        
        
        void UserList(User user);
        bool BlockUser(User user);
        string ChangePassword(User user, string newPassword);
        void CheckBalance(User user);
        void ToUpBalance(User user,double balance);
        bool LogOut(User user);
    }
}
