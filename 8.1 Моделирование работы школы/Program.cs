using System;
using System.Collections.Generic;

namespace _8._1_Моделирование_работы_школы
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class School
    {
        public string Name;
        public List<Student> Students;

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void PrintStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine($"В школе {Name} пока нет учеников!");
            }
            else
            {
                Console.WriteLine("{0, -10} {1, -10}", "Имя", "Фамилия");
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine("{0, -10} {1, -10}", Students[i].FirstName, Students[i].LastName);
                }
            }
        }

        public void AddNewStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"Студент {student.FirstName} успешно добавлен в школу {Name}.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте! Введите название вашей школы");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешна создана");

            while (true)
            {
                Console.WriteLine($"Хотите посмотреть список учеников школы {school.Name}? Введите да или нет. ");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "да")
                {
                    school.PrintStudents();
                }

                Console.WriteLine($"Хотите добавить нового ученика в школу {school.Name}? Введите да или нет. ");
                userAnswer = Console.ReadLine();
                if (userAnswer == "да")
                {
                    Console.WriteLine($"Введите имя ученика");
                    string firstName = Console.ReadLine();
                    Console.WriteLine($"Введите фамилию ученика");
                    string lastName = Console.ReadLine();

                    Student student = new Student(firstName, lastName);
                    school.AddNewStudent(student);
                }
            }
        }
    }
}
