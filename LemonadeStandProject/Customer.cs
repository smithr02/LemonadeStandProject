using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Customer
    {
        public string Name;
        private List<string> PossibleNames = new List<string>() { "Mark", "Jon", "Stehpanie", "Cassie", "Tom", "Jesus", "Sheldon", "Marki", "Sarah" };
        public int PriceWillingToPay = 0;
        public bool WillingToPay = false;

        public Customer (Weather weather, Recipe recipe)
        {
            SetCustomerName();
            SetCustomerPref(weather, recipe);
        }

        private void SetCustomerName()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            Name = PossibleNames[rand.Next(0, PossibleNames.Count - 1)];
        }

        private void SetPriceWIllingToPay()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            PriceWillingToPay = rand.Next(1, 5);
        }

        private void SetCustomerPref(Weather weather, Recipe recipe)
        {
            SetPriceWIllingToPay();

            switch (weather.condition)
            {
                case "Cloudy":
                    {
                        if (weather.temp >= 50 && PriceWillingToPay > recipe.PricePerCup)
                        {
                            WillingToPay = true;
                        }
                        else
                        {
                            WillingToPay = false;
                        }
                        break;
                    }
                case "Rainy":
                    {
                        if (weather.temp >=70 && PriceWillingToPay > recipe.PricePerCup)
                        {
                            WillingToPay = true;
                        }
                        else
                        {
                            WillingToPay = false;
                        }
                        break;
                    }
                case "Clear":
                    {
                        if (weather.temp >= 40 && PriceWillingToPay > recipe.PricePerCup)
                        {
                            WillingToPay = true;
                        }
                        else
                        {
                            WillingToPay = false;
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }


    }
}
