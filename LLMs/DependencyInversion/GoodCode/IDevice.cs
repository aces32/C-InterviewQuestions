namespace LLMs.DependencyInversion.GoodCode
{
    // Step 1: Create an abstraction (interface)
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }
}
