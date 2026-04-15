namespace _17._3_События._13.Кнопка_и_дверь_1._0
{
    public class Button
    {
        private string identity;

        public Button(string identity)
        {
            this.identity = identity;
        }
    }

    public class ButtonClickedEventArgs : EventArgs
    { 
        public string Location { get; }
        public int Number { get; }
        public ButtonClickedEventArgs(string arg)
        {
            string[] args = arg.Split('#');
            this.Location = args[0];
            this.Number = int.Parse(args[1]);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ButtonClickedEventArgs buttonClickedEventArgs = new ButtonClickedEventArgs("Подвал#4");
            Console.WriteLine($"Название комнаты: {buttonClickedEventArgs.Location}");
            Console.WriteLine($"Номер кнопки: {buttonClickedEventArgs.Number}");
        }
    }
}
