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
        public Customer customer;
        private Random random;
        public int CustomerType;

        public Day()
        {
            CupsSold = 0;
            TotalCustomers = 1000;
            weather = new Weather();
            random = new Random();
        }

        public void GetDailySales(int demand)
        {
            for (int i = 0; i < TotalCustomers; i++)
            {
                CustomerType = random.Next(1, 4);
                switch (CustomerType)
                {
                    case 1:
                        customer = new Child();
                        break;
                    case 2:
                        customer = new Adult();
                        break;
                    case 3:
                        customer = new OldPerson();
                        break;
                    default:
                        break;
                }
                if (customer.IsBuying(demand))
                {
                    CupsSold++;
                }                
            }
        }
    }
}