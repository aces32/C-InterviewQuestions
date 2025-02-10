namespace LLMs
{
    public class Photo
    {
        public static Photo Load(string path) {  return new Photo(); }

        public static void Save()
        {
            Console.WriteLine("Photo saved");
        }
    }
}
