using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs.StructClassRecords
{
    internal class StructClassRecords
    {
        /// <summary>
        /// Stored in the stack (faster access) i.e Value Type.
        /// Copied by value (modifications don’t affect the original).
        /// No inheritance (but can implement interfaces).
        /// Use for small, lightweight objects.
        /// </summary>
        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        /*
         * ✔ Small objects (e.g., coordinates, colors, timestamps).
           ✔ When performance is critical (avoids heap allocation).
           ❌ Avoid for large objects (copying becomes expensive).
         */

        class ProgramStruct
        {
            static void Main()
            {
                Point p1 = new Point { X = 10, Y = 20 };
                Point p2 = p1; // Copy by value (new copy created)

                p2.X = 50;
                Console.WriteLine(p1.X); // Output: 10 (original is unchanged)
            }
        }

        /// <summary>
        /// Stored in the heap (accessed via reference).
        /// Copied by reference (modifications affect all references).
        /// Supports inheritance, polymorphism, and encapsulation.
        /// </summary>
        class Car
        {
            public string Brand { get; set; }
        }

        /*
         * ✔ Complex objects with behavior (e.g., models, services).
           ✔ When inheritance and polymorphism are required.
           ❌ Avoid for small immutable data (use record instead).
         */

        class ProgramClass
        {
            static void Main()
            {
                Car car1 = new Car { Brand = "Toyota" };
                Car car2 = car1; // Copy by reference (both point to the same object)

                car2.Brand = "Honda";
                Console.WriteLine(car1.Brand); // Output: Honda (modifies original)
            }
        }

        /// <summary>
        /// Stored in the heap (like class).
        /// Immutable by default (values don’t change after creation).
        /// Copy-by-value-like behavior (uses with keyword to create modified copies).
        /// Best for immutable data models (e.g., DTOs, API responses).
        /// </summary>
        record Person(string Name, int Age);
        /*
         * 📌 When to Use record
            ✔ Immutable data (DTOs, API responses, configurations).
            ✔ Comparisons based on values (not references).
            ✔ Functional programming patterns
         */

        class ProgramRecords
        {
            static void Main()
            {
                Person p1 = new Person("Alice", 25);
                Person p2 = p1 with { Age = 30 }; // Creates a new copy with modified Age

                Console.WriteLine(p1.Age); // Output: 25 (original unchanged)
                Console.WriteLine(p2.Age); // Output: 30 (new copy)
            }
        }


    }
}
