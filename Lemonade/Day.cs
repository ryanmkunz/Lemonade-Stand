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
        public double Costs;
        public double Profit;
        public Weather weather;
        public Customer customer;
        private Random random;
        public int CustomerType;

        public Day()
        {
            CupsSold = 0;
            TotalCustomers = 300;
            Revenue = 0;
            Profit = 0;
            weather = new Weather();
            random = new Random();
        }

        public void GetDailySales(int demand, Player player)
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
                        customer = new Customer();
                        break;
                    case 3:
                        customer = new OldPerson();
                        break;
                    default:
                        break;
                }
                if (customer.IsBuying(demand, player))
                {
                    CupsSold++;
                }                
            }
        }
    }
}