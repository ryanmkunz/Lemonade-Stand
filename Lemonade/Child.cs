using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Child : Customer
    {
        public Child()
        {

        }

        public override bool IsBuying(int demand, Player player)
        {
            if (player.SugarPerPitcher > 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}