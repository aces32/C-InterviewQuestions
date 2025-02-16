namespace LLMs.SQL
{
    internal class SQLKeys
    {
        /*
         * Primary Key
            Child Explanation:
            Imagine a school where every student has a unique ID number. 
            This ID number helps the school identify each student without confusion.
            
            Technical Explanation:
            A Primary Key is a unique identifier for each record (row) in a table. 
            It ensures that no two rows have the same value in the key column and that the value is always unique and not null.
            
            CREATE TABLE Students (
                StudentID INT PRIMARY KEY,  -- Unique for each student
                Name VARCHAR(50),
                Age INT
            );

            👉 Rule: No two students can have the same StudentID, and it cannot be empty.

        Foreign Key
            Child Explanation:
            Imagine the same school, but now each student is assigned to a class. 
            Instead of writing the class name repeatedly, the student record stores the Class ID, 
            which refers to another table that contains all the class details.
            
            Technical Explanation:
            A Foreign Key is a column in one table that refers to the Primary Key in another table. 
            It helps establish a relationship between the two tables.

           CREATE TABLE Classes (
                ClassID INT PRIMARY KEY,  -- Unique class ID
                ClassName VARCHAR(50)
            );
            
            CREATE TABLE Students (
                StudentID INT PRIMARY KEY,
                Name VARCHAR(50),
                Age INT,
                ClassID INT,  -- Foreign Key
                FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)  -- Links Students to Classes
            );

            👉 How It Works:
            ClassID in the Students table refers to the ClassID in the Classes table.
            Every ClassID in Students must exist in the Classes table.
            
          How Do Primary and Foreign Keys Enforce Referential Integrity?
            📌 Referential Integrity ensures that relationships between tables remain consistent. This means:
            
            A foreign key must reference an existing primary key in the other table.
            If a referenced primary key is deleted or updated, the foreign key must handle it properly (Cascading rules help with this).
            No orphan records (e.g., a student cannot be assigned to a non-existent class).
            Example of Referential Integrity Enforcement
            ❌ Bad Case (Foreign Key Violation)
            Trying to insert a student into a non-existing class:

            INSERT INTO Students (StudentID, Name, Age, ClassID)
            VALUES (3, 'Charlie', 17, 999);  -- 999 is not a valid ClassID

            Error! Since ClassID 999 does not exist in the Classes table, the database prevents the insert.

            ✅ Cascading Rules for Referential Integrity
            ON DELETE CASCADE – If a class is deleted, all students in that class are deleted too.
            ON DELETE SET NULL – If a class is deleted, students remain but their ClassID is set to NULL.

            ALTER TABLE Students
            ADD CONSTRAINT fk_class
            FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
            ON DELETE CASCADE;
             
            
         */
    }
}
