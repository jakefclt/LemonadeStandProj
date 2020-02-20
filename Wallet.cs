using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        private double money;
        Day day = new Day();
        
        // property - TBD
        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }

        public Wallet()
        {
            money = 20.00;
        }

        public void DisplayBalance()
        {
            
            Console.WriteLine("You have $" + Money + " in your wallet.");
            
        }
        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
            
        }
       
    }
}
