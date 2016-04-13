using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passwords must be AT LEAST 10 characters");
            Console.WriteLine("Must contain 3 of the following:Uppercase letter, Lowercase letter, Number, A Special character(@, #, $, %, !, etc)");
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            int uppercaseCount = 0;
            int lowercaseCount = 0;
            int numCount = 0;
            int specialCharacterCount = 0;
            if (password.Length < 10)
            {
                Console.WriteLine("Your password must be at least 10 characters.");
            }
            else
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]) == true)
                    {
                        uppercaseCount = 1;
                    }
                    if (Char.IsLower(password[i]) == true)
                    {
                        lowercaseCount = 1;
                    }
                    if (Char.IsDigit(password[i]) == true)
                    {
                        numCount = 1;
                    }
                    if (Char.IsPunctuation(password[i]) == true)
                    {
                        specialCharacterCount = 1;
                    }
                }

                if (uppercaseCount == 1 && lowercaseCount == 1 && numCount == 1)
                {
                    Console.WriteLine("Valid password!");
                }
                else if (uppercaseCount == 1 && lowercaseCount == 1 && specialCharacterCount == 1)
                {
                    Console.WriteLine("Valid password!");
                }
                else if (uppercaseCount == 1 && numCount == 1 && specialCharacterCount == 1)
                {
                    Console.WriteLine("Valid password!");
                }
                else if (lowercaseCount == 1 && numCount == 1 && specialCharacterCount == 1)
                {
                    Console.WriteLine("Valid password!");
                }
                else if (uppercaseCount != 1)
                {
                    Console.WriteLine("Your password need to have a uppercase letter.");
                }
                else if (lowercaseCount != 1)
                {
                    Console.WriteLine("Your password need to have a lowercase letter.");
                }
                else if (numCount != 1)
                {
                    Console.WriteLine("Your password must have a number.");
                }
                else if (specialCharacterCount != 1)
                {
                    Console.WriteLine("Your password must have a punctuation.");
                }
            }
                Console.ReadKey();
        }       
    }
}
