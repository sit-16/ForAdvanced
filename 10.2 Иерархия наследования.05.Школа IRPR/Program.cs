using static _10._2_Иерархия_наследования._05.Школа_IRPR.Program;

namespace _10._2_Иерархия_наследования._05.Школа_IRPR
{
    internal class Program
    {
        public class User
        {
            public void Solve(int n) { }
        }

        public class Student : User
        { }

        public class Teacher: User
        {
            public void CheckSolution(User user, int n) { }
        }

        public class Admin : User 
        {
            public void Edit(int n) { }
        }

        public class SuperAdmin : Admin
        { 
            public void Grant(User user){ }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
