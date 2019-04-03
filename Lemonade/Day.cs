using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Day
    {
        public int CupsSold;
        public int TotalCustomers;
        public double Revenue;
        public Weather weather;

        public Day()
        {
            CupsSold = 0;
            TotalCustomers = 300;
            weather = new Weather();
        }
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