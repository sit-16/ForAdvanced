namespace _6._4_Моделирование_классов._08.У_столика
{
    public class Dish
    {
        public string Name;
        public double Price;
    }

    public class Order
    { 
        public List<Dish> OrderedDishes;
        public double TotalPrice;
    }

    public class Customer
    {
        public string FullName;
        public List<Order> Orders;
    }

    public class Table
    {
        public int Number;
        public List<string> Guests;
        public bool IsReserved;
        public double BillAmount;
    }

    public class Waiter
    { 
        public string Name;
        public List<Table> Tables = new List<Table>();
    }

    internal class Program
    {
        static void Main()
        {
            Table table = new Table();
            table.Number = 1;
            table.Guests = ["Гость"];
            table.IsReserved = true;
            table.BillAmount = 31.50;

            Waiter waiter = new Waiter();
            waiter.Name = "Анна";
            waiter.Tables.Add(table);


            Dish pastaCarbonara = new Dish { Name = "Паста карбонара" };
            Dish caesarSalad = new Dish { Name = "Салат «Цезарь» с курицей" };
            Dish paparatSalad = new Dish { Name = "Салат «А-ля Папарать»" };
            Dish greekSalad = new Dish { Name = "Салат «Греческий»" };

            Order order = new Order();
            order.OrderedDishes = [pastaCarbonara, caesarSalad, paparatSalad, greekSalad];
            order.TotalPrice = 70.0;

            Customer customer = new Customer();
            customer.FullName = "Гость";
            customer.Orders = [order];
        }
    }
}
