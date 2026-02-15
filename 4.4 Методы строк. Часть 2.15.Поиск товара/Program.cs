namespace _4._4_Методы_строк._Часть_2._15.Поиск_товара //4.4 Методы строк. Часть 2.15.Поиск товара
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Apple", "Banana", "apple" };
            FindIndexesOfProducts(value: "apple", list: list);
            FindIndexesOfProducts(value: "apple", list: list, ignoreRegister: true);
        }
        
        
        static void FindIndexesOfProducts(string value, List<string> list, bool ignoreRegister = false)
        {
            var result = new List<int>();
            if (ignoreRegister) value = value.ToLower();
                for (int i = 0; i < list.Count; i++)
                {
                    string test = list[i];
                    if (ignoreRegister) test = test.ToLower();    
                    if (test == value) result.Add(i);
            }
                Console.WriteLine(string.Join(", ", result));
        }

    }
}
