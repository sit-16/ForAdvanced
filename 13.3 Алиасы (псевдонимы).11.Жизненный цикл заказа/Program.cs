// 1. Создай алиас OrderStatus для вложенного типа
using OrderStatus = Store.Logic.Order.Status;
// 2. Добавь статический импорт для этого же типа
using static Store.Logic.Order.Status;

namespace Store.Logic
{
    public class Order
    {
        public class Status
        {
            private string _name;

            private Status(string name)
            {
                _name = name;
            }

            public static readonly Status Created = new Status("Created");
            public static readonly Status Processing = new Status("Processing");
            public static readonly Status Shipped = new Status("Shipped");
            public static readonly Status Delivered = new Status("Delivered");


            public override string ToString()
            {
                return _name;
            }
        }
    }
}

namespace StoreApp
{
    class Program
    {
        static void Main()
        {
            // Если алиас и импорт настроены верно, код ниже заработает
            OrderStatus current = Shipped;

            if (current == Shipped)
            {
                Console.WriteLine(current);
            }
        }
    }
}
