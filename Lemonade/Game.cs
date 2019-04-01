using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Game
    {
        public Player player1 = new Player();
        public int Durration;
        

        public string GetWeather()
        {
            throw new System.NotImplementedException();
        }

        public void GetGameDurration()
        {
            UserInterface.DisplayDurrationMenu();
            Durration = int.Parse(Console.ReadLine());            
        }

        public int GetDemand()
        {
            throw new System.NotImplementedException();
        }

        public void RunGame()
        {
            GetGameDurration();
            player1.Resupply();
            player1.SetRecipe();
            UserInterface.DisplayLemonadeStand();
        }
    }
}