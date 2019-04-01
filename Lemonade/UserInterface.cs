using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public static class UserInterface
    {
        public static void DisplayStore()
        {
            Console.WriteLine("You have:");
            Console.WriteLine("x Paper cups");
            Console.WriteLine("x Lemons");
            Console.WriteLine("x Cups of Sugar");
            Console.WriteLine("x Ice Cubes"+'\n');

            Console.WriteLine("Enter the name of the item you wish to purchase, or enter none to continue");
        }

        public static void DisplayPriceAndQuality()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayLemonadeStand()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayDayEndReport()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayWeekEndReport()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayWeatherForcast()
        {
            throw new System.NotImplementedException();
        }

        public static void DisplayDurrationMenu()
        {
            Console.WriteLine("How long would you like to play?");
            Console.WriteLine("7 Days , 14 Days, 30 Days");
        }

        public static void DisplayQuantitiyCheck(string itemName)
        {
            Console.WriteLine("Enter the quantity of "+itemName+" you would like to purchase");
        }

        public static void DisplayReceipt(string itemName, int quantity, double totalCost)
        {
            Console.WriteLine("Purchased "+quantity+" "+itemName+"for $"+totalCost);
        }
    }
}