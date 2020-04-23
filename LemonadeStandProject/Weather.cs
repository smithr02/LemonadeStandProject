using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Weather
    {
        public int temp;
        public string condition;
        List<String> weatherConditions = new List<string>() { "Cloudy", "Clear", "Rainy" };

        public Weather()
        {
            setWeather();
        }

        private void setWeather() //method for setting the weather, used guid to help with random being truly more random.
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            temp = rand.Next(30, 100);
            condition = weatherConditions[rand.Next(0, 2)];
        }

        public void modifyPredictions()  // SOLID EXAMPLE- this is single responsibility, where it simply creates a randomly generated condition and does it well.
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            temp = rand.Next(temp -5, temp +5);
            condition = weatherConditions[rand.Next(0, 2)];
        }
    }

  
}
