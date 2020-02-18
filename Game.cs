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
        double buyCups;
        
        Weather weather = new Weather();
        Wallet wallet = new Wallet();
        Store store = new Store();
        Inventory inventory = new Inventory();
        Recipe recipe = new Recipe();
        
    public Game()
        {
            //days = new List<Day>() { "1", "2", "3", "4", "5", "6", "7" };
        }

       









    public void RunGame()
        {

            //Display Game Rules

            //Display money in wallet

            
            Console.WriteLine("Today is day 1. It is " + weather.condition + " outside and the temperature is " + weather.temperature + " degrees.");
            wallet.DisplayMoney();
            Console.WriteLine("Press Enter to Continue to the Store");
            Console.ReadLine();

            //Display Cost of items

            store.DisplayPricePerItem();
            buyLemons = player.BuyLemons();
            buySugar = player.BuySugar();
            buyIce = player.BuyIce();
            buyCups = player.BuyCups();
            inventory.AddLemonsToInventory(buyLemons);
            inventory.AddSugarCubesToInventory(buySugar);
            inventory.AddIceCubesToInventory(buyIce);
            inventory.AddCupsToInventory(buyCups);
            //Display inventory
            inventory.DisplayInventory();
            //Display wallet balance

            

            
        }
            

       

           



        
    }
   
}

