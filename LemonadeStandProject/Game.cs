using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Game
    {
        List<Day> GameDays = new List<Day>();
        int NumberOfDays = 7;
        string[] DaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Player player = new Player();
        Store store = new Store();
        Inventory inventory = new Inventory();
        Day day = new Day();
        double totalProfits = 0;

        public Game(Player player, Store store)
        {
            for (int i = 0; i < NumberOfDays; i++)
            {
                GameDays.Add(new Day());
            }

            int currentDay = 0;
            string currentCondition = "";
            int currentTemp = 0;

            //Main Game Loop
            while (currentDay < NumberOfDays)
            {
                GameDays[currentDay].weather.modifyPredictions();
                currentCondition = GameDays[currentDay].weather.condition;
                currentTemp = GameDays[currentDay].weather.temp;
                currentDay++;
            }

            for(int i=0; i < NumberOfDays; i++)
            {
                Console.WriteLine("Current weather is " + GameDays[i].weather.temp + "F and " + GameDays[i].weather.condition);
                GameDays[i].RunDay(store, player);
                totalProfits += GameDays[i].profit;
                Console.WriteLine("Current total profits are " + totalProfits);
                Console.WriteLine("\n\t Tomorrow's Forecast:");
                Console.WriteLine("\t" + DaysOfWeek[i+1] + " " + GameDays[i+1].weather.temp + "F and " + GameDays[i+1].weather.condition);
            }


            
        }
        
    }
}
