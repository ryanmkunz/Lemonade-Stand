using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Customer
    {
        //TODO: Add some child classes for 'child', 'adult', and 'old person' with a preference for different recipes 
        //Should have a certain chance of instantiating each of them

        private Random random;

        public Customer()
        {
            random = new Random();
        }

        public bool IsBuying(int demand)
        {
            //Consider letting 'demand' go higher than 10 for more flexibility
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