using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        public string condition;
        public int temperature;
        public List<string> weatherConditions;
        Random randomTemp = new Random();
        Random randomWeather = new Random();
        public Weather()
        {
            
            weatherConditions = new List<string>() { "Sunny", "Rainy", "Cloudy" };
            condition = weatherConditions[randomWeather.Next(0,3)];
            temperature = randomTemp.Next(70, 100);
        }

    }
}
