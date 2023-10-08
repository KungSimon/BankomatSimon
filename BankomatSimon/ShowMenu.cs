using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    internal class ShowMenu
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nMake an option:");
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Leave");
                string Choice = Console.ReadLine();

                if (Choice == "1")
                {
                    //  DepositMoney();
                }
                else if (Choice == "2")
                {
                    WithDrawal withdrawal = new WithDrawal();
                    withdrawal.Execute();
                }
                else if (Choice == "3")
                {
                    Console.WriteLine("Thanks for the visit!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }
    }
}
