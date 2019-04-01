﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Game
    {
        public Player player1 = new Player();       
        public Day day = new Day();
        public int Durration;
        public string Weather;
        public int Temperature;
        Random random = new Random();

        public string GetWeather()
        {           
            int RandomWeather = random.Next(1, 5);

            switch (RandomWeather)
            {
                case 1:
                    Weather = "sunny";
                    break;
                case 2:
                    Weather = "partly cloudy";
                    break;
                case 3:
                    Weather = "cloudy";
                    break;
                case 4:
                    Weather = "rainy";
                    break;
                default:
                    break;
            }
            Temperature = random.Next(1, 100);
            return Weather;
        }

        public void GetGameDurration()
        {
            UserInterface.DisplayDurrationMenu();
            Durration = int.Parse(Console.ReadLine());            
        }

        public int GetDemand()
        {
            //based on weather, temperature, and sugar content
            throw new System.NotImplementedException();
        }

        public void RunGame()
        {
            GetGameDurration();
            player1.Resupply();
            player1.SetRecipe();
            StartSellingLemonade();
        }
        public void StartSellingLemonade()
        {
            GetWeather();
            GetDemand();
            UserInterface.DisplayLemonadeStand();
        }
    }
}