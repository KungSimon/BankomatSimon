using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    public class Choice
    {
        //En fumktion som välkomnar användaren och ger den två val.
        public void Run()
        {
            Console.WriteLine("Welcome to the Atm");
            while (true)
            {
                Console.WriteLine("Make an option:");
                Console.WriteLine("1. Insert card ");
                Console.WriteLine("2. Leave");
                string Choice = Console.ReadLine();

                if (Choice == "1")
                {
                    try
                    {
                        LogIn LogInProgram = new LogIn();
                        LogInProgram.Run();
                    }
                    catch
                    {
                        Console.WriteLine("An error occured.");
                    }

                }
                else if (Choice == "2")
                {
                    Console.WriteLine("Thank you for the visit!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }


        }

    }
}

