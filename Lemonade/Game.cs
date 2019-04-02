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
        }

        public void GetGameDurration()
        {
            UserInterface.DisplayDurrationMenu();
            Durration = int.Parse(Console.ReadLine());            
        }
        
        public int GetDemand()
        {           
            Demand = 0;
            int sugarBaseline = 4;
            Demand += day.weather.RandomWeather;
            Demand += ((day.weather.Temperature - 70) / 10);
            Demand += player1.SugarPerPitcher - sugarBaseline;
            if (player1.PricePerCup > 0.25)
            {
                //TODO: make this more complicated (realistic)
                Demand = -1;               
            }
            return Demand;
        }

        public void RunGame()
        {

            GetGameDurration(); //Duration only has one R
            player1.Resupply();
            player1.SetRecipe();
            GetWeather();
            day.GetDailySales(GetDemand());            

            if (player1.TotalCupsMade < day.CupsSold)
            {
                day.CupsSold = player1.TotalCupsMade;                
            }
            UpdateInventory();
            UserInterface.DisplayDayEndReport(day.weather.WeatherForcast, day.weather.Temperature, day.CupsSold, player1.TotalOrderCost, player1.PricePerCup);
            Console.ReadLine();
        }

        public void UpdateInventory()
        {
            player1.inventory.Cups -= day.CupsSold;
            player1.inventory.Lemons -= player1.Pitchers * player1.LemonsPerPitcher;
            player1.inventory.Sugar -= player1.Pitchers * player1.SugarPerPitcher;
            player1.inventory.Ice -= player1.Pitchers * player1.IcePerPitcher;
        }
    }
}