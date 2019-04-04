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

        public Store()
        {
            CupPrice = 0.08;
            LemonPrice = 0.07;
            SugarPrice = 0.06;
            IcePrice = 0.09;
        }

        public void Resupply(Inventory inventory)
        {
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
                    } while (!int.TryParse(UserInterface.StringInput, out UserInterface.BadInput));                   
                    OrderQuantity = int.Parse(UserInterface.StringInput);
                    switch (SupplyOrder)
                    {
                        case "cups":                            
                            OrderCost = OrderQuantity * CupPrice;
                            CheckBalance(inventory, CupPrice);
                            inventory.Cups += OrderQuantity;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Cups", OrderQuantity, OrderCost);
                            break;
                        case "lemons":
                            OrderCost = OrderQuantity * LemonPrice;
                            CheckBalance(inventory, LemonPrice);
                            inventory.Lemons += OrderQuantity;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Lemons", OrderQuantity, OrderCost);
                            break;
                        case "sugar":
                            OrderCost = OrderQuantity * SugarPrice;
                            CheckBalance(inventory, SugarPrice);
                            inventory.Sugar += OrderQuantity;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Sugar", OrderQuantity, OrderCost);
                            break;
                        case "ice":
                            OrderCost = OrderQuantity * IcePrice;
                            CheckBalance(inventory, CupPrice);
                            inventory.Ice += OrderQuantity;
                            inventory.Money -= OrderCost;
                            UserInterface.DisplayReceipt("Ice", OrderQuantity, OrderCost);
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
            SupplyOrder = "";
        }

        public void CheckBalance(Inventory inventory, double itemPrice)
        {
            if (OrderCost > inventory.Money)
            {
                OrderQuantity = Convert.ToInt32(Math.Floor((inventory.Money / itemPrice)));
                OrderCost = itemPrice * OrderQuantity;
            }            
        }
    }
}

