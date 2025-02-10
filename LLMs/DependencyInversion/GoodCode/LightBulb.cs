namespace LLMs.DependencyInversion.GoodCode
{

    // Step 2: Implement the interface in LightBulb
    public class LightBulb : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is OFF");
        }
    }
}
