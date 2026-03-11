namespace _11._2_virtual_override._05.Даты
{
    public class BaseDate
    { 
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public BaseDate(int year, int month, int day)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public virtual string GetFormat()
        {
            return $"год:{Year}, месяц:{Month:00}, день:{Day:00}";
        }
    }

    public class AmericanDate : BaseDate
    {
        public AmericanDate(int year, int month, int day):base (year,month, day)
        {            
        }
        public override string GetFormat()
        {
            return $"{Month:00}.{Day:00}.{Year}";
        }
    }

    public class EuropeanDate : BaseDate
    {
        public EuropeanDate(int year, int month, int day) : base(year, month, day)
        {
        }
        public override string GetFormat()
        {
            return $"{Day:00}.{Month:00}.{Year}";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BaseDate date = new BaseDate(2021, 3, 24);
            AmericanDate date1 = new AmericanDate(2021, 3, 24);
            EuropeanDate date2 = new EuropeanDate(2021, 3, 24);

            List<BaseDate> dates = new List<BaseDate>
            {
                date,date1, date2
            };

            foreach (var item in dates)
            {
                Console.WriteLine(item.GetFormat());
            }
        }
    }
}
