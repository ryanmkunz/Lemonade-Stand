using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Customer
    {
        private Random random = new Random();

        public bool IsBuying(int demand)
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