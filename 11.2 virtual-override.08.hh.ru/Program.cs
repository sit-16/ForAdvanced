namespace _11._2_virtual_override._08.hh.ru
{
    public class Profile
    {
        public string Job { get; set; }
        public Profile(string job)
        {
            Job = job;
        }
        protected virtual string GetInfo()
        {
            return string.Empty;
        }
        public void Describe()
        {
            Console.WriteLine($"{this.Job}, {this.GetInfo()}");
        }
    }

    public class Vacancy : Profile
    {
        /// <summary>
        /// Зарплата
        /// </summary>
        public decimal Salary { get; set; }
        public Vacancy(string job, decimal salary) : base(job)
        {
            Salary = salary;
        }
        protected override string GetInfo()
        {
            return $"Предлагаемая зарплата: {this.Salary}";
        }
    }

    public class Resume : Profile
    {
        /// <summary>
        /// Стаж
        /// </summary>
        public decimal Experience { get; set; }
        public Resume(string job, int experience) : base(job)
        {
            Experience = experience;
        }
        protected override string GetInfo()
        {
            return $"Стаж работы: {this.Experience}";
        }
    }


    internal class Program
    {
        static void Main()
        {
            List<Profile> profiles = new List<Profile>() 
            {
                new Vacancy("C# разработчик", 100000),
                new Vacancy("Python разработчик", 90000),
                new Vacancy("C++ разработчик", 110000),
                new Resume("C# разработчик", 4),
                new Resume("C++ разработчик", 1)
            };

            foreach (var profile in profiles)
            {
                profile.Describe();
            }

        }
    }
}
