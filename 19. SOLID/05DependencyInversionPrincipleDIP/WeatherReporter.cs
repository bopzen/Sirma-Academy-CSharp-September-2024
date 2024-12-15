using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public class WeatherReporter
    {
        private readonly ITemperatureSensor _temperatureSensor;
        public WeatherReporter(ITemperatureSensor temperatureSensor)
        {
            _temperatureSensor = temperatureSensor;
        }

        public void Report()
        {
            Console.WriteLine($"Temperature is: {_temperatureSensor.GetTemperature()}");
        }

    }
}
