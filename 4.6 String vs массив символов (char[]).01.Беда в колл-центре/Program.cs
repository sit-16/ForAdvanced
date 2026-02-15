// 4.6 String vs массив символов (char[]).01.Беда в колл-центре
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string st = Console.ReadLine();
    char[] chArray = st.ToCharArray();
    for (int j = 0; j < chArray.Length; j++) 
        if (!char.IsDigit(chArray[j])) st = st.Replace(chArray[j].ToString(), string.Empty);
    st = $"{st[0]}-{st[1..4]}-{st[4..7]}-{st[7..9]}-{st[9..11]}";
    Console.WriteLine(st);
}
