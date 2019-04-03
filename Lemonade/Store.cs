using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Store
    {
        public double CupPrice;
        public double LemonPrice;
        public double SugarPrice;
        public double IcePrice;
        public string SupplyOrder;
        private int OrderQuantity;
        private double OrderCost;
        public double TotalOrderCost;

        public Store()
        {
            CupPrice = 0.08;
            LemonPrice = 0.07;
            SugarPrice = 0.06;
            IcePrice = 0.09;
        }

        public void Resupply(Inventory inventory)
        {
            TotalOrderCost = 0;
            while (SupplyOrder != "none")
            {
                do
                {
                    UserInterface.DisplayStore(inventory);
                    UserInterface.StringInput = Console.ReadLine();
                } while (!UserInterface.InputValidation(UserInterface.StringInput, "supplies"));

                SupplyOrder = UserInterface.StringInput;
                if (SupplyOrder != "none")
                {
                    do
                    {
                        UserInterface.DisplayQuantitiyCheck(SupplyOrder);
                        UserInterface.StringInput = Console.ReadLine();
                    } while (!int.TryParse(UserInterface.StringInput, out UserInterface.BadInput)); // && player can afford purchase);                    
                    OrderQuantity = int.Parse(UserInterface.StringInput);
                    switch (SupplyOrder)
                    {
                        case "cups":
                            inventory.Cups += OrderQuantity;
                            OrderCost = OrderQuantity * CupPrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Cups", OrderQuantity, OrderCost);
                            TotalOrderCost += OrderCost;
                            break;
                        case "lemons":
                            inventory.Lemons += OrderQuantity;
                            OrderCost = OrderQuantity * LemonPrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Lemons", OrderQuantity, OrderCost);
                            TotalOrderCost += OrderCost;
                            break;
                        case "sugar":
                            inventory.Sugar += OrderQuantity;
                            OrderCost = OrderQuantity * SugarPrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Cups of Sugar", OrderQuantity, OrderCost);
                            TotalOrderCost += OrderCost;
                            break;
                        case "ice":
                            inventory.Ice += OrderQuantity;
                            OrderCost = OrderQuantity * IcePrice;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Ice cubes", OrderQuantity, OrderCost);
                            TotalOrderCost += OrderCost;
                            break;
                        case "default":
                            inventory.Cups = 60;
                            inventory.Lemons = 24;
                            inventory.Sugar = 24;
                            inventory.Ice = 24;
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
    }
}

