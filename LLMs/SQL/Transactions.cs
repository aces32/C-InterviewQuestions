using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs.SQL
{
    internal class Transactions
    {
        /*
         * Child Explanation:
            Imagine you are at a toy store, and you want to buy a toy with your savings. You:
            
            Take the money from your piggy bank.
            Go to the store and buy the toy.
            Bring the toy home.
            Put the toy in your room.
            If any step fails (you lose the money, the store is closed, or you drop the toy), 
            you want to undo everything and put your money back in the piggy bank.

            A transaction in a database works the same way—it groups multiple steps (queries) together. 
            If all steps succeed, the transaction is saved. If one step fails, 
            the transaction is rolled back (undone), so the database remains consistent.

            Technical Explanation:
            A transaction is a sequence of one or more SQL statements that must be executed together as a single unit. 
            If any statement in the transaction fails, the entire transaction is rolled back to ensure data consistency.

            ✅ Example Without a Transaction (Risky Scenario)

            UPDATE Accounts SET Balance = Balance - 500 WHERE AccountID = 1; -- Deduct from Sender
            UPDATE Accounts SET Balance = Balance + 500 WHERE AccountID = 2; -- Add to Receiver
            ⛔ Problem: If the database crashes after the first update but before the second, money disappears from Account 1 but never reaches Account 2.
            
            ✅ Example With a Transaction (Safe Scenario)

            BEGIN TRANSACTION;
            UPDATE Accounts SET Balance = Balance - 500 WHERE AccountID = 1;
            UPDATE Accounts SET Balance = Balance + 500 WHERE AccountID = 2;
            COMMIT; -- Save changes if both succeed
            If any step fails, we can ROLLBACK:

            ROLLBACK; -- Undo everything if an error occurs
            This ensures the transaction fully succeeds or fully fails, keeping the database safe.

            ACID Properties of Transactions
📌          ACID stands for Atomicity, Consistency, Isolation, and Durability—
            these are rules that ensure transactions work correctly.

            ACID Property	                    Child Explanation	                                                                                Technical Explanation
            Atomicity (All or Nothing)	        If you build a toy and something goes wrong, you undo everything and start over.	                A transaction is fully completed or not executed at all. If one part fails, all previous steps are rolled back.
            Consistency (No Broken Rules)	    If you buy a toy, you must pay for it—it’s impossible to take the toy without giving money.	        A transaction must always leave the database in a valid state, following all rules (like unique IDs, constraints, etc.).
            Isolation (No Interference)	        If two kids are playing separate board games, one should not mess up the other’s game.	            Concurrent transactions should not affect each other until they are committed.
            Durability (Never Lost)	            If you finish a puzzle and glue the pieces, it stays together even if someone shakes the table.	    Once a transaction is committed, the changes are permanent, even if the system crashes.


            Final Summary
            Concept	    Explanation
            Transaction	A group of database operations executed together as a single unit.
            Atomicity	Ensures all steps are completed or none at all.
            Consistency	Ensures the database remains valid before and after a transaction.
            Isolation	Ensures transactions do not interfere with each other.
            Durability	Ensures committed transactions are saved permanently.
         */
    }
}

