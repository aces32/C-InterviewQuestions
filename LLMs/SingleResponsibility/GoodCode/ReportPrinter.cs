namespace LLMs.SingleResponsibility.GoodCode
{

    // Handles only printing (Single Responsibility)
    public class ReportPrinter
    {
        public void PrintReport(string data)
        {
            Console.WriteLine($"Printing report: {data}"); // Only prints the report
        }
    }
}
