using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs.ConstvsReadOnly
{
    internal class ConstVsReadOnly(string path)
    {
        /* 
            Both const and readonly are used to define variables whose values cannot change, but they behave differently.

        1️⃣ const (Constant) 🔒
           * Value must be assigned at declaration and cannot change after that.
           * Must be a compile-time constant (known at compile-time).
           * Implicitly static, meaning it belongs to the class, not an instance.
           * Stored in metadata, so its value gets hardcoded into compiled code.
           * Cannot be modified anywhere in the program.  
        
        2️⃣ readonly (Read-Only) 📌
           * Value can be assigned at declaration or inside a constructor.
           * Can be different for each instance of the class.
           * Used for runtime constants (values only known when the program runs).
           
        Key Differences:
                                Feature	const	readonly
            Set at declaration?	✅ Yes	✅ Yes or in constructor
            Value known at?	Compile-time	Runtime
            Can be modified after initialization?	❌ No	❌ No
            Belongs to?	Class (implicitly static)	Instance (or static if declared as static readonly)
            Can it be assigned in the constructor?	❌ No	✅ Yes
            Example Use Case	Pi, Gravity, Tax Rate	Configuration values, object properties

            Think of const as a street name (never changes) and readonly as a house address (can be different for each house but set only once). 🏡💡
         */

        public const int MaxUsers = 100; // Compile-time constant
        public readonly string ConfigPath = path; // Runtime constant

        /*
         Does readonly Make a List Truly Read-Only? 🤔
        No, using readonly with a List<T> does NOT make the list itself read-only. 
        It only prevents reassigning the list reference, but the contents of the list can still be modified.
        */

        public class Example
        {
            public readonly List<string> Names = new List<string> { "Alice", "Bob" };

            public void ModifyList()
            {
                Names.Add("Charlie");  // ✅ Allowed
                Names.Remove("Alice"); // ✅ Allowed
            }

            public void ReassignList()
            {
                // Names = new List<string>(); ❌ ERROR: Cannot reassign a readonly field
            }
        }

    }
}
