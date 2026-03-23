using DbUser = Database.Models.User;
using ApiUser = External.Api.User;

namespace Database.Models
{
    public class User
    {
        public string GetInfo()
        {
            return "DB_Record";
        }
    }
}
namespace External.Api
{
    public class User
    {
        public string GetInfo()
        {
            return "API_Data";
        }
    }
}



namespace CSharpEssentialsв
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbUser model = new DbUser();
            ApiUser profile = new ApiUser();
            Console.WriteLine($"{model.GetInfo()} | {profile.GetInfo()}");
        }
    }
}
