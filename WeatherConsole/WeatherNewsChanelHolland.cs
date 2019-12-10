using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather;

namespace WeatherConsole
{
    class WeatherNewsChanelHolland : IWeatherFan
    {
        public void ShowWeather(WeatherSensor sensor)
        {
            string temparatureLine = string.Format("De temperatuur is {0} graden", sensor.Temperature);
            string humidityLine = string.Format("De vochtigheid is {0}", sensor.Humidity);

            Console.WriteLine(temparatureLine);
            Console.WriteLine(humidityLine);
        }
    }
}
