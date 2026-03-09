namespace _10._4_Итоговый_тест._01.Пароль_от_комнаты
{
    public class Student
    { 
        public string Password { get; set; } = "Алоомора";
        public void Spell()
        { }
    }

    public class GriffindorStudent : Student
    {
        public new string Password { get; set; } = "Грата Домум";
        public void BreakRules() 
        { }
    }

    public class SlytherinStudent : Student
    {
        public new string Password { get; set; } = "Чистая кровь";
        public void Cheat() 
        { }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Console.WriteLine(stud.Password);

            GriffindorStudent grifStud = new GriffindorStudent();
            grifStud.BreakRules();
            Console.WriteLine(grifStud.Password);
            Console.WriteLine(((Student)grifStud).Password);
        }
    }
}
