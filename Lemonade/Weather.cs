using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Weather
    {
        private int Temperature;
        private int Forcast;
        public string WeatherForcast;
        Random random = new Random();


        public void GetFutureForcast()
        {
            throw new System.NotImplementedException();
        }

        public string GetTodaysForcast()
        {
            int RandomWeather = random.Next(1, 5);

            switch (RandomWeather)
            {
                case 1:
                    WeatherForcast = "sunny";
                    break;
                case 2:
                    WeatherForcast = "partly cloudy";
                    break;
                case 3:
                    WeatherForcast = "cloudy";
                    break;
                case 4:
                    WeatherForcast = "rainy";
                    break;
                default:
                    break;
            }
            Temperature = random.Next(1, 100);
            return WeatherForcast;
        }

        public void GetTemperature()
        {
            throw new System.NotImplementedException();
        }
    }
}