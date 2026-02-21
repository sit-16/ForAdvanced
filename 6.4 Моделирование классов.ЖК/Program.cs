namespace _6._4_Моделирование_классов.ЖК
{
    internal class Program
    {
        public class ResidentialComplex
        {
            public string City;
            public string Name;
            public List<House> Houses;

        }
        public class House
        {
            public string Address;
            public int Floors;
            public List<string> Entrances;
        }


        static void Main(string[] args)
        {
            ResidentialComplex complex = new ResidentialComplex();

            complex.City = "Минск";
            complex.Name = "Минск Мир";

            complex.Houses = new List<House>();

            House houseFour = new House();
            houseFour.Address = "Уборевича 4, 220022";
            houseFour.Floors = 10;
            houseFour.Entrances = ["1 подъезд", "2 подъезд"];
            complex.Houses.Add(houseFour);

            House houseNine = new House();
            houseNine.Address = "Белградская 9, 220020";
            houseNine.Floors = 10;
            houseNine.Entrances = ["1 подъезд", "2 подъезд"];
            complex.Houses.Add(houseNine);

            House houseEleven = new House();
            houseEleven.Address = "Белградская 11, 220020";
            houseEleven.Floors = 10;
            houseEleven.Entrances = ["1 подъезд"];
            complex.Houses.Add(houseEleven);
        }
    }
}
