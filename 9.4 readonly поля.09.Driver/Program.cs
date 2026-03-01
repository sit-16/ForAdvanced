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
    public class Client
    {
        public readonly Guid Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string CardNumber { get; set; }

        public Client(string firstName, string lastName, int age, string cardNumber)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            CardNumber = cardNumber;
        }
    }

    public class Order
    {
        public Car Car { get; set; }
        public Client Client { get; set; }
        public decimal Price { get; set; }
        public Order(Client client, decimal price, Car car):this(client, price)
        {
            this.Car = car;
        }
        public Order(Client client, decimal price)
        {
            this.Client = client;
            this.Price = price;
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

            //Driver driverA = new Driver("Иван", "Иванов", 34);
            //Driver driverC = new Driver("Пётр", "Петров", 25);
            //Car carA = new Car("A123MP", "Красный", driverA);
            //Car carB = new Car("B456XC", "Синий", null);
            //Car carC = new Car("K789BA", "Белый", driverC);
            //Car[] cars = new Car[] { carA, carB, carC };
            //CarsDrivers(cars);

            //Car carA = new Car("O123MP", "Красный", null);
            //Car carB = new Car("M456XC", "Синий", null);
            //Car carC = new Car("K789BA", "Белый", null);
            //Car[] cars = new Car[] { carA, carB, carC };
            //ChangeColor(cars);
            //for (int i = 0; i < cars.Length; ++i)
            //{
            //    Console.WriteLine($"{cars[i].Color}");
            //}
            Driver driverA = new Driver("Иван", "Иванов", 34);
            Driver driverB = new Driver("Алексей", "Алексеев", 30);
            Driver driverC = new Driver("Пётр", "Петров", 25);

            Car carA = new Car("O123MP", "Красный", driverA);
            Car carB = new Car("M456XC", "Синий", driverB);
            Car carC = new Car("K789BA", "Белый", driverC);

            Client clientA = new Client("Григорий", "Григорьев", 21, "1234123412341234");
            Client clientB = new Client("Семён", "Семёнов", 45, "1111222233334444");
            Client clientC = new Client("Владимир", "Владимиров", 29, "5678567856785678");

            Order orderA = new Order(clientA, 200, carA);
            Order orderB = new Order(clientB, 150);
            Order orderC = new Order(clientC, 500, carC);

            orderC.Car = carB;
            orderC.Client = clientA;
            orderC.Price = 300;

            string carNumber = orderA.Car == null ? "Нет машины" : orderA.Car.Number;
            Console.WriteLine($"Заказ A: {orderA.Client.LastName} {orderA.Price} {carNumber}");


            carNumber = orderB.Car == null ? "Нет машины" : orderB.Car.Number;
            Console.WriteLine($"Заказ B: {orderB.Client.LastName} {orderB.Price} {carNumber}");


            carNumber = orderC.Car == null ? "Нет машины" : orderC.Car.Number;
            Console.WriteLine($"Заказ C: {orderC.Client.LastName} {orderC.Price} {carNumber}");
        }

        public static void CarsDrivers(Car[] cars)
        {
            foreach (var car in cars)
            {
                string driverLastName = car.Driver is null ? "Нет водителя" : car.Driver.LastName;
                Console.WriteLine($"{car.Number}:{driverLastName}");
            }
        }
        public static void ChangeColor(Car[] cars)
        {

            foreach (var car in cars)
            {
                car.Color = GetColor(car.Number[0]);
            }
        }
        private static string GetColor(char c)
        {
            string color = "";
            switch (char.ToLower(c))
            {
                case 'o': color = "Оранжевый"; break;
                case 'c': color = "Синий"; break;
                case 'k': color = "Красный"; break;
                default: color = "Белый"; break;
            }
            return color;
        }
    }
}
