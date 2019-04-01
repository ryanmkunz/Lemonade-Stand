using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class UserInterface
    {
        public void DisplayStore()
        {
            Console.WriteLine("You have:");
            Console.WriteLine("x Paper cups");
            Console.WriteLine("x Lemons");
            Console.WriteLine("x Cups of Sugar");
            Console.WriteLine("x Ice Cubes"+'\n');

            Console.WriteLine("Enter the name of the item you wish to purchase, or enter none to continue");
        }

        public void DisplayPriceAndQuality()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayLemonadeStand()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayDayEndReport()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayWeekEndReport()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayWeatherForcast()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayDurrationMenu()
        {
            Console.WriteLine("How long would you like to play?");
            Console.WriteLine("7 Days , 14 Days, 30 Days");
        }
    }
}