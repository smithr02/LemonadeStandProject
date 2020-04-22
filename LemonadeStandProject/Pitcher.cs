using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Pitcher
    {
        public int cupsLeftInPitcher = 0;
        public static int CupsPerPitcher = 20;
        public int PricePerCup;

        public Pitcher()
        {
            
        }

        public void SetFullPitcher()
        {
            cupsLeftInPitcher = 20;
        }

        public void FillPitcher(Recipe recipe, Inventory inventory)
        {
            if(CanCreatePitcher(recipe, inventory))
            {
                for (int i = 0; i < recipe.numberOfLemons; i++)
                {
                    inventory.lemons.RemoveAt(0);
                }

                for (int i = 0; i < recipe.numberOfIceCubes; i++)
                {
                    inventory.iceCubes.RemoveAt(0);
                }

                for (int i = 0; i < recipe.numberOfSugarCubes; i++)
                {
                    inventory.sugarCubes.RemoveAt(0);
                }
                for (int i = 0; i < CupsPerPitcher; i++)
                {
                    inventory.cups.RemoveAt(0);
                }

                SetFullPitcher();
            }
            else
            {
                Console.WriteLine("You're out of ingredients, time go close the stand and go home");
            }
        }

        public bool CanCreatePitcher(Recipe recipe, Inventory inventory)
        {
            
            if(recipe.numberOfIceCubes > inventory.iceCubes.Count)
            {
                return false;
            }
            if(recipe.numberOfLemons > inventory.lemons.Count)
            {
                return false;
            }
            if(recipe.numberOfSugarCubes > inventory.sugarCubes.Count)
            {
                return false;
            }
            if(CupsPerPitcher > inventory.cups.Count)
            {
                return false;
            }


            return true;
        }
    }
}

