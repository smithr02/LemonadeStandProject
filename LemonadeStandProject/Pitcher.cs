using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Pitcher
    {
        public int cupsLeftInPitcher;
        public static int CupsPerPitcher = 20;

        public Pitcher()
        {
            SetFullPitcher();
        }

        public void SetFullPitcher()
        {
            cupsLeftInPitcher = 20;
        }
    }
}

