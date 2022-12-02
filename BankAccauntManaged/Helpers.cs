using BankAccauntManaged.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccauntManaged
{
    static class Helpers
    {

        //    static bool CheckPassword(string pw)
        //    {
        //        bool hasDigit = false;
        //        bool hasLower = false;
        //        bool hasUpper = false;
        //        bool result = false;

        //        foreach (char item in pw)
        //        {


        //            if (char.IsDigit(item))
        //            {
        //                hasDigit = true;
        //            }
        //            else if (char.IsLower(item))
        //            {
        //                hasLower = true;
        //            }
        //            else if (char.IsUpper(item))
        //            {
        //                hasUpper = true;
        //            }
        //            result = hasDigit && hasLower && hasUpper;
        //            if (result)
        //            {
        //                break;
        //            }

        //        }
        //        return result;
        //    }



        //    public bool FindUser(string email)
        //    {
        //        if (!string.IsNullOrWhiteSpace(email))
        //        {
        //            if (email.Length > 1)
        //            {
        //                if (Char.IsUpper(email[0]))
        //                {
        //                    foreach (var user in email)
        //                    {
        //                        if (Char.IsLetter(user) == false)
        //                        {
        //                            return false;

        //                        }
        //                    }
        //                    return true;
        //                }

        //            }
        //        }
        //        return false;
        //    }


        //    private static string readPassword()
        //    {
        //        string password = "";
        //        ConsoleKeyInfo kb = Console.ReadKey(true);
        //        while (kb.Key != ConsoleKey.Enter)
        //        {
        //            if (kb.Key != ConsoleKey.Backspace)
        //            {
        //                Console.Write("*");
        //                password += kb.KeyChar;
        //            }
        //            else if (kb.Key == ConsoleKey.Backspace && password.Length > 0)
        //            {
        //                // delete last letter from string
        //                password = password.Substring(0, password.Length - 1);
        //                int pos = Console.CursorLeft;
        //                // move the cursor to the left
        //                Console.SetCursorPosition(pos - 1, Console.CursorTop);
        //                // delete last letter from screen
        //                Console.Write(" ");
        //                // move the cursor to the left
        //                Console.SetCursorPosition(pos - 1, Console.CursorTop);
        //            }
        //            kb = Console.ReadKey(true);
        //        }
        //        Console.WriteLine();
        //        return password;
        //    }
        //}


        public void GetUser()
        {
        

            string userNameIn;
            string userPassIn;
            bool valid = false;

            //get VALID user login info
            do
            {
                userNameIn = null;
                userPassIn = null;

                Console.WriteLine(" Please enter your credentials: ");

                draw.OtherLine();

                //get user input
                Console.Write(" Username: ");
                userNameIn = Console.ReadLine();

                Console.Write(" Password: ");
                ConsoleKeyInfo info = Console.ReadKey(true);

                //hide password input with *
                while (info.Key != ConsoleKey.Enter)
                {
                    if (info.Key != ConsoleKey.Backspace)
                    {
                        Console.Write("*");
                        userPassIn += info.KeyChar;
                    }
                    else if (info.Key == ConsoleKey.Backspace)
                    {
                        if (!string.IsNullOrEmpty(userPassIn))
                        {
                            userPassIn = userPassIn.Substring(0, userPassIn.Length - 1);
                            int pos = Console.CursorLeft;
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        }
                    }
                    info = Console.ReadKey(true);
                }
                Console.WriteLine();
                //check if password and username input match
                valid = CheckValidity(userNameIn, userPassIn);
            } while (!valid);
        }


        void Userlist()
        {
            User user=new User(name,surname,mail,password,true)
            if (isadmin == true)
            {
                foreach (User user in .bank.Users)
                {
                    Console.WriteLine(user);
                }
            }
        }

    }
