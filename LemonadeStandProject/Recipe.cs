using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Recipe
    {
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public int PricePerCup;

        public Recipe()
        {
            
        }

       





        public void SetRecipe()
        {
            Console.WriteLine("How many lemons do you want use?");
            numberOfLemons = int.Parse(Console.ReadLine());


            Console.WriteLine("How many sugar cubes do you want use?");
            numberOfSugarCubes = int.Parse(Console.ReadLine());

            Console.WriteLine("How many ice cubes do you want use?");
            numberOfIceCubes = int.Parse(Console.ReadLine());

            Console.WriteLine("What do you want the price per cup to be?");
            PricePerCup = int.Parse(Console.ReadLine());

        }

    }
}
