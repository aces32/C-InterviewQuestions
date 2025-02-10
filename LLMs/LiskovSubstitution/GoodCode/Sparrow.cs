namespace LLMs.LiskovSubstitution.GoodCode
{
    // Step 2: Separate flying and non-flying birds
    public class Sparrow : FlyingBird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chirp Chirp!");
        }
    }

}
