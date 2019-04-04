using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Game
    {
        //--------------------------------------------
        //TODO
        //Add weekly forcast
        //Add price sensitivity to child classes of Customer
        //Have end of week report display every 7 days
        //Make price have more of an impact on demand
        //Show profit only, not revenue
        //--------------------------------------------

        public Player player1;
        public int Duration;        
        public int Demand;
        public Day day;
        public List<Day> Days;
        public Store store;

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
            do
            {
                UserInterface.DisplayDurationMenu();
                UserInterface.StringInput = Console.ReadLine();
            } while (!int.TryParse(UserInterface.StringInput, out UserInterface.BadInput));
            Duration = int.Parse(UserInterface.StringInput);
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
                //See notes in Customer class
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
                player1.SetRecipe();
                GetWeather();
                day.GetDailySales(GetDemand(), player1);
                GetAdjustedSales();
                player1.inventory.UpdateInventory(player1, day);
                UserInterface.DisplayDayEndReport(day.weather.WeatherForcast, day.weather.Temperature, day.CupsSold, day.Profit, player1.PricePerCup);
                do
                {
                    UserInterface.DisplayReadyForNextDay();
                    UserInterface.StringInput = Console.ReadLine();
                } while (!UserInterface.InputValidation(UserInterface.StringInput, "yesNo"));                                
            }
            GameOver();
        }

        public void GetAdjustedSales()
        {
            if (player1.TotalCupsMade < day.CupsSold)
            {
                day.CupsSold = player1.TotalCupsMade;
                day.Revenue = day.CupsSold * player1.PricePerCup;
                player1.inventory.Money += day.Revenue;
                day.Costs = store.TotalCost;
                day.Profit = day.Revenue - day.Costs;
            }
            else
            {
                day.Revenue = day.CupsSold * player1.PricePerCup;
                player1.inventory.Money += day.Revenue;
                day.Costs = store.TotalCost;
                day.Profit = day.Revenue - day.Costs;
            }
        }

        public void GameOver()
        {
            UserInterface.DisplayGameEndReport(Days, player1.inventory.Money);
            UserInterface.DisplayPlayAgainPrompt();
            if ("yes" == Console.ReadLine())
            {
                player1.inventory.Cups = 0;
                player1.inventory.Lemons = 0;
                player1.inventory.Sugar = 0;
                player1.inventory.Ice = 0;
                Days.Clear();
                RunGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}