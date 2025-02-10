namespace LLMs.LiskovSubstitution.BadCode
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }

    public class Sparrow : Bird
    {
        // Sparrow can fly, so this works fine.
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins can't fly!");
        }
    }

}
