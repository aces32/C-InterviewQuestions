namespace LLMs.DependencyInversion.BadCode
{
    public class Switch
    {
        private LightBulb _bulb = new LightBulb(); // Direct dependency on a concrete class

        public void Operate(bool isOn)
        {
            if (isOn)
                _bulb.TurnOn();
            else
                _bulb.TurnOff();
        }
    }

}
