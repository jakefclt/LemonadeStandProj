using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public int amountOfCups;
        public double pricePerCup;

        public Recipe()
        {

        }

        public void DisplayRecipe(int amountOfLemons, int amountOfSugarCubes, int amountOfIceCubes, int amountOfCups)
        {

            this.amountOfLemons = amountOfLemons;
            this.amountOfSugarCubes = amountOfSugarCubes;
            this.amountOfIceCubes = amountOfIceCubes;
            this.amountOfCups = amountOfCups;
            Console.WriteLine("Lemons: " + amountOfLemons + " Sugar Cubes: " + amountOfSugarCubes + " Ice Cubes: " + amountOfIceCubes + " Cups: " + amountOfCups);
        }

       public void SetPricePerCup()
        {
            Console.WriteLine("What would you like to set your price per cup of lemonade?");
            pricePerCup = double.Parse(Console.ReadLine());
        }     
    
    }
   
}
