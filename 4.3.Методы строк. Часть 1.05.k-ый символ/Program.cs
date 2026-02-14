// 4.3.Методы строк. Часть 1.05.k-ый символ
string st = Console.ReadLine(); // 0123
int n = Convert.ToInt32(Console.ReadLine()); // 1
Console.WriteLine(st.Remove(--n, 1)); // 123
//Console.WriteLine(st.Remove(n, 1)); // 023 
//Console.WriteLine(st.Remove(n--, 1)); // 023
