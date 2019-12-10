using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class WeatherSensor
    {
        private Random _random = new Random();
        private List<IWeatherFan> _weatherFans;

        public int Temperature { get; private set; }
        public int Humidity { get; private set; }

        public WeatherSensor()
        {
            _weatherFans = new List<IWeatherFan>();
        }

        private void GetTemperature()
        {
            Temperature = _random.Next(-5, 40);
        }

        private void GetHumidity()
        {
              Humidity = _random.Next(10, 100);
        }

        public void NewReading()
        {
            GetTemperature();
            GetHumidity();
            _weatherFans.ForEach(f => f.ShowWeather(this));
        }

        public void AddFan(IWeatherFan fan)
        {
            _weatherFans.Add(fan);
        }

        public void RemoveFan(IWeatherFan fan)
        {
            _weatherFans.Remove(fan);
        }
    }
}
