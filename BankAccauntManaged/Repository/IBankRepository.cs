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

        double CheckBalance(User user);
        double TopUpBalance(User user,double num);
        string ChangePassword(User user,string newPassword);

        void UserList();
        bool BlockUSer(User user);
    }
}
