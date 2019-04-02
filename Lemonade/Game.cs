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
        public int Temperature;
        public int Demand;
        public Day day = new Day();

        public void GetWeather()
        {
            day.weather.GetTodaysForcast();
            day.weather.GetTemperature();
            //day.weather.GetFutureForcast();
        }

        public void GetGameDurration()
        {
            UserInterface.DisplayDurrationMenu();
            Durration = int.Parse(Console.ReadLine());            
        }

        public int GetDemand()
        {
            //based on weather, temperature, and sugar content
            //Maximum demand is 10, minimum 1
            //+3 for weather, temp, and sugar each
            Demand = 0;
            int sugarBaseline = 4;
            Demand += day.weather.RandomWeather; //RandomWeather is between 1 and 4
            Demand += ((day.weather.Temperature - 70) / 10);
            Demand += player1.SugarPerPitcher - sugarBaseline; 
            return Demand;
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