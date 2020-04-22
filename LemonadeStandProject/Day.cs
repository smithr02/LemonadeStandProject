using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Day
    {
        List<Customer> customers = new List<Customer>();
        public Weather weather;
        public Recipe recipe;

        public Day()
        {
            weather = new Weather();
        }

        public void RunDay(Store store, Player player)
        {
            //Go to Store
            GoToStore(store, player);
            SetRecipe(player);
            AddCustomers();
            SellLemonade(player);


            //Setting the recipe
            //(Last) BuyLogic.  Looping over all of our customers and determining whether they buy or not.
        }
        public void GoToStore(Store store, Player player)
        {
            store.SellCups(player);
            store.SellIceCubes(player);
            store.SellLemons(player);
            store.SellSugarCubes(player);
            //Call all of the store buy methods to get the ingerdiants.
        }
        public void SetRecipe(Player player)
        {
            //Call the player object's 'recipe' to make the recipe.
            recipe = player.SetRecipe();


        }
        public void SellLemonade(Player player)
        {
            int count = 0;
            foreach (Customer customer in customers)
            {
                if (customer.WillingToPay && recipe.pitcher.cupsLeftInPitcher > 0)
                {
                    recipe.pitcher.cupsLeftInPitcher--;
                    player.wallet.money += Convert.ToDouble(recipe.PricePerCup);
                    count++;
                }
                else
                {
                    recipe.CreatePitcher(player.inventory);
                }

            }
            Console.WriteLine("You sold " + count + " number of cups");
            //Loop over customers ands sell lemonade to them based of the true or false they return.
        }



        private void AddCustomers()  //Solid principle example-Open/close principle, here the method adds customer but can be scaleable. Could create new names as well. 
        {
            switch (weather.condition)
            {
                case "Clear":
                    CreateCustomers(50);
                    break;
                case "Cloudy":
                    CreateCustomers(30);
                    break;
                case "Rainy":
                    CreateCustomers(15);
                    break;
                default:
                    break;
            }
        }
        private void CreateCustomers(int numberOfCustomers)
        {
            Random rng = new Random();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customers.Add(new Customer(weather, recipe));
            }
        }
    }
}
