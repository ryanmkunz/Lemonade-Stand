using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Player
    {
        private string SupplyOrder;
        private string Name;
        public Inventory inventory = new Inventory();

        public void Resupply()
        {
            SupplyOrder = Console.ReadLine();
            switch (SupplyOrder)
            {
                case "cups":
                    break;
                case "lemons":
                    break;
                case "sugar":
                    break;
                case "ice":
                    break;
                default:
                    break;
            }
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