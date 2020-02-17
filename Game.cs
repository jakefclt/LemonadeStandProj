using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        Player player;
        List<Day> days;
        int currentDay;
        Day day = new Day();
        Day newDay = new Day();
        Weather weather = new Weather();
        Wallet wallet = new Wallet();
        Store store = new Store();
        Inventory inventory = new Inventory();
        public Game()
        {

        }

        public int BuyLemons()
        {
            Console.WriteLine("How many Lemons do you want to buy?");
            int input;
            input = int.Parse(Console.ReadLine());
            return input;
        }

        public int SugarCubes()
        {
            Console.WriteLine("How many Sugar Cubes do you want to buy?");
            int input;
            input = int.Parse(Console.ReadLine());
            return input;
        }

        public int IceCubes()
        {
            Console.WriteLine("How many Ice Cubes do you want to buy?");
            int input;
            input = int.Parse(Console.ReadLine());
            return input;
        }

        public int Cups()
        {
            Console.WriteLine("How many Cups do you want to buy?");
            int input;
            input = int.Parse(Console.ReadLine());
            return input;
        }

        public void RunGame()
        {

            //Display Game Rules

            //Display money in wallet
            Console.WriteLine("You have "+ wallet.Money + " in your wallet.");
            Console.WriteLine("Press Enter to Continue to the Store");
            Console.ReadLine();

            //Display Cost of items

            Console.WriteLine(" Price Per Item" +
                              "\n" +
                              "\n Lemons: " + store.pricePerLemon +
                              "\n Sugar Cubes: " + store.pricePerSugarCube +
                              "\n Ice Cube: " + store.pricePerIceCube +
                              "\n Cups " + store.pricePerCup);

            BuyLemons();
            SugarCubes();
            IceCubes();
            Cups();
        }
            

       
           



        
    }
   
}

