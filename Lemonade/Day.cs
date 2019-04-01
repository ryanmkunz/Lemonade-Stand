using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Day
    {
        private int CupsSold;
        private double Revenue;
        private double TotalCost;
        private double Profit;
        private int TimeOfDay;

        public Weather Weather
        {
            get => default(Weather);
            set
            {
            }
        }

        public Customer Customer
        {
            get => default(Customer);
            set
            {
            }
        }
    }
}