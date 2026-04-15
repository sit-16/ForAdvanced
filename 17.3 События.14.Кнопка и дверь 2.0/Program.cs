namespace _17._3_События._13.Кнопка_и_дверь_2._0
{
    public class Button
    {
        private string identity;
        public event EventHandler<ButtonClickedEventArgs> ClickHandler;

        public Button(string identity)
        {
            this.identity = identity;
        }
        public void Clicked()
        {
            var eventArgs = new ButtonClickedEventArgs(this.identity);
            this.ClickHandler?.Invoke(this, eventArgs);
        }
    }

    public class ButtonClickedEventArgs : EventArgs
    {
        public string Location { get; }
        public int Number { get; }
        public ButtonClickedEventArgs(string identity)
        {
            string[] args = identity.Split('#');
            this.Location = args[0];
            this.Number = int.Parse(args[1]);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button("Столовая#4");
            button.ClickHandler += (object sender, ButtonClickedEventArgs e) =>
            {
                Console.WriteLine($"Нажата кнопка в локации: {e.Location}, с номером {e.Number}");
            };
            button.Clicked();
        }
    }
}
