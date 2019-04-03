using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Game
    {
        public Player player1 = new Player();       
        public int Duration;        
        public int Temperature;
        public int Demand;
        public Day day = new Day();
        public List<double> daysRevenue = new List<double>();

        public void GetWeather()
        {
            day.weather.GetTodaysForcast();
            day.weather.GetTemperature();
        }

        public void GetGameDuration()
        {
            UserInterface.DisplayDurationMenu();
            Duration = int.Parse(Console.ReadLine());
            Console.Clear();
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
            GetGameDuration();
            player1.inventory.Money = 25;
            for (int i = 0; i < Duration; i++)
            {                 
                player1.Resupply();
                Console.Clear();
                player1.SetRecipe();
                //Console.Clear();
                GetWeather();
                day.GetDailySales(GetDemand());
                GetAdjustedSales();
                UpdateInventory();
                UserInterface.DisplayDayEndReport(day.weather.WeatherForcast, day.weather.Temperature, day.CupsSold, day.Revenue, player1.PricePerCup);
                IncrementDay();
            }
            GameOver();
        }

        public void UpdateInventory()
        {
            player1.inventory.Cups -= day.CupsSold;
            player1.inventory.Lemons -= player1.Pitchers * player1.LemonsPerPitcher;
            player1.inventory.Sugar -= player1.Pitchers * player1.SugarPerPitcher;
            player1.inventory.Ice -= player1.Pitchers * player1.IcePerPitcher;
        }

        public void IncrementDay()
        {
            daysRevenue.Add(day.Revenue);
            player1.SupplyOrder = "";
        }

        public void GetAdjustedSales()
        {
            if (player1.TotalCupsMade < day.CupsSold)
            {
                day.CupsSold = player1.TotalCupsMade;
                day.Revenue = day.CupsSold * player1.PricePerCup;
                player1.inventory.Money += day.Revenue;
            }
        }

        public void GameOver()
        {
            UserInterface.DisplayGameEndReport(daysRevenue);
            Console.ReadLine();
        }
    }
}