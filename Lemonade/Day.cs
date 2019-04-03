using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Day
    {
        public int CupsSold = 0;
        public int TotalCustomers = 300;
        public double Revenue;

        public Weather weather = new Weather();

        public void GetDailySales(int demand)
        {
            for (int i = 0; i < TotalCustomers; i++)
            {
                Customer customer = new Customer();
                if (customer.IsBuying(demand))
                {
                    CupsSold++;
                }                
            }
        }
    }
}