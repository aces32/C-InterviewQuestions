namespace LLMs.ThreadSafety
{
    public class ThreadSafety
    {

        /// <summary>
        /// The lock keyword ensures that only one thread can execute a block of code at a time.
        /// </summary>
        class CounterLock
        {
            private int count = 0;
            private readonly object lockObj = new object(); // Lock object

            /// <summary>
            /// Prevents multiple threads from modifying count at the same time.
            /// Avoids race conditions
            /// Can cause deadlocks if not used properly.
            /// Performance overhead when multiple threads are waiting.
            /// </summary>
            public void Increment()
            {
                lock (lockObj) // Only one thread can enter this block at a time
                {
                    count++;
                    Console.WriteLine($"Count: {count}");
                }
            }
        }

        /// <summary>
        /// The Monitor class provides more control over locking compared to lock.
        /// </summary>
        class CounterMonitor
        {
            private int count = 0;
            private readonly object lockObj = new object();

            /// <summary>
            /// Can try to acquire a lock with a timeout (Monitor.TryEnter()).
            /// Explicit control over lock acquisition and release.
            /// </summary>
            public void Increment()
            {
                bool lockTaken = false;
                try
                {
                    Monitor.Enter(lockObj, ref lockTaken);
                    count++;
                    Console.WriteLine($"Count: {count}");
                }
                finally
                {
                    if (lockTaken) Monitor.Exit(lockObj); // Ensure lock is released
                }
            }
        }

        /// <summary>
        /// A Semaphore allows a limited number of threads to access a resource simultaneously.
        /// </summary>
        class ProgramSemaphore
        {
            static SemaphoreSlim semaphore = new SemaphoreSlim(2); // Allow max 2 threads

            /// <summary>
            /// Limits concurrent thread execution.
            /// More efficient than Semaphore (which uses OS handles).
            /// </summary>
            static void AccessResource()
            {
                semaphore.Wait(); // Acquire lock
                try
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is accessing resource");
                    Thread.Sleep(2000);
                }
                finally
                {
                    semaphore.Release(); // Release lock
                }
            }

            static void Main()
            {
                for (int i = 0; i < 5; i++)
                {
                    new Thread(AccessResource).Start();
                }
            }
        }


        /*
         * 8️⃣ Use Immutable Objects to Avoid Data Modification 🚀
            Instead of locking, use immutable (read-only) objects, which cannot be modified after creation.
            
            ✅ Example: Using Immutable Objects
            csharp
            Copy
            Edit
            record Person(string Name, int Age); // Immutable record in C#
            🔹 Why Use Immutable Objects?
            ✔ No synchronization required! Safe by design.
            
            🚨 Limitations:
            ❌ Requires creating new objects instead of modifying existing ones.
            record Person(string Name, int Age); // Immutable record in C#
         */
    }
}
