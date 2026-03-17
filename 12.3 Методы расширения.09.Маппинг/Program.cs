namespace _12._3_Методы_расширения._09.Маппинг
{
    public static class Converter
    {
        public static ProductViewModel ToProductViewModel(this ProductDb pdb)
        {
            ProductViewModel prod = new ProductViewModel()
            {
                Id = pdb.Id,
                Cost = pdb.Cost,
                Name = pdb.Name
            };
            return prod;
        }
    }
    public class ProductDb
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }
    }

    public class ProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }
    }

    internal class Program
    {
        public static void Main()
        {
            var productDb = new ProductDb()
            {
                Id = Guid.NewGuid(),
                Name = "Молоко",
                Cost = 120,
                Description = "Натуральное молоко из деревни",
                ImagePath = "https://lenta.gcdn.co/globalassets/1/-/10/20/65/346818_2.png?preset=fulllossywhite"
            };

            ProductViewModel productViewModel = productDb.ToProductViewModel();

            Console.WriteLine(productViewModel.Name);
            Console.WriteLine(productViewModel.Cost);
        }
    }
}
