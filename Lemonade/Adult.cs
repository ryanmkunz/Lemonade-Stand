using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Adult : Customer
    {
        //Not using this class right now--------------------------------------------
        public Adult()
        {

        }

        public virtual bool IsBuying(int demand, Player player)
        {
            //Adult likes any recipe with extra lemons 
            if (player.LemonsPerPitcher > 4)
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