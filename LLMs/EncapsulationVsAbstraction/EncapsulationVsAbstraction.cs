namespace LLMs.EncapsulationVsAbstraction
{
    internal class EncapsulationVsAbstraction
    {
        /*
         Feature	 Encapsulation	Abstraction
        Definition |	Hiding the data (variables) and restricting direct access|	Hiding the implementation details and showing only the necessary functionality
        Purpose	   |Protects data and ensures controlled access                  | Simplifies code by exposing only essential details
        How It Works?|	Uses private fields and public methods (getters/setters) |	Uses abstract classes and interfaces
        Focus	|     How data is hidden	                                             | What functionalities are exposed
        Example	 |Data hiding using access modifiers (private, public, etc.)	| Hiding implementation details using abstract classes or interfaces


        What is Encapsulation?
        Encapsulation means restricting access to certain details of an object and only exposing the necessary parts.
        It prevents direct modification of data, ensuring data integrity and security.

        What is Abstraction?
        Abstraction means hiding implementation details and exposing only the necessary parts.
        It helps in reducing complexity by focusing on what an object does rather than how it does it.

        🎯 When to Use Encapsulation vs. Abstraction?
            Use Encapsulation when you want to protect and control access to data (e.g., using private fields and getter methods).
            Use Abstraction when you want to simplify complex systems by only exposing necessary functionalities (e.g., using abstract classes or interfaces

        Benefits of Encapsulation	What It Means
        1️⃣ Data Protection	Prevents accidental modification of important data.
        2️⃣ Controlled Access	Allows modification through controlled methods (getters/setters).
        3️⃣ Maintainability	Makes the code easier to update without affecting other parts of the system.
        4️⃣ Security	Prevents unauthorized access to private data.
        5️⃣ Better Debugging	Helps isolate and fix bugs more efficiently.

         Should You Make Everything Public?
            🚨 No! Even for small applications, making everything public is a bad practice because:
            ✅ It reduces bugs by preventing unintended modifications.
            ✅ It improves security by hiding sensitive data.
            ✅ It makes the code easier to maintain and debug as it grows.
            ✅ It ensures controlled access to class members, making the application more reliable.
         */

        class BankAccount
        {
            private double balance; // Private field (data hiding)

            public void Deposit(double amount)
            {
                if (amount > 0)
                    balance += amount;
            }

            public double GetBalance()
            {
                return balance; // Controlled access to private data
            }
        }

        class Program
        {
            static void Main()
            {
                BankAccount account = new BankAccount();
                account.Deposit(500);
                Console.WriteLine("Balance: " + account.GetBalance()); // ✅ Allowed
                                                                       // account.balance = 1000; ❌ ERROR: balance is private
            }
        }

        abstract class Animal
        {
            public abstract void MakeSound(); // Abstract method (no implementation)
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark! Bark!");
            }
        }

        class Program2
        {
            static void Main()
            {
                Animal myDog = new Dog();
                myDog.MakeSound(); // ✅ Calls the overridden method
            }
        }


    }
}
