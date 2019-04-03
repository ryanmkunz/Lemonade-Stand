using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Player
    {
        public string SupplyOrder; //what player is buying
        private int OrderQuantity; //how much player is buying
        private double OrderCost;  //cost of one material
        public double TotalOrderCost;
        private string RecipeItem;
        public Inventory inventory = new Inventory();
        public Store store = new Store();        
        public double PricePerCup;
        public int LemonsPerPitcher;
        public int SugarPerPitcher;
        public int IcePerPitcher;
        public int CupsPerPitcher = 10;
        public int Pitchers;
        public int TotalCupsMade;        
        
        public void Resupply()
        {
            TotalOrderCost = 0;
            while (SupplyOrder != "none")
            {
                UserInterface.DisplayStore(inventory);
                SupplyOrder = Console.ReadLine();
                if (SupplyOrder != "none")
                {
                    UserInterface.DisplayQuantitiyCheck(SupplyOrder);
                    OrderQuantity = int.Parse(Console.ReadLine());
                    switch (SupplyOrder)
                    {
                        case "cups":
                            inventory.Cups += OrderQuantity;
                            OrderCost = OrderQuantity * store.CupPrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Cups", OrderQuantity, OrderCost);
                            TotalOrderCost += OrderCost;
                            break;
                        case "lemons":
                            inventory.Lemons += OrderQuantity;
                            OrderCost = OrderQuantity * store.LemonPrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Lemons", OrderQuantity, OrderCost);
                            TotalOrderCost += OrderCost;
                            break;
                        case "sugar":
                            inventory.Sugar += OrderQuantity;
                            OrderCost = OrderQuantity * store.SugarPrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Cups of Sugar", OrderQuantity, OrderCost);
                            TotalOrderCost += OrderCost;
                            break;
                        case "ice":
                            inventory.Ice += OrderQuantity;
                            OrderCost = OrderQuantity * store.IcePrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Ice cubes", OrderQuantity, OrderCost);
                            TotalOrderCost += OrderCost;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    break;
                }
                Console.Clear();
            }                                     
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