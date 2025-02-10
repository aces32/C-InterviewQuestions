namespace LLMs.InterfaceSegregation.BadCode
{
    public class BasicPrinter : IMachine
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            throw new NotImplementedException(); // This printer CAN'T scan!
        }

        public void Fax()
        {
            throw new NotImplementedException(); // This printer CAN'T fax!
        }
    }

}
