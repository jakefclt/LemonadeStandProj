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
            /* The OPEN/CLOSED PRINCIPLE extends the functionality of the code above
             to allow for rising requirements such as adding daily profits to the 
             players wallet without having to modify the existing source code. */
        }
        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
            
        }
       
    }
}
