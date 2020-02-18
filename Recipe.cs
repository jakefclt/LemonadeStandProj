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
        public double pricePerCup;

        public Recipe()
        {

        }

        public void DisplayRecipe(int amountOfLemons, int amountOfSugarCubes, int amountOfIceCubes, double pricePerCup)
        {

            this.amountOfLemons = amountOfLemons;
            this.amountOfSugarCubes = amountOfSugarCubes;
            this.amountOfIceCubes = amountOfIceCubes;
            this.pricePerCup = pricePerCup;
            Console.WriteLine("Lemons: " + amountOfLemons + " Sugar Cubes: " + amountOfSugarCubes + " Ice Cubes: " + amountOfIceCubes + " Cups: " + pricePerCup);
        }
    
    }
   
}
