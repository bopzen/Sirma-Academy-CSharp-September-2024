namespace _05DependencyInversionPrincipleDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISwitchable bulb = new Bulb();
            LightSwitch lightSwitch = new LightSwitch(bulb);

            lightSwitch.Operate();
            lightSwitch.Operate();

            ITemperatureSensor temperatureSensor = new TemperatureSensor();
            WeatherReporter weatherReporter = new WeatherReporter(temperatureSensor);

            weatherReporter.Report();
        }
    }
}
