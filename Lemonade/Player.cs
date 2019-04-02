using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Player
    {
        private string SupplyOrder;
        private int OrderQuantity;
        private double OrderCost;
        private string RecipeItem;
        public string Name;
        public Inventory inventory = new Inventory();
        public Store store = new Store();
        public double PricePerCup;
        public int LemonsPerPitcher;
        public int SugarPerPitcher;
        public int IcePerPitcher;

        public void Resupply()
        {          
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
                            break;
                        case "lemons":
                            inventory.Lemons += OrderQuantity;
                            OrderCost = OrderQuantity * store.LemonPrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Lemons", OrderQuantity, OrderCost);
                            break;
                        case "sugar":
                            inventory.Sugar += OrderQuantity;
                            OrderCost = OrderQuantity * store.SugarPrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Cups of Sugar", OrderQuantity, OrderCost);
                            break;
                        case "ice":
                            inventory.Ice += OrderQuantity;
                            OrderCost = OrderQuantity * store.IcePrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Ice cubes", OrderQuantity, OrderCost);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    break;
                }
                
            }                                     
        }

        public void SellLemonade()
        {
            
            throw new System.NotImplementedException();
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
        }
    }
}