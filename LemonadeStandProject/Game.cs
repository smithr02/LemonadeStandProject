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

        public Game(Player player, Store store)
        {
            for (int i = 0; i <NumberOfDays; i++)
            {
                GameDays.Add(new Day());
            }

            int currentDay = 0;
            string currentCondition = "";
            int currentTemp = 0;

            //Main Game Loop
            while (currentDay < NumberOfDays)
            {

            }
        }
    }
}
