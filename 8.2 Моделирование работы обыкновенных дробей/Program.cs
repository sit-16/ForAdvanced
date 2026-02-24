namespace CS_Fraction
{
    public class Fraction()
    {
        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator;
        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator;

        public Fraction(int numerator, int denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public Fraction(int numerator) : this(numerator, 1)
        { }

        public void Print()
        {
            this.Reduce();
            if (this.Denominator == 1)
                Console.WriteLine($"{this.Numerator}");
            else
                Console.WriteLine($"{this.Numerator}/{this.Denominator}");
        }

        public Fraction Sum(Fraction otherFraction)
        {
            int commonDenominator = this.Denominator * otherFraction.Denominator;
            int resultNumerator = this.Numerator * otherFraction.Denominator + otherFraction.Numerator * this.Denominator;
            return new Fraction(resultNumerator, commonDenominator);
        }

        public Fraction Diference(Fraction otherFraction)
        {
            int commonDenominator = this.Denominator * otherFraction.Denominator;
            int resultNumerator = this.Numerator * otherFraction.Denominator - otherFraction.Numerator * this.Denominator;
            return new Fraction(resultNumerator, commonDenominator);
        }


        public Fraction Multiply(Fraction otherFraction)
        {
            int commonDenominator = this.Denominator * otherFraction.Denominator;
            int resultNumerator = this.Numerator * otherFraction.Numerator;
            return new Fraction(resultNumerator, commonDenominator);
        }

        public Fraction Devide(Fraction otherFraction)
        {
            int commonDenominator = this.Denominator * otherFraction.Numerator;
            int resultNumerator = this.Numerator * otherFraction.Denominator;
            return new Fraction(resultNumerator, commonDenominator);
        }

        public Fraction Sum(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            return this.Sum(otherFraction);
        }

        public Fraction Diference(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            return this.Diference(otherFraction);
        }

        public Fraction Multiply(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            return this.Multiply(otherFraction);
        }

        public Fraction Devide(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            return this.Devide(otherFraction);
        }

        public void Reduce()
        {
            for (int i = this.Denominator; i > 1; i--)
            {
                if (this.Denominator % i == 0 && this.Numerator % i == 0)
                {
                    this.Denominator /= i;
                    this.Numerator /= i;
                    break;
                }
            }
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            var fraction1 = new Fraction(1, 2);
            fraction1.Print(); // 1/2
            var fraction2 = new Fraction(1, 3);
            fraction2.Print(); // 1/3
            var fraction3 = fraction1.Sum(fraction2);
            fraction3.Print(); // 5/6
            var fraction4 = fraction1.Diference(fraction2);
            fraction4.Print(); // 1/6
            var fraction5 = fraction1.Multiply(fraction2);
            fraction5.Print(); // 1/6
            var fraction6 = fraction1.Devide(fraction2);
            fraction6.Print(); // 3/2
            Console.WriteLine("----");
            var fraction7 = fraction1.Sum(1);
            fraction7.Print(); // 3/2
            var fraction8 = fraction1.Diference(1);
            fraction8.Print(); // -1/2
            var fraction9 = fraction1.Multiply(2);
            fraction9.Print(); // 1
            var fraction10 = fraction1.Devide(2);
            fraction10.Print(); // 1/4
            var fraction0 = new Fraction(3);
            fraction0.Print(); // 3
        }
    }
}