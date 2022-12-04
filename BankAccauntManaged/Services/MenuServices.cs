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

        readonly static AccountService _accountservice;

        static Bank myBank;

        static MenuServices()
        {

            myBank = new Bank();

            _bankservices = new BankServices(myBank);

            _accountservice = new AccountService(myBank);

        }
        #region User methods
        public static void Registration()
        {

            string name;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("please enter name:");
                name = Console.ReadLine();
            } while (!NameChecker(name));

            string surname;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("please enter surname:");
                surname = Console.ReadLine();
            } while (!SurnameChecker(surname));


            string email;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("please enter email:");
                email = Console.ReadLine();

            } while (!EmailChecker(email));

            string password;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("please enter password:");
                password = Console.ReadLine();

            } while (!CheckPassword(password));

            bool isadmin;
            char yesOrNo;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Is super admin? y/n");
                isadmin = char.TryParse(Console.ReadLine(), out yesOrNo);
            } while (!isadmin);


            if (yesOrNo.ToString().ToLower() == 'y'.ToString())
            {
                _accountservice.Registration(name, surname, password, email, true);
            }
            else
            {
                _accountservice.Registration(name, surname, password, email, false);
            }





        }
        public static bool Login()
        {

            string email;
            string password;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("enter your email:");
                email = Console.ReadLine();
                Console.WriteLine("enter your password:");
                password = Console.ReadLine();
            } while (!_accountservice.Login(email, password));

            return true;
        }

        public static bool FindUser()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string email;
            Console.WriteLine("Enter the email address of the person you are looking for");
            email = Console.ReadLine();
            if (_accountservice.FindUser(email))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Bank methods
        public static void ChangePassword()
        {
            string password;
            string newpassword;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter your old password");
                password = Console.ReadLine();
                Console.WriteLine("Enter new password");
                newpassword = Console.ReadLine();
                CheckPassword(newpassword);

            } while (!_bankservices.ChangePassword(password, newpassword));

        }
        public static bool CheckBalans()
        {
            string password;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter password to view balance");
            password = Console.ReadLine();
            if (_bankservices.CheckBalance(password))
            {
                return true;
            }
            return false;
        }

        public static void TopUpBalance()
        {
            string password;
            double newBalance;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter email to top up balance");
                password = Console.ReadLine();
                Console.WriteLine("How much you want to increase");
                newBalance = Convert.ToDouble(Console.ReadLine());
            }
            while (!_bankservices.TopUpBalance(password, newBalance));
            Console.WriteLine(".....");
            Thread.Sleep(2000);

        }
        public static void UserList()
        {
            string email;
                   Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter admin's email");
                email = Console.ReadLine();


            if (_bankservices.UserList(email))
            {
                Console.WriteLine("USers");
                Thread.Sleep(3500);
            }

        }
        public static void BlockUser()
        {
            UserList();
            string email;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the slant you want to block");
                email = Console.ReadLine();
            } while (!_bankservices.BlockUser(email));
        }
        static bool NameChecker(string name)
        {
            if (name.Length > 2)
            {
                return true;
            }
            return false;
        }
        public static void Logout()
        {
            MenuServices.ProgramService();
        }
        #endregion

        #region Methods
        static bool SurnameChecker(string surname)
        {
            if (surname.Length > 2)
            {
                return true;
            }

            return false;
        }
        static bool CheckPassword(string pass)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool result = false;

            foreach (char item in pass)
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The @ sign should have been included");
                return false;
            }
        }

        public static void ProgramService()
        {

            char UserServiceSelect;
            Console.ForegroundColor = ConsoleColor.Red;
            do
            {
                Console.WriteLine("1. Registration");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Find User");
                Console.WriteLine("0. Exit");
            selection:
                UserServiceSelect = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine();
                switch (UserServiceSelect)
                {
                    case '1':
                        MenuServices.Registration();
                        Console.Clear();
                        break;
                    case '2':
                        MenuServices.Login();
                        Console.Clear();
                        break;
                    case '3':
                        MenuServices.FindUser();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection;
                }
            } while (UserServiceSelect != '0');
        }



        public static void AllServicess()
        {

            char BankServiceSelect;
            Console.ForegroundColor = ConsoleColor.Red;

            do
            {
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Top up balance");
                Console.WriteLine("3. Change password");
                Console.WriteLine("4. Bank user list");
                Console.WriteLine("5. Block user");
                Console.WriteLine("6. Logout");
            selection1:
                BankServiceSelect = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine();
                switch (BankServiceSelect)
                {
                    case '1':
                        MenuServices.CheckBalans();
                        Console.Clear();
                        break;
                    case '2':
                        MenuServices.TopUpBalance();
                        Console.Clear();
                        break;
                    case '3':
                        MenuServices.ChangePassword();
                        Console.Clear();
                        break;
                    case '4':
                        MenuServices.UserList();
                        Console.Clear();
                        break;
                    case '5':
                        MenuServices.BlockUser();
                        Console.Clear();
                        break;
                    case '6':
                        MenuServices.Logout();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection1;
                }
            } while (BankServiceSelect != '0');

            #endregion
        }
    }

}
