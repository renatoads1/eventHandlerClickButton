using System;
using System.Threading;

namespace eventHandlerClickButton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press a to simulate a button");
            var key = Console.ReadLine();
            if (key=="a")
            {
                KeyPressed();
            }
        }
        static void KeyPressed() {
            Button button = new Button();
            button.ClickEvent += (a, args) =>
            {
                Console.WriteLine($"botão clicado!!!!{args.Name}");
                
            };
            button.OnClick();

        }

    }
    public class Button {

        public EventHandler<MyCustomArguments> ClickEvent;
        public void OnClick() {

            MyCustomArguments arg = new MyCustomArguments();
            arg.Name = "Julia";
            ClickEvent.Invoke(this, arg);
        }
    }

    public class MyCustomArguments : EventArgs {

        public string Name { get; set; }
    }
}
