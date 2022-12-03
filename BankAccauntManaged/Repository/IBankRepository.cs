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
     public  Bank Bank { get; }

        void CheckBalance(User user);
        void TopUpBalance(User user);
        string ChangePassword(User user,string newPassword);

        void UserList();
        bool BlockUSer(User user);

        bool LogOut(User user);
    }
}
