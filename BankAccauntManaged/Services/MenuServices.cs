using BankAccauntManaged.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankAccauntManaged.Services
{
    internal static class MenuServices
    {
        readonly static BankServices _bankservices;
        readonly static UserService _userservices;

        static MenuServices()
        {
            _bankservices = new BankServices();
            _userservices = new UserService();
        }

        #region REGISTRATION
        public static void Registration()
        {
            string name;
            string surname;
            do
            {
                Console.WriteLine("please enter name:");
                name = Console.ReadLine();
                Console.WriteLine("please enter surname:");
                surname = Console.ReadLine();
                Console.WriteLine("please enter email:");
            } while (!NameandSurnameChecker(name, surname));
            string email;
            do
            {
                email = Console.ReadLine();
            } while (!Checkemail(email));

            string password;
            do
            {
                Console.WriteLine("please enter password:");
                password = Console.ReadLine();
            } while (!CheckPassword(password));

            
            string Admin;
            bool isadmin=false;
                Admin = Console.ReadLine();
            if (Admin == "yes")
            {
                isadmin = true;
            }
            else if (Admin == "no")
            {
                isadmin = false;
            }

            
            _userservices.Registration(name,surname,email,password,isadmin);

        }



        static bool CheckPassword(string pw)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool result = false;
            if (pw.Length > 7)
            {
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
            }
            else
            {
                Console.WriteLine("Password error");
            }
            return result;
        }


        static bool Checkemail(string mail)
        {
            if (mail.Contains('@') == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine("do you use @ charachter");
            }
            return false;
        }
        static bool NameandSurnameChecker(string name,string surname)
        {
            if(name.Length>2 && surname.Length > 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Name and Surname length");
            }
            return false;
        }


#endregion

        #region LOGIN
public static void Login()
        {
            string email;
            string password;
            do
            {
                Console.WriteLine("enter your email :");
                email = Console.ReadLine();
                Console.WriteLine("enter password :");
                password = Console.ReadLine();
            } while (!_userservices.Login(email, password));
        }
        #endregion

        #region FINDUSER

        public static void FindUser()
        {
            string email;
            do
            {
                email= Console.ReadLine();  

            } while (!_userservices.FindUser(email));
        }
        #endregion

        #region CHANGEPASSWORD
        public static void ChangePassword()
        {
            string pass;
            string newpass;
            do
            {
                pass= Console.ReadLine();
                newpass= Console.ReadLine();
                CheckPassword(newpass);
            } while (!_bankservices.ChangePassword(pass,newpass));
        }
        #endregion

        #region CheckBalance
        public static void CheckBalance()
        {
            string password;
            do
            {
                password=Console.ReadLine();
            } while (!_bankservices.CheckBalance(password));
        }

        #endregion


        #region TopUpBalance
        public static void TopUpBalance()
        {
            string password;
            double newbalance;
            do
            {
                password = Console.ReadLine();
                newbalance = Convert.ToDouble(Console.ReadLine());
            } while (_bankservices.TopUpBalance(password,newbalance));
        }

        #endregion

        #region userlist
        public static void UserList()
        {
            string email;
            do
            {
                Console.WriteLine("Admin mailin daxil edin");
                email = Console.ReadLine();
                

            } while (!_bankservices.UserList(email));

        }

        #endregion

        #region BLOCKUSer
        public static void BlockUser()
        {
            UserList();
            string email;
            do
            {
                Console.WriteLine("Blok etmek istediyiniz userin mailini daxil edin");
                email = Console.ReadLine();
            } while (!_bankservices.BlockUser(email));
        }



        #endregion

    }
}
