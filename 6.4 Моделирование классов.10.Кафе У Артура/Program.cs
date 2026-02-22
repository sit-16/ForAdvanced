namespace _6._4_Моделирование_классов._10.Кафе_У_Артура
{
    internal class Program
    {
        public class Cafe
        {
            public string Name;
            public Director Director;
        }
        public class Director
        { 
            public string Name;
            public List<Manager> Managers;
            public List<Department> Departments;
        }

        public class Manager
        {
            public string Name;
            public Department Department;
        }
        public class Department
        {
            public string Name;
            public List<Employee> Staff;
        }

        public class Employee
        {
            public string FullName;
            public string Position;
        }


        static void Main(string[] args)
        {
            Cafe cafe = new Cafe();
            cafe.Name = "У Артура";

            Director director = new Director();
            director.Name = "Юрко В. В.";
            director.Departments = new List<Department>();
            director.Managers = new List<Manager>();
            cafe.Director = director;

            Department department = new Department();
            department.Name = "Коммерческий отдел";
            department.Staff = new List<Employee>();
            director.Departments.Add(department);

            Manager manager = new Manager();
            manager.Name = "Коршун А. С.";
            manager.Department = department;
            director.Managers.Add(manager);

            Employee admin = new Employee();
            admin.FullName = "Котько П. Д.";
            admin.Position = "Администратор";
            department.Staff.Add(admin);

            Console.WriteLine($"Кафе \"{cafe.Name}\"");
            Console.WriteLine($"Директор: {director.Name}");
            Console.WriteLine($"Менеджер: {manager.Name}");
            Console.WriteLine($"Подразделение: \"{department.Name}\"");
            Console.WriteLine($"{admin.Position}: {admin.FullName}");
        }
    }
}
