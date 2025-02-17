namespace LLMs.SQL
{
    internal class Indexes
    {
        /*
         * What Are Indexes?
            Child Explanation:
            Imagine you have a big book, and you want to find a specific chapter. 
            Instead of flipping through every page, you use the table of contents, 
            which tells you exactly where to go. 
            An index in a database works the same way—it helps you find data quickly without scanning the entire table.
            
            Technical Explanation:
            An index is a data structure that improves the speed of data retrieval operations on a database table. 
            It works like a lookup table that allows the database engine to find rows efficiently without scanning every row in the table.
            
            ✅ Example: Without an index, searching for a student named "Alice" in a Students table requires scanning every row. 
            With an index on the Name column, the database can quickly locate "Alice" without checking every record.
            How Do Indexes Improve Query Performance?
            Indexes help queries run faster by:
            
            Reducing the number of rows scanned – Instead of checking every row, the database jumps directly to the relevant data.
            Speeding up WHERE and JOIN conditions – Indexes make it easy to locate rows that match specific conditions.
            Optimizing sorting (ORDER BY) – Instead of sorting all data, indexes keep data pre-sorted, improving performance.
            ✅ Example Without an Index:            
            SELECT * FROM Students WHERE Name = 'Alice';
            ⛔ Problem: The database must check every row (Full Table Scan), which is slow.
            
            ✅ Example With an Index:
            CREATE INDEX idx_student_name ON Students(Name);
            Now, the database can use the index to find "Alice" instantly!

        Clustered vs. Non-Clustered Indexes
        📌 Key Difference: A clustered index determines how data is physically stored, 
        while a non-clustered index is just a reference to the data.
        
        1. Clustered Index
        Child Explanation:
        Imagine a dictionary where words are already arranged in alphabetical order. 
        If you search for "Apple," you can go directly to the correct page.
        Technical Explanation:
        A clustered index sorts and stores the data rows physically in the table based on the indexed column. 
        Since the table itself is arranged according to the clustered index, each table can have only one clustered index.
        ✅ Example:
        CREATE CLUSTERED INDEX idx_student_id ON Students(StudentID);
        👉 Now, the table is physically sorted by StudentID.
        
        StudentID	Name	Age
        1	        Alice	15
        2	        Bob	    16
        3	        Charlie	17

        ⛔ Limitations of Clustered Indexes:
        
        Only one per table (because it physically sorts the data).
        Slower when inserting data into the middle (since rows must be rearranged).

        2. Non-Clustered Index
            Child Explanation:
            Imagine a textbook where topics are not in order, 
            but there is an index at the back telling you where to find each topic.
            Technical Explanation:
            A non-clustered index creates a separate lookup table with pointers to the actual rows,
            so the table itself remains unsorted
        ✅ Example:
            CREATE NONCLUSTERED INDEX idx_student_name ON Students(Name);
            👉 Now, the table remains unsorted, but searches by Name are faster.
            
            ⛔ Limitations of Non-Clustered Indexes:
            
            Extra storage needed (because the index is separate from the table).
            Extra lookup step (since it finds the pointer first, then retrieves data).

        Conclusion
            ✅ Indexes are like a fast search guide for a database.
            ✅ Clustered indexes physically order the data for fast retrieval, 
            while non-clustered indexes provide pointers for faster lookups.
            ✅ Too many indexes can slow down updates and require extra storage.
            ✅ Choosing the right index type depends on query patterns and performance needs.
         */
    }
}
