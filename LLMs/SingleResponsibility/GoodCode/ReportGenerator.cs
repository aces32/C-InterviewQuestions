namespace LLMs.SingleResponsibility.GoodCode
{
    // Handles only report generation (Single Responsibility)
    public class ReportGenerator
    {
        public string GenerateReport()
        {
            return "Report Data"; // Only generates the report
        }
    }
}
