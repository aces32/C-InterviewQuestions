namespace LLMs.SQL
{
    internal class Normalization
    {
        /*
         * What is Normalization?
            Child Explanation:
            Imagine you have a messy toy box with duplicate toys, broken pieces, and mixed-up parts. 
            Normalization is like organizing your toys into different compartments so that everything is in the right place,
            and there are no extra or unnecessary duplicates.
            
            Technical Explanation:
            Normalization is the process of organizing a database to minimize redundancy (duplicate data) and improve data integrity. 
            It ensures that data is stored efficiently and avoids anomalies during insertions, updates, and deletions.

            Why is Normalization Important?
            Reduces Data Redundancy – Avoids storing the same data in multiple places.
            Prevents Anomalies – Ensures consistency during updates, deletions, and insertions.
            Improves Data Integrity – Keeps data accurate and structured.
            Enhances Performance – Reduces the size of the database and speeds up queries.

            The Different Normal Forms (1NF, 2NF, 3NF, BCNF)
            1NF (First Normal Form) - No Duplicate Rows & Atomic Columns
            Child Explanation:
                Imagine a notebook where each page should have only one piece of information per line, 
                not a mix of items in one space.
            Technical Explanation:
                Each column must contain only atomic (indivisible) values.
                Each row must have a unique identifier (Primary Key).
                No repeating groups or arrays in a single column.

           Example: 
                ✅ Example Before 1NF (Bad Design)

                OrderID	Customer	Products
                1	    Alice	    Apple, Banana
                2	    Bob	        Orange
                ⛔ Problem: The "Products" column has multiple values.
                
                ✅ After 1NF (Good Design)
                
                OrderID	Customer	Product
                1	    Alice	    Apple
                1	    Alice	    Banana
                2	    Bob	        Orange

        2NF (Second Normal Form) - No Partial Dependency
            Child Explanation:
            Imagine you have a list of books in a library, but some books belong to different shelves. 
            You should separate the books by shelves instead of writing the shelf information multiple times.
            Technical Explanation:
            Must be in 1NF.
            All non-key columns must depend fully on the primary key (not just part of it).
            If a table has a composite primary key (more than one column as a key), 
            then non-key attributes should depend on the entire key, not just part of it.

            ✅ Example Before 2NF (Bad Design)

            OrderID	Product	CustomerName	CustomerPhone
            1	    Apple	Alice	        12345
            2	    Banana	Bob	            67890
            ⛔ Problem: CustomerName and CustomerPhone depend only on OrderID, not on Product.
            
            ✅ After 2NF (Good Design)
            ✔ Split into two tables:
            
            Orders Table
            
            OrderID	Product
            1	    Apple
            2	    Banana
            Customers Table
            
            CustomerID	CustomerName	CustomerPhone
            1	            Alice	    12345
            2	            Bob	        67890
            Now, each non-key column depends on the entire primary key.

          3NF (Third Normal Form) - No Transitive Dependency
            Child Explanation:
            Imagine you are keeping a record of students and their school principals. Instead of storing the principal’s name in every student’s record, you should store the school information separately.
            Technical Explanation:
            Must be in 2NF.
            No transitive dependencies (a non-key column should not depend on another non-key column).
            Every non-key column should depend only on the primary key.

            ✅ Example Before 3NF (Bad Design)

                StudentID	StudentName	School	Principal
                1	        Alice	    ABC	    Mr. Smith
                2	        Bob	        XYZ	    Ms. Jane
                ⛔ Problem: The principal depends on the School, not directly on StudentID.
                
                ✅ After 3NF (Good Design)
                ✔ Split into two tables:
                
                Students Table
                
                StudentID	StudentName	School
                1	        Alice	    ABC
                2	        Bob	        XYZ
                Schools Table
                
                School	Principal
                ABC	    Mr. Smith
                XYZ	    Ms. Jane
                Now, each table stores only relevant data.
         * 
         */
    }
}
