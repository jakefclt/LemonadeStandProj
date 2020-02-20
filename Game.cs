using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        Player player = new Player();
        List<Day> days;
     
        int currentDay;
        int buyLemons;
        int buySugar;
        int buyIce;
        int buyCups;
        double dailyProfit;                     
        Store store = new Store();
        int randomCustomer;
        Customer customer = new Customer();
        Wallet wallet = new Wallet();
        Recipe recipe = new Recipe();
      
    public Game()
        {
            
            days = new List<Day>() {new Day("Monday", player), new Day("Tuesday", player), new Day("Wednesday", player), new Day("Thursday", player), new Day("Friday", player), new Day("Saturday", player), new Day("Sunday", player) };
        }
     public double DisplayDailyProfit(Day currentday)
        {
            double profit;
            profit = (currentday.cupsSold * recipe.pricePerCup);            
            return profit;
        }

      





        public void RunGame()
        {            

            for (int i = 0; i < days.Count; i++)
            {

                // Daily Conditions
                Console.WriteLine("Today is " + days[i].day);
                days[i].weather.DisplayWeatherConditions();
                days[i].weather.DisplayTemperature();
                player.wallet.DisplayBalance();
                Console.WriteLine("Press Enter to Continue to the Store");
                Console.ReadLine();
                //Purchase items for recipe
                store.DisplayPricePerItem();
                Console.WriteLine("Lets make your Lemonade Recipe!");
                Console.ReadLine();
                buyLemons = store.SellLemons(player);
                buySugar = store.SellSugarCubes(player);
                buyIce = store.SellIceCubes(player);
                buyCups = store.SellCups(player);
                //Set price per cup & display wallet balance
                player.recipe.DisplayRecipe(buyLemons, buySugar, buyIce, buyCups);                
                player.wallet.DisplayBalance();
                recipe.SetPricePerCup();
                Console.WriteLine("Press Enter to see how you did!");
                Console.ReadLine();
                //Customer interface
                randomCustomer = days[i].RandomNumberOfCustomer(50, 200);
                days[i].AddCustomersToList(randomCustomer);
                days[i].CustomerBuysLemonade();
                Console.WriteLine("You sold " + days[i].cupsSold + " cups today!");
                dailyProfit = DisplayDailyProfit(days[i]);
                Console.WriteLine("You made $" + dailyProfit + " today.");
                player.wallet.Money += dailyProfit;
                Console.WriteLine("Press Enter to play Again." );                               
                Console.ReadLine();

                
            }











           




        }
            

       

           



        
    }
   
}

