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
            Driver driver = new Driver("Иван0", "Иванов0", 34);
            Console.WriteLine($"Новый водитель: {driver.FirstName} {driver.LastName}, возраст: {driver.Age}");

            driver.FirstName = "Иван1";
            driver.LastName = "Иванов1";
            driver.Age = 30;
            Console.WriteLine($"Новый водитель: {driver.FirstName} {driver.LastName}, возраст: {driver.Age}");
        }
    }
}
