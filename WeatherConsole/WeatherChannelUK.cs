using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather;

namespace WeatherConsole
{
    class WeatherChannelUK : IWeatherFan
    {

        public void ShowWeather(WeatherSensor sensor)
        {
            string temparatureLine = string.Format("The temperature is {0} degrees", sensor.Temperature);
            string humdityLine = string.Format("The humidity is {0}", sensor.Humidity);

            Console.WriteLine(temparatureLine);
            Console.WriteLine(humdityLine);
        }

    }
}
