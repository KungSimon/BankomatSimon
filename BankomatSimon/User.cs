using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    internal class User
    {
        public string Name { get; set; }
        private string Password;
        public decimal Balance { get; set; }


        public User(string name, string password, decimal balance)
        {

            Name = name;
            Password = password;
            Balance = balance;
        }
        public bool CheckPassword(string inputPassword) 
        {
            if (inputPassword == Password)
            {
                return true;
            }
            return false;
            return inputPassword == Password;
        }
    }
}
