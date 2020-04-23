using System;
using System.Collections.Generic;
using System.Data;
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
        public Pitcher pitcher = new Pitcher();
        public double profit = 0;

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
            SetupStand(player);
            SellLemonade(player);


            //Setting the recipe
            //(Last) BuyLogic.  Looping over all of our customers and determining whether they buy or not.
        }
        public void GoToStore(Store store, Player player) // this method was checked
        {
            store.SellCups(player);
            Console.WriteLine("Player has " + player.inventory.cups.Count + " cups");
            store.SellIceCubes(player);
            Console.WriteLine("Player has " + player.inventory.iceCubes.Count + " iceCubes");
            store.SellLemons(player);
            Console.WriteLine("Player has " + player.inventory.lemons.Count + " lemons");
            store.SellSugarCubes(player);
            Console.WriteLine("Player has " + player.inventory.sugarCubes.Count + " sugarCubes");
            //Call all of the store buy methods to get the ingerdiants.
        }
        public void SetRecipe(Player player) // method was checked
        {
            //Call the player object's 'recipe' to make the recipe.
            recipe = player.SetRecipe();
        }

        public void SetupStand(Player player)
        {
            // BUG HERE 
            pitcher.FillPitcher(recipe, player.inventory);
        }
        public void SellLemonade(Player player)
        {
            int count = 0;
            foreach (Customer customer in customers)
            {
                if (customer.WillingToPay && pitcher.cupsLeftInPitcher > 0)
                {
                    pitcher.cupsLeftInPitcher--;
                    player.wallet.money += Convert.ToDouble(recipe.PricePerCup);
                    count++;
                }
                else
                {
                    if (!pitcher.FillPitcher(recipe, player.inventory))
                    {
                        break;
                    }
                }

            }
            Console.WriteLine("You sold " + count + " number of cups and made " + recipe.PricePerCup*count + " today");
            profit = recipe.PricePerCup * count;
            player.wallet.addMoney(recipe.PricePerCup * count);
            Console.WriteLine("New wallet total is " + player.wallet.money);

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
        private void CreateCustomers(int numberOfCustomers) // checked
        {
            Random rng = new Random();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customers.Add(new Customer(weather, recipe));
            }
        }
    }
}
