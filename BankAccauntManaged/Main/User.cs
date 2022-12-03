using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged.Main
{
    internal class User
    {
        public int _id;
        static int _count;
        string _name;
        public string Name {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length > 2)
                {
                    _name = value;
                }
            }
                
        }
        string _surname;
        public string Surname {
            get
            {
                return _surname;
            }
                
            set
            {
                if (value.Length > 2)
                {
                    _surname = value;   
                }
            }
        }
        public double Balance;
        string _email;
        public string Email 
        {
            get
            {
                return _email;
            }

            set
            {
                if (value.Contains('@') == true)
                {
                    value = _email;
                }
            }
                
        }

        string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }

                
        }
        public bool IsAdmin;
        public bool IsBlocked;
        public bool IsLogged;
        public User(string name,string surname,string mail,string password,bool isadmin)
        {
            Name = name;
            Surname = surname;
            Email = mail;
            Password = password;
            IsAdmin = isadmin;
            IsBlocked = false;
            IsLogged = false;
            _id=++_count;
        }
       
        static User()
        {
            _count = 100;
        }

        static bool CheckPassword(string pw)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool result = false;

            foreach (char item in pw)
            {


                if (char.IsDigit(item))
                {
                    hasDigit = true;
                }
                else if (char.IsLower(item))
                {
                    hasLower = true;
                }
                else if (char.IsUpper(item))
                {
                    hasUpper = true;
                }
                result = hasDigit && hasLower && hasUpper;
                if (result)
                {
                    break;
                }

            }
            return result;
        }

    }
}
