namespace _04InterfaceSegregationPrincipleISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartLight smartLight = new SmartLight();
            SmartThermostat smartThermostat = new SmartThermostat();
            smartLight.TurnOn();
            smartLight.TurnOff();
            smartThermostat.TurnOn();
            smartThermostat.TurnOff();
            smartThermostat.SetTemperature(25);
        }
    }
}
