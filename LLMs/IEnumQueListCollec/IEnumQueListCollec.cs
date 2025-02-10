using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs.IEnumQueListCollec
{
    internal class IEnumQueListCollec
    {
        /*
         * 1️⃣ IEnumerable<T> – Just Looking at the Candies 🍬👀
            ✅ Best for Iteration (Read-Only Collection)
            
            IEnumerable<T> lets you loop through a collection one item at a time.
            It is read-only, so you cannot modify (add/remove) items.
            It does not support indexing (myCollection[0] ❌).
            Best for: Streaming large collections, LINQ queries.

            🔹 Think of IEnumerable<T> like a window display at a candy store 🍬. You can see the candies but cannot take or modify them.

         */

        public void IEnumerable()
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);  // ✅ Works: Can iterate
            }

            // ❌ Cannot do: numbers[0];  (No indexing)

        }

        /*
         * 2️⃣ ICollection<T> – A Candy Jar 🍬🛠 (Can Add/Remove Candies)
            ✅ Supports Add, Remove, and Count
            
            Inherits from IEnumerable<T>, so you can still iterate over items.
            Supports adding and removing items.
            Still does NOT support indexing (myCollection[0] ❌).
            Best for: Basic data operations when you don’t need direct indexing.
        
            🔹 Think of ICollection<T> as a candy jar 🍬. You can add or remove candies, 
            but you still can’t grab a specific candy by its position (indexing).
         */

        public static void ICollection(string[] args)
        {
            ICollection<int> numbers =
            [
                1, 2, 3, 4, 5,
                6,
            ];
            numbers.Remove(2); // ✅ Allowed

            Console.WriteLine(numbers.Count); // ✅ Returns 5

        }

        /*
         * 3️⃣ IList<T> – A Candy Tray 🍬📦 (Pick a Candy by Position)
                ✅ Supports Indexing (Access by Position) + Add/Remove
                
                Inherits from ICollection<T>, so you can modify items.
                Supports indexing (myList[0] ✅).
                Best for: When you need both modification and indexing.
        🔹 Think of IList<T> as a tray of candies 🍬. 
        You can take, add, remove, AND pick a candy by its position.
         */

        public static void IList()
        {
            IList<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            numbers.Add(6);      // ✅ Allowed
            numbers.Remove(2);   // ✅ Allowed
            Console.WriteLine(numbers[0]); // ✅ Allowed (Indexing works)

        }

        /*
         * IQueryable<T> – A Warehouse Full of Candies 🍬🏭 (Get Only What You Need)
            ✅ Best for Querying Databases (Deferred Execution)
            
            Does NOT fetch all data immediately → Fetches only what is needed.
            Executes queries on the database, NOT in memory (better for performance).
            Supports LINQ Queries (Where(), Select(), etc.).
            Best for: Querying large datasets in databases (e.g., Entity Framework).

        ❌ Data is NOT fetched yet!
        ✅ Data is only retrieved from the database when used (e.g., .ToList()).
        🔹 Think of IQueryable<T> as a candy warehouse 🍬🏭.
        Instead of bringing all candies to your house, you only request and take the candies you need.
         */

        public static void IQueryable()
        {
            // IQueryable<int> numbers = dbContext.Numbers.Where(n => n > 10);

        }
    }
}
