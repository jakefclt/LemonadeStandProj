using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        public List<string> names;
        public string name;
        public double pricePref;
        Random random = new Random();
        public Customer()
        {
            names = new List<string>();
            SetPref();
            
        }   
        public void SetPref()
        {
            pricePref = random.NextDouble();
        }
      public void BuyLemonade(Player player, Weather weather, Recipe recipe, Wallet wallet)
        {
           
                if (weather.condition == "Sunny" && weather.temperature >= 90 && recipe.pricePerCup <= pricePref)
                {
                         player.wallet.Money += recipe.pricePerCup;
                        
                }                              
                else if (recipe.pricePerCup >= pricePref)
                {
                        player.wallet.Money += recipe.pricePerCup - .10;
                }
                else
                {
                        player.wallet.Money -= recipe.pricePerCup;
                }

                
               
      }       
    }


}      
    
    
            
    
