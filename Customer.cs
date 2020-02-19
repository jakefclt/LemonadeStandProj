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
            
            SetPref();
            
        }   
        public void SetPref()
        {
            pricePref = random.NextDouble();
        }
      public bool BuyLemonade(Player player, Weather weather)
        {
           
                if (weather.condition == "Sunny" || weather.condition == "Cloudy" && weather.temperature >= 90 && player.recipe.pricePerCup <= pricePref)
            {
                player.wallet.Money += player.recipe.pricePerCup;
                return true;
            }                              
                else if (weather.condition == "Sunny" || weather.condition == "Cloudy" && weather.temperature < 90 && weather.temperature >= 80 && player.recipe.pricePerCup <= pricePref)
            {
                            
                player.wallet.Money += player.recipe.pricePerCup - .05;
                return true;
            }
                 else if (weather.condition == "Sunny" || weather.condition == "Cloudy" && weather.temperature < 80 && player.recipe.pricePerCup <= pricePref)
            {
                player.wallet.Money += player.recipe.pricePerCup - .10;
                return true;
            }
                 else if (weather.condition == "Rainy" && weather.temperature > 90 && player.recipe.pricePerCup <= pricePref)
            {
                player.wallet.Money += player.recipe.pricePerCup - .05;
                return true;

            }
                else
            {
                player.wallet.Money = player.recipe.pricePerCup - player.recipe.pricePerCup;
                return false;  
            }

            
               
      }       
    }


}      
    
    
            
    
