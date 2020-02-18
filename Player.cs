using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public string name;
        public Recipe recipe;
        public Pitcher pitcher;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            
            
        }

        // member methods (CAN DO)
        public int BuyLemons()
        {
            Console.WriteLine("How many lemons do you want to buy?");
            int buyLemons = int.Parse(Console.ReadLine());
            return buyLemons;
        }
        public int BuySugar()
        {
            Console.WriteLine("How much sugar do you want to buy?");
            int buySugar = int.Parse(Console.ReadLine());
            return buySugar;
            
        }
        public int BuyIce()
        {
            Console.WriteLine("How much ice do you want to buy?");
            int buyIce = int.Parse(Console.ReadLine());
            return buyIce;
        }  
        public double BuyCups()
        {
            Console.WriteLine("How many cups do you want to buy?");
            double buyCups = double.Parse(Console.ReadLine());
            return buyCups;
        }
        
 

      
    }
         
}
