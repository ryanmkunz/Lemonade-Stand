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

        public static void DisplayPriceAndQuality(double lemonadePrice, int lemonsPerPitcher, int sugarPerPitcher, int icePerPitcher)
        {
            Console.WriteLine("Price/Quality control");
            Console.WriteLine("Price per cup: $" + lemonadePrice);
            Console.WriteLine("Lemons per pitcher: " + lemonsPerPitcher);
            Console.WriteLine("Sugar per pitcher: " + sugarPerPitcher);
            Console.WriteLine("Ice cubes per pitcher: " + icePerPitcher+'\n');
            Console.WriteLine("Enter the name of the item you would like to change, or enter none to continue");
        }

        public static void DisplayLemonadeStand()
        {
            Console.WriteLine("TODO: This is the point where the lemonade stand shows up");
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
            Console.WriteLine("Enter the quantity of "+itemName+" you would like");
        }

        public static void DisplayReceipt(string itemName, int quantity, double totalCost)
        {
            Console.WriteLine("Purchased "+quantity+" "+itemName+"for $"+totalCost);
        }

        public static void DisplayPriceChange()
        {
            Console.WriteLine("Enter new price per cup");
        }
    }
}