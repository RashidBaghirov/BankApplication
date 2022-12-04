using BankAccauntManaged.Main;
using BankAccauntManaged.Services;

namespace BankAccauntManaged
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char selection;
            Console.WriteLine("Welcome our Bank");
          
            do
            {
                Console.WriteLine("1. User Registration");
                Console.WriteLine("2. User Login");
                //Console.WriteLine("3. Find User");
                Console.WriteLine("0. Exit");
            selection:
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (selection)
                {
                    case '1':
                        MenuServices.Registration();
                        Thread.Sleep(500);
                        Console.Clear();

                        break;
                    case '2':
                        MenuServices.Login();
                        Bank();
                        Thread.Sleep(500);
                        Console.Clear();

                        break;
                    case '3':
                        MenuServices.FindUser();
                        Thread.Sleep(500);
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection;
                }
            } while (selection != '0');

           






        }
            public static void Bank()
            {

                char selection1;
                Console.WriteLine("Welcome our Bank");
                do
                {
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Top Up Balance");
                    Console.WriteLine("3. Change Password");
                    Console.WriteLine("4. Bank User List");
                    Console.WriteLine("5. Block User");
                    Console.WriteLine("6. Log Out ");
                selection1:
                    selection1 = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    switch (selection1)
                    {
                        case '1':
                            MenuServices.CheckBalans();
                            Thread.Sleep(500);
                            Console.Clear();

                            break;
                        case '2':
                            MenuServices.TopUpBalance();
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        case '3':
                            MenuServices.ChangePassword();
                            Thread.Sleep(500);
                            Console.Clear();

                            break;
                        case '4':
                            MenuServices.UserList();
                            Thread.Sleep(500);
                            Console.Clear();
                            break;

                        case '5':
                            MenuServices.BlockUser();
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Please choose correct number");
                            Console.Clear();
                            goto selection1;
                    }
                } while (selection1 != '0');
            }
    }

    
}


