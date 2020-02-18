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
            Console.WriteLine("Lemons: " + amountOfLemons + " Sugar Cubes: " + amountOfSugarCubes + " Ice Cubes: " + amountOfIceCubes + " Price per Cup " + pricePerCup);
        }
        //public int AddLemons()
        //{
        //    Console.WriteLine("How many Lemons do you want to add?");
        //    amountOfLemons = int.Parse(Console.ReadLine());
        //    return amountOfLemons;
        //}
        
        //public int AddSugarCubes()
        //{
        //    Console.WriteLine("How many Sugar Cubes do you want to add?");
        //    amountOfSugarCubes = int.Parse(Console.ReadLine());
        //    return amountOfSugarCubes;
        //}

        //public int AddIceCubes()
        //{
        //    Console.WriteLine("How many Ice Cubes do you want to add?");            
        //    amountOfIceCubes = int.Parse(Console.ReadLine());
        //    return amountOfIceCubes;
        //}

        //public double AddCups()
        //{
        //    Console.WriteLine("How many Cups do you want to add?");         
        //    pricePerCup = double.Parse(Console.ReadLine());
        //    return pricePerCup;
        //}

    }
   
}
