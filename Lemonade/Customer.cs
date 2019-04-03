using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Customer
    {
        private Random random;

        public Customer()
        {
            random = new Random();
        }

        public virtual bool IsBuying(int demand, Player player)
        {
            
            if (random.Next(1, 11) <= demand)
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