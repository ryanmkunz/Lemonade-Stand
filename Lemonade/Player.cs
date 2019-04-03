using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Player
    {
        public string SupplyOrder;
        private int OrderQuantity;
        private double OrderCost;
        public double TotalOrderCost;
        private string RecipeItem;
        public Inventory inventory;        
        public double PricePerCup;
        public int LemonsPerPitcher;
        public int SugarPerPitcher;
        public int IcePerPitcher;
        public int CupsPerPitcher;
        public int Pitchers;
        public int TotalCupsMade;

        public Player()
        {
            inventory = new Inventory();
            CupsPerPitcher = 10;
        }
               
        public void SetPrice()
        {
            UserInterface.DisplayPriceChange();
            PricePerCup = double.Parse(Console.ReadLine());
        }

        public void SetRecipe()
        {
            PricePerCup = 0.25;
            LemonsPerPitcher = 4;
            SugarPerPitcher = 4;
            IcePerPitcher = 4;

            do
            {
                UserInterface.DisplayPriceAndQuality(PricePerCup, LemonsPerPitcher, SugarPerPitcher, IcePerPitcher);
                RecipeItem = Console.ReadLine();
                
                switch (RecipeItem)
                {
                    case "price":
                        SetPrice();
                        break;
                    case "lemons":
                        UserInterface.DisplayQuantitiyCheck(RecipeItem);
                        LemonsPerPitcher = int.Parse(Console.ReadLine());                        
                        break;
                    case "sugar":
                        UserInterface.DisplayQuantitiyCheck(RecipeItem);
                        SugarPerPitcher = int.Parse(Console.ReadLine());
                        break;
                    case "ice":
                        UserInterface.DisplayQuantitiyCheck(RecipeItem);
                        IcePerPitcher = int.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                }

            } while (RecipeItem != "none");
            Console.Clear();
            GetTotalCupsMade();
        }

        public int GetTotalCupsMade()
        {
            int[] LimitingFactor = new int[4];
            LimitingFactor[0] = inventory.Cups / CupsPerPitcher;
            LimitingFactor[1] = inventory.Lemons / LemonsPerPitcher;
            LimitingFactor[2] = inventory.Sugar / SugarPerPitcher;
            LimitingFactor[3] = inventory.Ice / IcePerPitcher;
            Pitchers = LimitingFactor.Min();
            TotalCupsMade = Pitchers * CupsPerPitcher;
            return TotalCupsMade;
        }
    }
}