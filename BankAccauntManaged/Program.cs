using BankAccauntManaged.Main;
using BankAccauntManaged.Services;

namespace BankAccauntManaged
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char selection;
            char selection1;
            Console.WriteLine("Welcome our Bank");
            do
            {
                Console.WriteLine("1.REGISTRATION");
                Console.WriteLine("2.LOGIN");
                
            selection:
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (selection)
                {
                    case '1':
                        MenuServices.Registration();
                        Console.Clear();
                        break;
                    case '2':
                        MenuServices.Login();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection;
                }
            } while (selection != '0');

            Console.WriteLine("1.FINDUSER");
            Console.WriteLine("2.CHECKBALANCE");
            Console.WriteLine("3.TOPUPBALANCE");
            Console.WriteLine("4.CHANGEPASSWORD");
            Console.WriteLine("5.USERLIST");
            Console.WriteLine("6.BLOCKUSER");
            char select;
                selection1:
            select = Console.ReadKey().KeyChar;
            switch (selection)
            {
                case '1':
                    MenuServices.FindUser();
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case '2':
                    MenuServices.CheckBalance();
                    Console.Clear();
                    break;
                case '3':
                    MenuServices.TopUpBalance();
                    Console.Clear();
                    break;
                case '4':
                    MenuServices.ChangePassword();
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case '5':
                    MenuServices.UserList();
                    Console.Clear();
                    break;
                case '6':
                    MenuServices.BlockUser();
                    Console.Clear();
                    break;
                case '0':
                    break;
                default:
                    Console.WriteLine("Please choose correct number");
                    Console.Clear();
                    goto selection1;
            } while (select != 0) ;
           
        } 

    }
}


