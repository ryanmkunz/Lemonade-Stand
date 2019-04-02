using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public static class UserInterface
    {
        public static void DisplayStore(Inventory inventory)
        {
            Console.WriteLine('\n'+"You have:");
            Console.WriteLine(inventory.Cups + " Paper cups");
            Console.WriteLine(inventory.Lemons +" Lemons");
            Console.WriteLine(inventory.Sugar + " Cups of Sugar");
            Console.WriteLine(inventory.Ice + " Ice Cubes"+'\n');
            Console.WriteLine("Money: $" + inventory.Money + '\n');
            Console.WriteLine("Enter the name of the item you wish to purchase, or enter none to continue");
        }

        public static void DisplayPriceAndQuality(double lemonadePrice, int lemonsPerPitcher, int sugarPerPitcher, int icePerPitcher)
        {
            Console.WriteLine('\n'+"Price/Quality control");
            Console.WriteLine("Price per cup: $" + lemonadePrice);
            Console.WriteLine("Lemons per pitcher: " + lemonsPerPitcher);
            Console.WriteLine("Sugar per pitcher: " + sugarPerPitcher);
            Console.WriteLine("Ice cubes per pitcher: " + icePerPitcher+'\n');
            Console.WriteLine("Enter the name of the item you would like to change, or enter none to continue");
        }

        public static void DisplayDayEndReport(string weather, int temperature, int sales, double costs, double pricePerCup)
        {
            Console.WriteLine('\n' + "It was " + temperature + " degrees and " + weather + " today");
            Console.WriteLine("Sold " + sales + " cups of lemonade");
            Console.WriteLine("You made $" + ((sales * pricePerCup) - costs)+'\n');
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
            Console.WriteLine('\n'+"Enter the quantity of "+itemName+" you would like");
        }

        public static void DisplayReceipt(string itemName, int quantity, double totalCost)
        {
            Console.WriteLine('\n'+"Purchased "+quantity+" "+itemName+" for $"+totalCost);
        }

        public static void DisplayPriceChange()
        {
            Console.WriteLine("Enter new price per cup");
        }
    }
}