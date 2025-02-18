using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs.SQL
{
    internal class Triggers
    {
        /*
         * A Trigger is an automatic action executed when a certain event (INSERT, UPDATE, DELETE) happens on a table. 
         * Triggers enforce business rules and ensure data consistency.
         * ✅ Example: Prevent Negative Stock with a Trigger
         * CREATE TRIGGER PreventNegativeStock
            ON Orders
            AFTER INSERT
            AS
            BEGIN
                IF EXISTS (SELECT * FROM Products p 
                           JOIN inserted i ON p.ProductID = i.ProductID
                           WHERE p.Stock - i.Quantity < 0)
                BEGIN
                    RAISERROR ('Insufficient stock!', 16, 1);
                    ROLLBACK TRANSACTION;
                END;
            END;

           * 🔹 Now, if someone tries to buy more stock than available, the transaction is canceled.
           * 
           * When Are Triggers Useful?
            Use Case	                Example
            Automatic Data Validation	Prevent negative stock levels.
            Audit Logging	            Log changes in sensitive tables (e.g., track deleted records).
            Enforce Business Rules	    Restrict updates to important fields (e.g., a user's email cannot be changed once verified).
            Cascade Actions	            Automatically update related records in other tables.

         */
    }
}
