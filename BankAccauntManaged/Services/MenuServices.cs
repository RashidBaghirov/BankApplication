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
        readonly static BankServices _bankservice;

        readonly static AccountService _userservice;

        static MenuServices()
        {
            _bankservice = new BankServices();

            _userservice = new AccountService();
        }
        public static void Registration()
        {

            string name;
            do
            {
                Console.WriteLine("please enter name:");
                name = Console.ReadLine();
            } while (!NameChecker(name));

            string surname;
            do
            {
                Console.WriteLine("please enter surname:");
                surname = Console.ReadLine();
            } while (!SurnameChecker(surname));

            string password;
            do
            {
                Console.WriteLine("please enter password:");
                password = Console.ReadLine();

            } while (!CheckPassword(password));

            string email;
            do
            {
                Console.WriteLine("please enter email:");
                email = Console.ReadLine();

            } while (!EmailChecker(email));

            string admin = null;
            Console.WriteLine("are you super admin? y/n");
            admin = Console.ReadLine();
            bool isadmin = false;

            if (admin == "y")
            {
                isadmin = true;
            }
            else if (admin == "n")
            {
                isadmin = false;
            }

            _userservice.Registration(name, surname, password, email, isadmin);


        }
        public static void Login()
        {

            string email;
            string password;
            start:
            do
            {
                Console.WriteLine("enter your email:");
                email = Console.ReadLine();
                Console.WriteLine("enter your password:");
                password = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(email))
                {
                    goto start;
                }
            } while (_userservice.Login(email, password));

        }

        public static void FindUser()
        {


            string email;
            do
            {
                email = Console.ReadLine();

            } while (_userservice.FindUser(email) == false);
        }

        public static void ChangePassword()
        {
            string password;
            string newpassword;
            do
            {
                password = Console.ReadLine();
                newpassword = Console.ReadLine();
                CheckPassword(newpassword);

            } while (!_bankservice.ChangePassword(password, newpassword));

        }
        public static void CheckBalans()
        {
            string password;
            do
            {
                password = Console.ReadLine();
            } while (!_bankservice.CheckBalance(password));
        }

        public static void TopUpBalance()
        {
            string password;
            double newBalance;
            do
            {
                password = Console.ReadLine();
                newBalance = Convert.ToDouble(Console.ReadLine());

            } while (_bankservice.TopUpBalance(password, newBalance));
        }
        public static void UserList()
        {
            string email;
            do
            {
                Console.WriteLine("Admin mailin daxil edin");
                email = Console.ReadLine();


            } while (!_bankservice.UserList(email));

        }
        public static void BlockUser()
        {
            UserList();
            string email;
            do
            {
                Console.WriteLine("Blok etmek istediyiniz userin mailini daxil edin");
                email = Console.ReadLine();
            } while (!_bankservice.BlockUser(email));
        }








        static bool NameChecker(string namesa)
        {
            if (namesa.Length > 2)
            {
                return true;
            }
            return false;
        }
        static bool SurnameChecker(string surname)
        {
            if (surname.Length > 2)
            {
                return true;
            }

            return false;
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
        static bool EmailChecker(string symbol)
        {
            if (symbol.Contains('@'))
            {
                return true;

            }
            else
            {
                Console.WriteLine("please write @");
                return false;
            }
        }
    }
}
