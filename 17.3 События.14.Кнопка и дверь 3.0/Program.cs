namespace _17._3_События._13.Кнопка_и_дверь_3._0
{
    public class Door
    {
        private void Open(object sender, ButtonClickedEventArgs eventArgs)
        {
            Console.WriteLine($"Дверь открыта кнопкой с номером {eventArgs.Number} в комнате {eventArgs.Location}");
        }
        public void Init(Button button) 
        {
            button.ClickHandler += Open;
        }
    }
    
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
            Door doorA = new Door();
            Door doorB = new Door();
            doorA.Init(button);
            doorB.Init(button);
            button.Clicked();
        }
    }
}
