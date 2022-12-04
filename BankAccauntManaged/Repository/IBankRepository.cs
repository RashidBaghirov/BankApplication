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
        void UserList();
        bool BlockUser(User user);
        string ChangePassword(User user, string newPassword);
        void CheckBalance(double balance);
        void ToUpBalance(User user, double amount);
        bool LogOut(User user);
    }
}
