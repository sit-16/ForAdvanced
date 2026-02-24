using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8._1_Моделирование_работы_школы
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

    public class School
    {
        public string Name;
        public Dictionary<int, Student> Students;

        public School(string name)
        {
            Name = name;
            Students = new Dictionary<int, Student>();
        }


        public void PrintStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine($"В школе {Name} пока нет учеников!");
            }
            else
            {
                Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -10}", "#", "Имя", "Фамилия", "Возраст");
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -10}", i, Students[i].FirstName, Students[i].LastName, Students[i].Age);
                }
            }
        }


        public void AddNewStudent(Student student)
        {
            int nextN = Students.Count; // Нумерация новых учеников автоматическая
            Students.Add(nextN, student);
            Console.WriteLine($"Студент {student.FirstName} успешно добавлен в школу {Name}.");
        }


        public bool RemoveStudent(string input)
        {
            if (!int.TryParse(input, out int num)) return false;
            if (!this.Students.ContainsKey(num)) return false;
            string lastName = Students[num].LastName;
            Students.Remove(num);
            
            int i = 0;
            var tempStudents = new Dictionary<int, Student>();
            foreach (var st in this.Students) // Перенумерация словаря, чтобы дырок не было
            {
                tempStudents.Add(i, st.Value);
                i++;
            }
            this.Students = tempStudents;
            Console.WriteLine($"Студент {lastName} успешно отчислен из школы {this.Name}.");
            return true;
        }
    }

    class Program
    {
        static bool AskUserDa()
        {
            string userAnswer = Console.ReadLine().ToLower();
            return userAnswer == "да";
        }

        static void Main()
        {
            Console.WriteLine("Здравствуйте! Введите название вашей школы");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешна создана");

            while (true)
            {
                Console.WriteLine($"Хотите посмотреть список учеников школы {school.Name}? Введите да или нет. ");
                if (AskUserDa())
                {
                    school.PrintStudents();
                }

                Console.WriteLine($"Хотите добавить нового ученика в школу {school.Name}? Введите да или нет. ");
                if (AskUserDa())
                {
                    Console.WriteLine($"Введите имя ученика");
                    string firstName = Console.ReadLine();
                    Console.WriteLine($"Введите фамилию ученика");
                    string lastName = Console.ReadLine();
                    Console.WriteLine($"Введите возраст ученика");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Student student = new Student(firstName, lastName, age);
                    school.AddNewStudent(student);
                }
                Console.WriteLine($"Хотите исключить ученика из школы {school.Name}? Введите да или нет. ");
                if (AskUserDa())
                {
                    Console.WriteLine($"Введите номер ученика");
                    while (!school.RemoveStudent(Console.ReadLine()))
                        Console.WriteLine($"Введите номер ученика");
                }
            }
        }
    }
}