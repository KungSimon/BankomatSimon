using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimon
{
    public class Money
    {
        public decimal ThousandBills { get; set; }
        public decimal FiveHundredBills { get; set; }
        public decimal TwoHundredBills { get; set; }
        public decimal HundredBills { get; set; }
        public decimal FiftyBills { get; set; }
        public decimal TwentyBills { get; set; }
        public decimal TenCoins { get; set; }
        public decimal FiveCoins { get; set; }
        public decimal OneCoins { get; set;}

        public decimal ThousandBillsGiven { get; set; }
        public decimal FiveHundredBillsGiven { get; set; }
        public decimal TwoHundredBillsGiven { get; set; }
        public decimal HundredBillsGiven { get; set; }
        public decimal FiftyBillsGiven { get; set; }
        public decimal TwentyBillsGiven { get; set; }
        public decimal TenCoinsGiven { get; set; }
        public decimal FiveCoinsGiven { get; set; }
        public decimal OneCoinsGiven { get; set; }
        public decimal Total
        {
            get
            {
                //Beräkna det totala beloppet baserat på de olika valörer
                decimal totalAmount = 0;
                totalAmount += ThousandBills * 1000;
                totalAmount += FiveHundredBills * 500;
                totalAmount += TwoHundredBills * 200;
                totalAmount += HundredBills * 100;
                totalAmount += FiftyBills * 50;
                totalAmount += TwentyBills * 20;
                totalAmount += TenCoins * 10;
                totalAmount += FiveCoins * 5;
                totalAmount += OneCoins * 1;

                return totalAmount;
            }
        }

        public Money()
        {
            ThousandBills = 0;
            FiveHundredBills = 0;
            TwoHundredBills = 0;
            HundredBills = 0; 
            FiftyBills = 0;
            TenCoins = 0;
            FiveCoins = 0;
            OneCoins = 0;
        }
        public void AddMoney(Money moneyToAdd)
        {
            ThousandBills += moneyToAdd.ThousandBills;
            FiveHundredBills += moneyToAdd.FiveHundredBills;
            TwoHundredBills += moneyToAdd.TwoHundredBills;
            HundredBills += moneyToAdd.HundredBills;
            FiftyBills += moneyToAdd.FiftyBills;
            TwentyBills += moneyToAdd.TwentyBills;
            TenCoins += moneyToAdd.TenCoins;
            FiveCoins += moneyToAdd.FiveCoins;
            OneCoins += moneyToAdd.OneCoins;
        }
        public void ResetGivenBillsAndCoins()
        {
            ThousandBillsGiven = 0;
            FiveHundredBillsGiven = 0;
            TwoHundredBillsGiven = 0;
            HundredBillsGiven = 0;
            FiftyBillsGiven = 0;
            TwentyBillsGiven = 0;
            TenCoinsGiven = 0;
            FiveCoinsGiven = 0;
            OneCoinsGiven = 0;
        }
    }
}
