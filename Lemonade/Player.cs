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
        private string Name;
        public Inventory inventory = new Inventory();
        public Store store = new Store();

        public void Resupply()
        {
            do
            {
                UserInterface.DisplayStore();
                SupplyOrder = Console.ReadLine();
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
            } while (SupplyOrder != "none");
            
        }

        public void SellLemonade()
        {
            
            throw new System.NotImplementedException();
        }

        public void SetPrice()
        {
            throw new System.NotImplementedException();
        }

        public void SetRecipe()
        {
            throw new System.NotImplementedException();
        }
    }
}