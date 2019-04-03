using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class OldPerson : Customer
    {
        public OldPerson()
        {

        }

        public override bool IsBuying(int demand, Player player)
        {
            //OldPerson likes recipes with less sugar 
            if (player.SugarPerPitcher < 4)
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