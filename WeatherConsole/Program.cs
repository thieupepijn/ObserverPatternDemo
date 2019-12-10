using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather;

namespace WeatherConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            WeatherSensor sensor = new WeatherSensor();
            IWeatherFan dutchFan = new WeatherNewsChanelHolland();
            IWeatherFan ukFan = new WeatherChannelUK();

            sensor.AddFan(dutchFan);
            sensor.AddFan(ukFan);

            for(int counter=0; counter<10; counter++)
            {
                sensor.NewReading();
                Console.WriteLine();
                System.Threading.Thread.Sleep(3000);

            }

           

            Console.ReadKey();


        }

        

    }
}
