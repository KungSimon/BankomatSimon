using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    internal class LogIn
    {
        
        //En lista som innehåller olika kontonamn, pinkoder och saldon

        List<User> users = new List<User>(); 

        public LogIn() 
        {
            //Lägger till användarkonton i listan.
            users.Add(new User("Checking account", "1337", 1000));
            users.Add(new User("Savings account", "4200", 320));
            users.Add(new User("Credit account", "1999", 1000000));
        }
        public void Run() 
        {
            //Användaren väljer vilket konto och skriver sin pinkod
            Console.WriteLine("Which account would you like to use? Checking account, Savings account or Credit account?: ");
            string username = Console.ReadLine();
            Console.WriteLine("Type in your passcode:");
            string password = Console.ReadLine();

            User user = GetUserByUserName(username);
            if (user != null)
            {
                //kollar så att det är rätt pinkod
                bool correctPassword = user.CheckPassword(password);
                if (correctPassword == true)
                {
                    Console.WriteLine("You are logged in!");
                    ShowMenu showMenu = new ShowMenu(user.Balance);
                    showMenu.Run();
                }
                else 
                {
                    Console.WriteLine("Wrong password!");
                }
            }
            else
            {
                Console.WriteLine("Account does not exist!");
            }
        }
        private User GetUserByUserName(string username) 
        {
            //söker igenom kontolistan om det kontonamnet är rätt
            foreach (User user in users)
            {
                if (user.Name == username) 
                { 
                    return user; 
                }

                    
            }
            return null;
        }
    }
    
}
