namespace LLMs.Access_Modifiers
{
    /// <summary>
    /// The least restrictive modifier.
    /// Can be accessed from anywhere in the project or another project if the assembly reference is added.
    /// </summary>
    public class PublicCar
    {
        public string Brand = "Toyota"; // Public: Accessible from anywhere
    }

    /// <summary>
    /// The most restrictive modifier.
    /// The variable or method is only accessible within the same class.
    /// </summary>
    class PrivateCar
    {
        private string EngineType = "V8"; // Private: Accessible only inside Car class

        public void ShowEngine()
        {
            Console.WriteLine(EngineType); // ✅ Can be accessed within the same class
        }
    }

    /// <summary>
    /// Only accessible within the class or inherited (child) classes.
    /// Used when you want to allow access only to subclasses.
    /// </summary>
    class ProtectedCar : Vehicle
    {
        public void ShowType()
        {
            Console.WriteLine(Type); // ✅ Works because it's inherited
        }
    }

    /// <summary>
    /// Members with internal can be accessed anywhere within the same project (assembly).
    /// They cannot be accessed from another project, even if a reference is added.
    /// </summary>
    internal class InternalCar
    {
        internal string Model = "Sedan"; // Internal: Accessible only within the same project
    }

    /// <summary>
    /// Combines protected and internal.
    /// Accessible inside the same project and by subclasses in other projects.
    /// </summary>
    class ProtectedInternalCar : VehicleProtectedInternal
    {
        public void ShowCategory()
        {
            Console.WriteLine(Category); // ✅ Works in child class
        }
    }

    class PrivateProtectedCar : VehiclePrivateProtected
    {
        public void ShowType()
        {
            Console.WriteLine(Type); // ✅ Works in the same project
        }
    }


    class Program
    {
        static void Main()
        {
            PublicCar myCar = new();
            Console.WriteLine(myCar.Brand); // ✅ Works fine

            PrivateCar privateCar = new();
            // Console.WriteLine(myCar.EngineType); ❌ ERROR: Cannot access private member
            privateCar.ShowEngine(); // ✅ Works because ShowEngine() is public

            ProtectedCar protectedCar = new();
            protectedCar.ShowType(); // ✅ Works because ShowType() is public
                                     // Console.WriteLine(protectedCar.Type); ❌ ERROR: Type is protected

            InternalCar InternalCar = new();
            Console.WriteLine(InternalCar.Model); // ✅ Works within the same project

            ProtectedInternalCar protectedInternalCar = new ProtectedInternalCar();
            Console.WriteLine(protectedInternalCar.Category); // ✅ Works because it's internal in the same project

            PrivateProtectedCar privateProtectedCar = new();
            // Console.WriteLine(privateProtectedCar.Type); ❌ ERROR: Cannot access private protected member
        }
    }

    class Vehicle
    {
        protected string Type = "Car"; // Protected: Accessible only in child classes
    }


    public class VehicleProtectedInternal
    {
        protected internal string Category = "Four-wheeler";
    }


    public class VehiclePrivateProtected
    {
        private protected string Type = "Car";
    }
}
