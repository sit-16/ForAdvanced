namespace _17._2_Action__Func__lambda._08.Сортировка_товаров
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public string Category;

        public Product(string name, decimal cost, string category)
        {
            Name = name;
            Price = cost;
            Category = category;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product("product1", 10, "furniture"),
                new Product("product2", 100, "toy"),
                new Product("product3", 1000, "toy"),
                new Product("product4", 10000, "toy"),
                new Product("product5", 100000, "furniture")
            };

            SelectAndChangePrice(products, "toy", 10, SelectCategory, IncreasePrice);
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name}, категория: {item.Category}, цена: {(int)item.Price}");
            }
        }

        static void SelectAndChangePrice(List<Product> products,
                                         string category,
                                         int percent,
                                         Func<Product, string, bool> isRelevant,
                                         Action<Product, int> performAction)
        {
            foreach (var p in products)
                if (isRelevant(p, category)) performAction(p, percent);
        }
        static void IncreasePrice(Product p, int n) => p.Price += p.Price * n / 100;
        static bool SelectCategory(Product p, string category) => p.Category == category;

    }
}
