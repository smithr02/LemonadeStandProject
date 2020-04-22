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
        Day day = new Day();

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
                Console.WriteLine("Today is " + DaysOfWeek[currentDay]);
                Console.WriteLine("Current weather is " + currentTemp + "F and " + currentCondition);
                

                currentDay++;
            }

            if (currentDay + 1 < NumberOfDays)
            {
                Console.WriteLine("\n\tThis Weeks Forecast:");
                for (int i = currentDay + 1; i < NumberOfDays; i++)
                {
                    Console.WriteLine("\t" + DaysOfWeek[i] + " " + GameDays[i].weather.temp + "F and " + GameDays[i].weather.condition);

                }
            }
            
        }
        
    }
}
