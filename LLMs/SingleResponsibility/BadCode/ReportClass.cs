namespace LLMs.SingleResponsibility.BadCode
{
    public class ReportClass
    {
        public string GenerateReport()
        {
            // Logic to generate report data
            return "Report Data";
        }

        public void SaveToFile(string data)
        {
            // Logic to save the report to a file
            File.WriteAllText("report.txt", data);
        }

        public void PrintReport()
        {
            // Logic to send the report to the printer
            Console.WriteLine("Printing report...");
        }
    }

}
