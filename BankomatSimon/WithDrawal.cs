using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    internal class WithDrawal : LogIn
    {
        public decimal Balance;
        private Money money = new Money();
        
        public WithDrawal(decimal balance) 
        {
            Balance = balance;
            
        }
        public void Execute(decimal withdrawalAmount)
        {
  
                if(withdrawalAmount <= 0) 
                {
                    Console.WriteLine("Invalid withdrawal amount, please try again");
                    return;
                }
                if (Balance >= withdrawalAmount)
                {
                //Tar ut pengarna om saldot är tillräkligt stort.
                    Balance -= withdrawalAmount;
                    Console.WriteLine("Withdrawal of " + withdrawalAmount + " successful.");
                    CalculateBillsAndCoins(withdrawalAmount);
                }
                else
                {
                    Console.WriteLine("Not enough funds for withdrawal.");
                    return;
                }

        }

        private decimal CalculateBillsAndCoinsCount(int denomination, decimal amount)
        {
            //Räknar ut antalet sedlar och mynt som behövs för att representera beloppet som angavs. 
            return (int) (amount / denomination);
        }

        private void CalculateBillsAndCoins(decimal amount)
        {
            int[] denominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
            string[] names = { "Thousand bills", "Five hundred bills", "Two hundred bills", "One hundred bills", "Fifty bills", "Twenty bills", "Ten coins", "Five coins", "One coins" };

            Console.WriteLine("Bills and coins received:");

            //Loopar igenom de olika valörer och beräkna antalet sedlar/mynt som behövs.
            for (int i = 0; i < denominations.Length; i++)
            {
                int count = (int)(amount / denominations[i]);
                amount -= count * denominations[i];
                Console.WriteLine(names[i] + ": " + count);
            }
            
        }
    }
    
}
