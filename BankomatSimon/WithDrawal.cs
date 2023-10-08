using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    internal class WithDrawal : User 
    {
        public decimal Amount;
        

        public Withdrawal(decimal amount, decimal balance) 
        {
            Amount = amount; 
            Balance = balance; 
            
        }
        public void Execute() 
        {
            Console.WriteLine("How much would you like to Withdrawal?");
            string amount = Convert.ToString(Console.ReadLine);
            if (Amount <= 0) 
            {
                Console.WriteLine("Invalid withdrawl amount, please try again.");
                return;
            }
            if (Balance >= Amount) 
            {
                Balance -= Amount;
                Console.WriteLine("Withdrawal of " + Amount + " successful.");
                
            }
            else
            {
                Console.WriteLine("Not enough funds for withdrawl.");
                return ;
            }
        }
        
        

        
         
        
            
       
            
    }
    
    
}
