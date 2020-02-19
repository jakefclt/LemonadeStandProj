using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        Player player = new Player();
        List<Day> days;
        int currentDay;
        int buyLemons;
        int buySugar;
        int buyIce;
        int buyCups;      
        Weather weather = new Weather();       
        Store store = new Store();
        int randomCustomer;
        Customer customer = new Customer();
        Wallet wallet = new Wallet();
        Recipe recipe = new Recipe();
    public Game()
        {
            
            days = new List<Day>() {new Day("Monday", player), new Day("Tuesday", player), new Day("Wednesday", player), new Day("Thursday", player), new Day("Friday", player), new Day("Saturday", player), new Day("Sunday", player) };
        }
     







        public void RunGame()
        {

            //Display Game Rules

            //Display money in wallet

            
            Console.WriteLine("Today is " + days[0].day + " It is " + weather.condition + " outside and the temperature is " + weather.temperature + " degrees.");
            player.wallet.DisplayMoney();
            Console.WriteLine("Press Enter to Continue to the Store");
            Console.ReadLine();

            
            
            store.DisplayPricePerItem();
            Console.WriteLine("Lets make your lemonade Recipe!");
            Console.ReadLine();
            buyLemons = store.SellLemons(player);
            buySugar = store.SellSugarCubes(player);
            buyIce = store.SellIceCubes(player);
            buyCups = store.SellCups(player);

            player.recipe.DisplayRecipe(buyLemons, buySugar, buyIce, buyCups);
            //player.wallet.PayMoneyForItems(store.pricePerLemon);
            player.wallet.DisplayMoney();
            recipe.SetPricePerCup();
            Console.WriteLine("Press Enter to Play!");
            Console.ReadLine();
            //Game Logic
            randomCustomer= days[0].RandomNumberOfCustomer(50, 200);
            days[0].AddCustomersToList(randomCustomer);            
            days[0].CustomerBuysLemonade();
            Console.WriteLine("You sold " + days[0].cupsSold + " cups today!");












            //Display wallet balance




        }
            

       

           



        
    }
   
}

