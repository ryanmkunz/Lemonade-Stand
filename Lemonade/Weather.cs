using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade
{
    public class Weather
    {
        public int Temperature;
        public string WeatherForcast;
        public int RandomWeather;
        Random random = new Random();

        public void GetFutureForcast()
        {
            throw new System.NotImplementedException();
        }

        public void GetTodaysForcast()
        {
            RandomWeather = random.Next(1, 5);

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
        }

        public void GetTemperature()
        {
            Temperature = random.Next(70, 101);
        }
    }
}