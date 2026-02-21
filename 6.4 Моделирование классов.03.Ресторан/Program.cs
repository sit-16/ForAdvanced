namespace _6._4_Моделирование_классов._03.Ресторан
{
    public class Dish
    {
        public string Name;
        public double Price;
    }

    public class Restaurant
    {
        public List<Dish> Dishes;
        public List<string> Waiters;
    }


    internal class Program
    {
        static void Main()
        {
            Dish salmonTartar = new Dish();
            salmonTartar.Name = "Тартар из лосося";
            salmonTartar.Price = 15.5;

            Dish beefCarpaccio = new Dish();
            beefCarpaccio.Name = "Карпаччо из говядины";
            beefCarpaccio.Price = 18.0;

            Dish beefTongue = new Dish();
            beefTongue.Name = "Язык с хреном";
            beefTongue.Price = 12.5;

            Dish winePlate = new Dish();
            winePlate.Name = "Винная тарелка";
            winePlate.Price = 22.0;


            Restaurant restaurant = new Restaurant();
            restaurant.Dishes = [salmonTartar, beefCarpaccio, beefTongue, winePlate];

            restaurant.Waiters = ["Валерия"];

            foreach (var dish in restaurant.Dishes)
            {
                Console.WriteLine($"{dish.Name} — {dish.Price} р.");
            }

            foreach (var waiter in restaurant.Waiters)
            {
                Console.WriteLine($"Официант: {waiter}");
            }
        }

    }
}
