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
        Random random;
        public List<string> weeksForcast;

        public Weather()
        {
            random = new Random();
            weeksForcast = new List<string>();
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

        private string GetRandomConditions()
        {
            RandomWeather = random.Next(1, 5);

            switch (RandomWeather)
            {
                case 1:
                    return "sunny";
                case 2:
                    return "partly cloudy";
                case 3:
                    return "cloudy";
                case 4:
                    return "rainy";
                default:
                    return "sunny";
            }
        }

        public void GetTemperature()
        {
            Temperature = random.Next(70, 101);
        }

        public void GetWeeksForcast()
        {
            for (int i = 0; i < 7; i++)
            {
                GetTemperature();                
                weeksForcast.Add("Day " + (i+1) + ": " + Temperature.ToString() + " degrees, and " + GetRandomConditions());
            }
            
        }
    }
}