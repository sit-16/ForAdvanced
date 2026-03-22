namespace SmartHome.Logic
{
    public class Conditioner
    {
        public string Cool()
        {
            return "Охлаждение запущено";
        }
    }
}
namespace SmartHome.Logic
{
    public class Thermostat
    {
        public void Start()
        {
// Создайте объект класса Conditioner с именем conditioner 
Conditioner conditioner = new Conditioner();
// Выведите результат метода Cool() в консоль
Console.WriteLine(conditioner.Cool());
        }
    }
}