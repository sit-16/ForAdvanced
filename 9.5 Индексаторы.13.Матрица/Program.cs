namespace _9._5_Индексаторы._13.Матрица
{
    internal class Program
    {
        public class Matrix
        {
            private int[,] numbers;
            public Matrix()
            {
                numbers = new int[,] {
                    { 1, 2, 4 },
                    { 2, 3, 6 },
                    { 3, 4, 8 }
                };
            }

            public int this[int i, int j]
            {
                get 
                { 
                    return numbers[i,j]; 
                }
                set { numbers[i, j] = value; }
            }
        }

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Console.WriteLine(matrix[0, 1]);
            matrix[0, 1] = 32;
            Console.WriteLine(matrix[0, 1]);
        }
    }
}
