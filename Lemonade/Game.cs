using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Game
    {
        public Player player1;
        public Store store;
        public int Duration;        
        public int Demand;
        public Day day;
        public List<Day> Days;

        public Game()
        {
            player1 = new Player();
            store = new Store();           
            Days = new List<Day>();
        }

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
                day = new Day();
                Days.Add(day);
                store.Resupply(player1.inventory);
                Console.Clear();
                player1.SetRecipe();
                GetWeather();
                day.GetDailySales(GetDemand());
                GetAdjustedSales();
                player1.inventory.UpdateInventory(player1, day);
                UserInterface.DisplayDayEndReport(day.weather.WeatherForcast, day.weather.Temperature, day.CupsSold, day.Revenue, player1.PricePerCup);
                IncrementDay();
            }
            GameOver();
        }

        public void IncrementDay()
        {
            store.SupplyOrder = "";
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
            UserInterface.DisplayGameEndReport(Days, player1.inventory.Money);
            UserInterface.DisplayPlayAgainPrompt();
            if ("yes" == Console.ReadLine())
            {
                RunGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}