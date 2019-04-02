using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Customer
    {
        public int Susceptibility;
        public double MoneyInPocket;
        private Random random = new Random();

        public void BuyLemonade()
        {
            throw new System.NotImplementedException();
        }

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