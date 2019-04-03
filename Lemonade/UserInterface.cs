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
            Console.WriteLine("You have:");
            Console.WriteLine(inventory.Cups + " Paper cups");
            Console.WriteLine(inventory.Lemons +" Lemons");
            Console.WriteLine(inventory.Sugar + " Cups of Sugar");
            Console.WriteLine(inventory.Ice + " Ice Cubes"+'\n');
            Console.WriteLine("Money: $" + inventory.Money + '\n');
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

        public static void DisplayDayEndReport(string weather, int temperature, int sales, double revenue, double pricePerCup)
        {
            Console.WriteLine("It was " + temperature + " degrees and " + weather + " today");
            Console.WriteLine("Sold " + sales + " cups of lemonade");
            Console.WriteLine("You made $" + revenue +'\n');
        }

        public static void DisplayDurationMenu()
        {
            Console.Clear();
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

        public static void DisplayGameEndReport(List<Day>days, double money)
        {
            Console.WriteLine("Game Over" + '\n');
            for (int i = 0; i < days.Count; i++)
            {
                Console.Write("Day " + (i+1) + " Revenue: $");
                Console.WriteLine(days[i].Revenue);                
            }
            Console.WriteLine('\n' + "Profit: $" + (money - 25) + '\n');
        }

        public static void DisplayPlayAgainPrompt()
        {
            Console.WriteLine("Would you like to play again?");
        }
    }
}