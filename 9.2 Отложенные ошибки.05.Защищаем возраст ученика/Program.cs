namespace sit16.ProtectStudentAge
{
    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            SetName(name);
            SetAge(age);
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            if (value.Length <= 1)
            {
                throw new Exception("Имя должно состоять как минимум из 2 букв.");
            }

            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    throw new Exception("Имя должно состоять только букв.");
                }
            }

            name = value;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            if (age < 16) throw new Exception(@"//ошибка, так как некорректный возраст");
            if (age < this.age) throw new Exception(@"//ошибка, так как меньше предыдущего возраста");
            this.age = age;
        }
    }
}
