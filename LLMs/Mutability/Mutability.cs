using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs.Mutability
{
    public class Mutability
    {
        /*
         Mutability vs. Immutability in C# – Explained Like You're Five
            Think of mutability and immutability like writing with a pencil vs. writing with a pen:
            
            Mutable objects 📝 → You can erase and change what you've written (modifiable).
            Immutable objects ✒️ → Once you write something, you cannot change it (read-only).

            A mutable object is one whose state (properties/fields) can be modified after it is created.

             An immutable object is one whose state cannot be changed after it is created.
            Once an instance is created, its fields/properties cannot be modified.

            
         */

        public void CarMutable()
        {
            // Usage
            InternalCar car = new InternalCar { Model = "Toyota", Speed = 50 };
            car.Speed = 60;  // ✅ Allowed (modifies existing object)
            car.Accelerate(); // ✅ Allowed (modifies existing object)
        }


        public void CarImmutable()
        {
            // Usage
            var car = new CarImmutable("Tesla", 80);

            // ❌ Compilation Error: Properties cannot be modified
            // car.Speed = 100; 
            // car.Model = "BMW";
        }

    }

    public sealed class CarImmutable
    {
        public string Model { get; }  // Read-only after assignment
        public int Speed { get; }

        public CarImmutable(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
    }



    public class InternalCar
    {
        public string? Model { get; set; }  // Can be changed after object creation
        public int Speed { get; set; }

        public void Accelerate()
        {
            Speed += 10; // Changing the state of the object
        }
    }

}
