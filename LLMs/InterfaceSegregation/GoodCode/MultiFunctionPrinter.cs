namespace LLMs.InterfaceSegregation.GoodCode
{
    public class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }

        public void Fax()
        {
            Console.WriteLine("Faxing...");
        }
    }

}
