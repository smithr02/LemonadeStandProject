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
            
        }

        public void setWeather() //method for setting the weather, used seed to create a more random number.
        {
            int seed = DateTime.Now.Millisecond;
            Random rand = new Random(seed);
            temp = rand.Next(30, 100);
            condition = weatherConditions[rand.Next(0, 2)];
        }

        public void modifyPredictions()
        {
            int seed = DateTime.Now.Millisecond;
            Random rand = new Random(seed);
            temp = rand.Next(temp -5, temp +5);
            condition = weatherConditions[rand.Next(0, 2)];
        }
    }

  
}
