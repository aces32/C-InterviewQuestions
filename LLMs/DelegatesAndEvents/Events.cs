namespace LLMs.DelegatesAndEvents
{
    internal class Events
    {
        /*
         An event is a specialized delegate used for event-driven programming.
         💡 Events provide a way to notify subscribers when something happens.
         */

        public class Button
        {
            // Step 1: Define an event using a delegate
            public event Action OnClick;

            public void Click()
            {
                Console.WriteLine("Button Clicked!");
                OnClick?.Invoke(); // Invoke the event if there are subscribers
            }
        }

        /// <summary>
        /// public event Action OnClick; → Defines an event using Action delegate.
        /// btn.OnClick += ShowMessage; → Subscribes ShowMessage to the event.
        /// OnClick?.Invoke(); → Calls all subscribed event handlers.
        /// </summary>
        class Program
        {
            static void ShowMessage() => Console.WriteLine("Event Handler Executed!");

            static void Main()
            {
                Button btn = new Button();
                btn.OnClick += ShowMessage; // Subscribe to the event

                btn.Click(); // Triggers the event
            }
        }

    }
    public class Logger
    {
        public event Action<string> LogEvent; // Define event

        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
            LogEvent?.Invoke(message); // Notify subscribers
        }
    }

    class Program
    {
        static void LogToFile(string message) => System.IO.File.AppendAllText("log.txt", message + "\n");
        static void LogToConsole(string message) => Console.WriteLine("Console Log: " + message);

        static void Main()
        {
            Logger logger = new Logger();

            // Subscribe event handlers
            logger.LogEvent += LogToConsole;
            logger.LogEvent += LogToFile;

            logger.Log("Application Started"); // Triggers event
        }
    }
}
