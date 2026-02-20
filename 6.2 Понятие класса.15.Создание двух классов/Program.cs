namespace _6._2_Понятие_класса._15.Создание_двух_классов
{
    public class GeoLocation
    {
        public double Latitude;
        public double Longitude;
    }

    public class City
    {
        public string Name;
        public GeoLocation Location;
    }

        
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();

            city.Name = "Vladikavkaz";

            GeoLocation location = new GeoLocation();

            location.Latitude = 43.0348;
            location.Longitude = 44.6798;

            city.Location = location;

            Console.WriteLine($"I love {city.Name} located at ({city.Location.Longitude}, {city.Location.Latitude})");
        }
    }
}
