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

        public Inventory()
        {

        }

        public void UpdateInventory(Player player1, Day day)
        {            
            Cups -= day.CupsSold;
            Lemons -= player1.Pitchers * player1.LemonsPerPitcher;
            Sugar -= player1.Pitchers * player1.SugarPerPitcher;
            Ice -= player1.Pitchers * player1.IcePerPitcher;
        }
    }
}