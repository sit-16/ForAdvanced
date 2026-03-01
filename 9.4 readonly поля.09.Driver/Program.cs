namespace _9._4_readonly_поля._09.Driver
{
    public class Driver
    {
        public readonly Guid Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Driver(string firstName, string lastName, int age)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
    public class Car
    {
        public string Number { get; set; }
        public string Color { get; set; }
        public Driver Driver { get; set; }
        public Car(string number, string color, Driver driver)
        {
            this.Number = number;
            this.Color = color; 
            this.Driver = driver;
        }
    }

    internal class Program
    {
        public static void Main()
        {
            //Driver driverA = new Driver("Иван", "Иванов", 34);
            //Driver driverB = new Driver("Алексей", "Алексеев", 30);
            //Car carA = new Car("A123KC", "Красный", driverA);
            //Car carB = new Car("В321EM", "Белый", driverB);
            //Console.WriteLine($"Автомобиль A: {carA.Number} {carA.Color} {carA.Driver.LastName}");

            //carA.Color = carB.Color;
            //carA.Number = carB.Number;
            //carA.Driver = carB.Driver;
            //Console.WriteLine($"Автомобиль A: {carA.Number} {carA.Color} {carA.Driver.LastName}");

            Driver driverA = new Driver("Иван", "Иванов", 34);
            Driver driverC = new Driver("Пётр", "Петров", 25);
            Car carA = new Car("A123MP", "Красный", driverA);
            Car carB = new Car("B456XC", "Синий", null);
            Car carC = new Car("K789BA", "Белый", driverC);
            Car[] cars = new Car[] { carA, carB, carC };
            CarsDrivers(cars);
        }

        public static void CarsDrivers(Car[] cars)
        {
            foreach (var car in cars)
            {
                string driverLastName = car.Driver is null ? "Нет водителя" : car.Driver.LastName;
                Console.WriteLine($"{car.Number}:{driverLastName}");
            }
        }
    }
}
