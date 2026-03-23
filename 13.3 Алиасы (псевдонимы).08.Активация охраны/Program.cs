using SecuritySensor = Global.Security.Devices.Sensor;
using Printer = System.Console;


namespace Global.Security.Devices
{ 
    public class Sensor
    {
        public string GetStatus()
        {
            return "Охрана включена";
        }
    }
}

namespace CSharpEssentials
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SecuritySensor sensor = new SecuritySensor();
            Printer.WriteLine(sensor.GetStatus());
        }
    }
}
