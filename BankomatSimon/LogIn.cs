using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    internal class LogIn
    {
        List<User> users = new List<User>();

        public LogIn() 
        {
            users.Add(new User("Nordea", "1337", 6200));
            users.Add(new User("Swedbank", "4200", 320));
        }
        public void Run() 
        {
            Console.WriteLine("Which card do you want to use? Nordea or Swedbank?:");
            string username = Console.ReadLine();
            Console.WriteLine("Type in your passcode:");
            string password = Console.ReadLine();

            User user = GetUserByUserName(username);
            if (user != null)
            {
                bool correctPassword = user.CheckPassword(password);
                if (correctPassword == true)
                {
                    Console.WriteLine("You are logged in!");
                    ShowMenu showMenu = new ShowMenu();
                    showMenu.Run();
                }
                else 
                {
                    Console.WriteLine("Wrong password!");
                }
            }
            else
            {
                Console.WriteLine("Option does not exist!");
            }
        }
        private User GetUserByUserName(string username) 
        {
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
