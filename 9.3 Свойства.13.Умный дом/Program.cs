namespace _9._3_Свойства._13.Умный_дом
{
    public class SmartHome
    {
        public int Temperature { get; private set; }
        public bool IsSecuritySystemArmed { get; private set; }
        public bool IsLightsOn { get; private set; }

        public SmartHome(int temp, bool ssys, bool light)
        {
            SetTemperature(temp);
            IsLightsOn = light;
            IsSecuritySystemArmed = ssys;
        }
        public void SetTemperature(int temp)
        {
            Temperature = temp >= 15 && temp <= 30 ? temp : 23;
        }
        public void ToggleLights()
        {
            IsLightsOn = !IsLightsOn;
        }
        public void ArmSecuritySystem()
        {
            IsSecuritySystemArmed = !IsSecuritySystemArmed;
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHome smartHome = new SmartHome(24, true, false);
            Console.WriteLine(smartHome.Temperature);
            smartHome.SetTemperature(11);
            Console.WriteLine(smartHome.Temperature);
            smartHome.ArmSecuritySystem();
            Console.WriteLine(smartHome.IsSecuritySystemArmed);
            Console.WriteLine(smartHome.IsLightsOn);
        }
    }
}
