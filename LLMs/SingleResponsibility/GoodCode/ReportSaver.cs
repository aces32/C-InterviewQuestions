namespace LLMs.SingleResponsibility.GoodCode
{
    // Handles only file saving (Single Responsibility)
    public class ReportSaver
    {
        public void SaveToFile(string data)
        {
            File.WriteAllText("report.txt", data); // Only saves the report
        }
    }
}
