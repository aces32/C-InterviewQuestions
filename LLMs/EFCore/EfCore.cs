namespace LLMs.EFCore
{
    internal class EfCore
    {
        /*
         * Let’s say you own a library 📚, and you love books! But you have to decide how to get books when someone asks for them.

            There are three different ways to handle this:
            
            1️⃣ Lazy Loading – Get books only when someone asks.
            2️⃣ Eager Loading – Get all the books upfront, even if they are not needed.
            3️⃣ Deferred Execution – Prepare to get books, but don’t actually fetch them until necessary.

             1️⃣ Lazy Loading (Fetch Only When Needed)
                Imagine someone walks into your library and says:
                "I want to read Harry Potter."
                
                You don’t get all the books immediately.
                You wait until they actually open the book before fetching it.
                If they never read it, you never fetch it.
                ✅ Best For:
                ✔ Saving memory – You don’t load unnecessary books.
                ✔ Performance optimization – Only loads what’s actually needed.
                ✔ Large databases – Useful when loading related data only when required.
                
                🚀 Example in C# (Lazy Loading in Entity Framework Core)

                        📌 What happens?
                
                When you fetch a Library, Books are NOT loaded immediately.
                Books are only loaded when you actually access the Books property.

         2️⃣ Eager Loading (Fetch Everything Upfront)
                Now imagine when someone enters the library, you immediately bring all the books to them, even if they only read one.
                
                This ensures all books are ready if needed.
                But if the customer only reads one book, the extra books were a waste of effort.
                ✅ Best For:
                ✔ Avoiding extra database calls (fetches all needed data in one go).
                ✔ Performance improvement when all data is required.
                ✔ Reducing database load in high-traffic systems.

                var library = dbContext.Libraries
                      .Include(l => l.Books)  // Eagerly loads Books
                      .FirstOrDefault();



                        📌 What happens?
                
                The Books are fetched immediately with the Library.
                No extra queries are made when you access library.Books.
                🚨 Downside: If you only need one book, fetching all books is wasteful.

        3️⃣ Deferred Execution (Prepare Query, But Don’t Execute Immediately)
            Now imagine you make a list of books you want from the library, but you don’t actually go get them yet.
            
            You prepare the request, but the books are not fetched until you actually start reading.
            This is useful for filtering and optimizing performance.

            ✅ Best For:
            ✔ Optimizing LINQ queries – Only fetches data when absolutely necessary.
            ✔ Reducing unnecessary database calls – Query runs only at the last moment.

        var books = dbContext.Books.Where(b => b.Author == "J.K. Rowling"); // Query is NOT executed yet

            // Now when we actually use it:
            foreach (var book in books)  // Query executes HERE
            {
                Console.WriteLine(book.Title);
            }

            📌 What happens?

            books is just a query and does NOT hit the database immediately.
            Only when you iterate over books does the query execute!
            🚀 Good for performance, but be careful! If the database changes between query creation and execution, the results might not be what you expect.

            💡 Final Takeaway
                ✅ Use Lazy Loading when you don’t need everything upfront and want to save memory.
                ✅ Use Eager Loading when you need all related data immediately to avoid multiple queries.
                ✅ Use Deferred Execution when you want to optimize LINQ queries and execute only when
         */

        public class Library
        {
            public int Id { get; set; }
            public string Name { get; set; }

            // Navigation property
            // public virtual List<Book> Books { get; set; } // Lazy Loading Enabled
        }

    }
}
