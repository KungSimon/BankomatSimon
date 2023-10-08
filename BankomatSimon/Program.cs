using System.Runtime.CompilerServices;

namespace BankomatSimon
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string bombom = "amanda";

            string CorrectCode = "1337";
            Console.WriteLine("Welcome to the Atm");
            while (true) 
            {
                Console.WriteLine("Make an option:");
                Console.WriteLine("1. Insert card ");
                Console.WriteLine("2. Leave");
                string Choice = Console.ReadLine();

                if(Choice == "1") 
                {
                    LogIn LogInProgram = new LogIn();
                    LogInProgram.Run();
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