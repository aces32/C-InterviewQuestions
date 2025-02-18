namespace LLMs.SQL
{
    public class SQLJoins
    {
        /*
         * 1. INNER JOIN
                Like a Venn Diagram:
                
                Child Explanation:
                Think of two overlapping circles. The overlapping part shows friends who are in both boxes.
                
                Technical Explanation:
                An INNER JOIN returns only the rows (stickers) that have matching values in both tables (boxes).

                Example:

                            Friends Table:
                            
                            FriendID	Name
                            1	        Alice
                            2	        Bob
                            3	        Charlie
         
                            Colors Table:
                            
                            FriendID	FavoriteColor
                            2	        Blue
                            3	        Green
                            4	        Red
            SELECT Friends.Name, Colors.FavoriteColor
                    FROM Friends
                    INNER JOIN Colors ON Friends.FriendID = Colors.FriendID;

            
                        Name	FavoriteColor
                        Bob	    Blue
                        Charlie	Green
                        
            2. LEFT JOIN
                Like a Big Picture with Missing Pieces:
                
                Child Explanation:
                Imagine you show all your friends (from the first box), and if one friend doesn’t have a favorite color sticker, you just leave that spot blank.
                
                Technical Explanation:
                A LEFT JOIN returns all rows from the left table and the matching rows from the right table. If there's no match, the result is NULL for the right table's columns.

                SELECT Friends.Name, Colors.FavoriteColor
                FROM Friends
                LEFT JOIN Colors ON Friends.FriendID = Colors.FriendID;

                Result:
                
                Name	FavoriteColor
                Alice	NULL
                Bob	    Blue
                Charlie	Green

            3. RIGHT JOIN
                Like a Mirror of the Left Join:
                
                Child Explanation:
                Now, imagine you show all the favorite color stickers (from the second box) and try to match them with your friends. If a color sticker doesn’t find a friend, that friend’s name stays blank.
                
                Technical Explanation:
                A RIGHT JOIN returns all rows from the right table and the matching rows from the left table. If there's no match, you get NULL for the left table's columns.
                
                Example:
                
                SQL Query:
               
                SELECT Friends.Name, Colors.FavoriteColor
                FROM Friends
                RIGHT JOIN Colors ON Friends.FriendID = Colors.FriendID;
                Result:
                
                Name	FavoriteColor
                Bob	    Blue
                Charlie	Green
                NULL	Red

            4. FULL JOIN (FULL OUTER JOIN)
                Like a Complete Collection:
                
                Child Explanation:
                Imagine you take all stickers from both boxes. You try to match friends with colors, but if a friend or a color doesn’t have a match, you still keep that sticker in your final collection with a blank space for the missing part.
                
                Technical Explanation:
                A FULL JOIN returns all rows when there is a match in either the left or right table. When there's no match, it fills in with NULL for the missing side.
                
                Example:
                
                SQL Query:
                SELECT Friends.Name, Colors.FavoriteColor
                FROM Friends
                FULL OUTER JOIN Colors ON Friends.FriendID = Colors.FriendID;
                Result:
                
                Name	FavoriteColor
                Alice	NULL
                Bob	    Blue
                Charlie	Green
                NULL	Red


         */
    }
}
