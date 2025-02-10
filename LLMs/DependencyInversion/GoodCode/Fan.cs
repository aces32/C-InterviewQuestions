namespace LLMs.DependencyInversion.GoodCode
{
    // Step 3: Implement the interface in another device (e.g., Fan)
    public class Fan : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Fan is OFF");
        }
    }
}
