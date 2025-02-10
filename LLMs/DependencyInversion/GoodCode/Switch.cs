namespace LLMs.DependencyInversion.GoodCode
{
    // Step 4: Modify Switch to depend on the abstraction
    public class Switch
    {
        private readonly IDevice _device;

        public Switch(IDevice device) // Injecting the dependency via constructor
        {
            _device = device;
        }

        public void Operate(bool isOn)
        {
            if (isOn)
                _device.TurnOn();
            else
                _device.TurnOff();
        }
    }
}
