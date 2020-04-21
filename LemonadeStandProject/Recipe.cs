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
        public Pitcher pitcher;
        public int PricePerCup;

        public Recipe()
        {

        }

        public void CreatePitcher(Inventory ourInventory) //keeping track of our inventory
        {

            if (CanCreatePitcher(ourInventory))
            {
                pitcher = new Pitcher();
                for (int i = 0; i < numberOfLemons; i++)
                {
                    ourInventory.lemons.RemoveAt(0);
                }

                for (int i = 0; i < numberOfIceCubes; i++)
                {
                    ourInventory.iceCubes.RemoveAt(0);
                }

                for (int i = 0; i < numberOfSugarCubes; i++)
                {
                    ourInventory.sugarCubes.RemoveAt(0);
                }
                for (int i = 0; i < ourInventory.cups.Count; i++)
                {
                    ourInventory.cups.RemoveAt(0);
                }

            }
            else
            {
                Console.WriteLine("Not enough inventory");
            }




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

        public bool CanCreatePitcher(Inventory EnoughSupplies)
        {
            if (numberOfLemons < EnoughSupplies.lemons.Count && numberOfSugarCubes < EnoughSupplies.sugarCubes.Count && numberOfIceCubes < EnoughSupplies.iceCubes.Count && Pitcher.CupsPerPitcher >= EnoughSupplies.cups.Count)
            {
                return true;
            }
            return false;



        }
    }
}
