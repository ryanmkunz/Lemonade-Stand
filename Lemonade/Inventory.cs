using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Inventory
    {
        public int Cups;
        public int Lemons;
        public int Sugar;
        public int Ice;
        public double Money;

        public void UpdateInventory(Player player1, Day day)
        {           
            Cups -= day.CupsSold;
            Ice = 0;
            if (day.CupsSold > 0)
            {
                Lemons -= player1.Pitchers * player1.LemonsPerPitcher;
                Sugar -= player1.Pitchers * player1.SugarPerPitcher;
            }
        }
    }
}