namespace System
{
    /// <summary>
    /// extension method allow us to add a new method to an existing class without creating a new class that inherits from it
    /// </summary>
    public static class StringExtensions
    {
        public static string ToString(this string str, int numberOfWords) 
        {
            ArgumentOutOfRangeException.ThrowIfNegative(numberOfWords);
            if (numberOfWords == 0)
            {
                return string.Empty;
            }

            var words = str.Split();

            if (words.Length <= numberOfWords) {  return str; }
            
            return string.Join(" ",words.Take(numberOfWords));
        }

    }
}
