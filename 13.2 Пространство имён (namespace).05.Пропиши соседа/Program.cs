namespace OnlineShop.Web
{
    // класс модели относящийся к работе web-приложения
    public class Order
    {
    }
}
namespace OnlineShop.Db
{
    // класс модели относящийся к работе с базой данных
    public class Order
    {
    }
}

namespace _13._2_Пространство_имён__namespace_._05.Пропиши_соседа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineShop.Web.Order webOrder = new OnlineShop.Web.Order();
            OnlineShop.Db.Order dbOrder = new OnlineShop.Db.Order();
        }
    }
}

