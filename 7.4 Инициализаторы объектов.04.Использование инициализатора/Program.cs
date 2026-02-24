namespace _7._4_Инициализаторы_объектов._04.Использование_инициализатора
{
    public class Phone
    {
        public string Name; // название
        public int Price; // цена в рублях
        public int Memory; // объем памяти в ГБ
        public bool IsAvailable; // доступна или нет
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Phone myPhone = new Phone()
            {
                Name = "iPhone 12 mini", // название
                Price = 70000, // цена в рублях
                Memory = 128, // объем памяти в ГБ
                IsAvailable = true // доступна или нет 
            };
        }
    }
}
