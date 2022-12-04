using BankAccauntManaged.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.ILogin
{
    internal interface IAccountRepostiry
    {
        public Bank Bank { get; }
        void Registration(User user);

        void Login(User user);

        void FindUser(User user);

    }
}
