namespace LLMs.SignedAndUnSignedInteger
{
    internal class SignedAndUnSignedInteger
    {
        /*
         Signed Integer
            Can store both negative and positive numbers.
            Uses one bit for sign representation (positive/negative).
            The most common integer type in C# (int) is signed.
            Example Types: sbyte, short, int, long
            Smaller positive range (because of sign bit)

        Unsigned Integer
            Can store only positive numbers (no negative values).
            Uses all bits for magnitude, allowing a larger positive range.
            Example Types: byte, ushort, uint, ulong
            Larger positive range (because no sign bit)

       */

        int signedInt = -10;  // ✅ Allowed
        int positiveInt = 100; // ✅ Allowed
        // uint unsignedInt = -5; // ❌ ERROR: Unsigned integers cannot be negative

        uint unsignedInt = 200;  // ✅ Allowed
        // uint negativeNumber = -50; // ❌ ERROR: Cannot assign a negative value to uint


    }
}
