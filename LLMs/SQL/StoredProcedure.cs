using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs.SQL
{
    internal class StoredProcedure
    {
        /*
         * A Stored Procedure is a precompiled SQL script that is stored in the database and can be executed multiple times. 
         * It contains SQL queries and business logic that can be called by applications or other database objects.
         * ✅ Example: Simple Stored Procedure
         * CREATE PROCEDURE GetCustomerOrders
            @CustomerID INT
            AS
            BEGIN
                SELECT * FROM Orders WHERE CustomerID = @CustomerID;
            END;
            
            Benefit	                Description
            Faster Performance	    Stored procedures are precompiled and optimized by the database engine, making them faster than dynamic queries.
            Security	            Restricts direct access to tables, allowing users to execute only authorized stored procedures.
            Code Reusability	    Write once, use multiple times—avoids repetitive SQL code.
            Reduced Network Traffic	Only procedure name and parameters are sent to the database instead of long SQL queries.
            Transaction Management	Ensures multiple SQL statements execute as a single unit.

         *  
         */
    }
}
