using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Player
    {
        private string Name;

        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }

        public void Resupply()
        {
            throw new System.NotImplementedException();
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