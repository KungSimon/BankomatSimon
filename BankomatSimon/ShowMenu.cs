using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    public class ShowMenu 
    {
        private Money money = new Money();
        public decimal Amount;

        public decimal Balance { get; private set; }

        public ShowMenu(decimal balance)
        {
            Balance = balance;
        }
        
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
                    DepositMoney();
                }
                else if (Choice == "2")
                {
                    Console.WriteLine("Your current balance is: " + Balance + " SEK");
                    Console.WriteLine("Enter the withdrawal amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                    {
                        WithDrawal withdrawal = new WithDrawal(Balance);
                        withdrawal.Execute(withdrawalAmount);
                        Balance = withdrawal.Balance;
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawal amount. Please try again.");
                    }
                    
                }
                else if (Choice == "3")
                {
                    Console.WriteLine("Please take your card. Thanks for the visit!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }

        private void DepositMoney()
        {
            Money depositedMoney = new Money();
            Console.WriteLine("Enter the number of bills/coins for each denomination");
            //Läser in och lagrar hur många sedlar och mynt användaren vill sätta in.
            depositedMoney.ThousandBills += GetAmount("Thousand bills");
            depositedMoney.FiveHundredBills += GetAmount("Five hundred bills");
            depositedMoney.TwoHundredBills += GetAmount("Two hundred bills");
            depositedMoney.HundredBills += GetAmount("Hundred bills");
            depositedMoney.FiftyBills += GetAmount("Fifty bills");
            depositedMoney.TwentyBills += GetAmount("Twenty bills");
            depositedMoney.TenCoins += GetAmount("Ten coins");
            depositedMoney.FiveCoins += GetAmount("Five coins");
            depositedMoney.OneCoins += GetAmount("One coins");

            //Ökar saldot med insatt belopp
            Balance += depositedMoney.Total;

            Console.WriteLine("Deposit successful. Current balance: " + Balance + " SEK");
        }

        private decimal GetAmount(string denomination)
        {
            Console.WriteLine("Number of " + denomination + ": ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                return amount;
            }
            return 0;
        }

    }
}
