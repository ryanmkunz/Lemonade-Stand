using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Player
    {
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
            do
            {
                UserInterface.DisplayPriceChange();
            } while (false); //use UserInterface.InputValidation(str, type)            
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
                do
                {
                    UserInterface.DisplayPriceAndQuantity(PricePerCup, LemonsPerPitcher, SugarPerPitcher, IcePerPitcher);
                    UserInterface.StringInput = Console.ReadLine();
                } while (!UserInterface.InputValidation(UserInterface.StringInput, "supplies"));
                RecipeItem = UserInterface.StringInput;                
                switch (RecipeItem)
                {
                    case "price":
                        SetPrice();
                        break;
                    case "lemons":
                        do
                        {
                            UserInterface.DisplayQuantitiyCheck(RecipeItem);
                            UserInterface.StringInput = Console.ReadLine();
                        } while (!int.TryParse(UserInterface.StringInput, out UserInterface.BadInput));                        
                        LemonsPerPitcher = int.Parse(UserInterface.StringInput);                        
                        break;
                    case "sugar":
                        do
                        {
                            UserInterface.DisplayQuantitiyCheck(RecipeItem);
                            UserInterface.StringInput = Console.ReadLine();
                        } while (!int.TryParse(UserInterface.StringInput, out UserInterface.BadInput));
                        SugarPerPitcher = int.Parse(UserInterface.StringInput);
                        break;
                    case "ice":
                        do
                        {
                            UserInterface.DisplayQuantitiyCheck(RecipeItem);
                            UserInterface.StringInput = Console.ReadLine();
                        } while (!int.TryParse(UserInterface.StringInput, out UserInterface.BadInput));                        
                        IcePerPitcher = int.Parse(UserInterface.StringInput);
                        break;
                    default:
                        break;
                }

            } while (RecipeItem != "none");
            //Console.Clear();
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