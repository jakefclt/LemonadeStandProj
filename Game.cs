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
        Day randomDay = new Day();        
        Weather weather = new Weather();       
        Store store = new Store();
        int randomCustomer;
        Customer customer = new Customer();
        Wallet wallet = new Wallet();
        Recipe recipe = new Recipe();
    public Game()
        {
            days = new List<Day>() {new Day("Monday"), new Day("Monday"), new Day("Monday"), new Day("Monday"), new Day("Monday"), new Day("Monday"), new Day("Monday") };
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

            //Game Logic
            randomCustomer= randomDay.RandomNumberOfCustomer(30, 100);
            randomDay.AddCustomersToList(randomCustomer);
            customer.BuyLemonade(player, days[0].weather, recipe, wallet);
            player.wallet.DisplayMoney();











            //Display wallet balance




        }
            

       

           



        
    }
   
}

