using static LLMs.DelegatesAndEvents.Delegates;

namespace LLMs.DelegatesAndEvents
{
    public class Delegates
    {
        /*
         What are Delegates in C#?
        A delegate in C# is a type-safe function pointer. 
        It allows you to pass methods as parameters, store references to methods, 
        and call them dynamically.

        2️⃣ Why Use Delegates?
        ✅ Encapsulation of methods → Store methods in variables.
        ✅ Support for callbacks → Pass a method as an argument.
        ✅ Enable event-driven programming → Used to define events in C#.
        ✅ Allow flexibility → Define a method signature, and any method that matches can be assigned to it.


         */

        // Step 1: Define a delegate type (Function Signature)
        public delegate void DisplayMessage(string message);
        public delegate void Notify(); // Define delegate

    }

    class SingleCastDelegates
    {
        // Step 2: Define a method that matches the delegate signature
        public static void Print(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        static void Main()
        {
            // Step 3: Create a delegate instance and assign a method to it
            DisplayMessage del = Print;

            // Step 4: Invoke the delegate (calls the method)
            del("Hello, Delegates!");
        }
    }

    /// <summary>
    /// A multicast delegate can store multiple methods and invoke them all.
    /// del += Method2; → Adds Method2 to the invocation list.
    /// del(); → Calls all assigned methods in order.
    /// </summary>
    class MultiCastDelegates
    {
        public static void Method1() => Console.WriteLine("Method1 executed");
        public static void Method2() => Console.WriteLine("Method2 executed");

        static void Main()
        {
            Notify del = Method1;
            del += Method2; // Adding another method

            del(); // Calls both Method1 and Method2
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class GenericDelegate
    {

        static void Main()
        {
            Action<string> printMessage = message => Console.WriteLine(message);

            printMessage("Hello Action!"); // ✅ Output: Hello Action!

            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(5, 3)); // ✅ Output: 8

            Predicate<int> isEven = num => num % 2 == 0;
            Console.WriteLine(isEven(10)); // ✅ Output: True

        }


    }
}
