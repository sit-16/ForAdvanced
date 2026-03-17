namespace _12._3_Методы_расширения._06.Стоимость_всех_продуктов
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }


        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    public static class ListExt
    {
        public static decimal GetSumCost(this List<Product> lst)
        {
            decimal summ = 0;
            foreach (var pr in lst)
            {
                summ += pr.Cost;
            }
            return summ;
        }
    }

    internal class Program
    {
        public static void Main()
        {
            List<Product> products = new List<Product>
            {
                new Product("Ноутбук", 6000),
                new Product("Мышка", 100),
                new Product("Наушники", 300),
                new Product("Клавиатура", 200)
            };

            decimal sumCost = products.GetSumCost();
            Console.WriteLine(sumCost);
        }
    }
}
