using LLMs.SingleResponsibility.GoodCode;

namespace LLMs.SingleResponsibility
{
    // Coordinating the classes in a high-level class
    public class ReportService : IReportService
    {
        private readonly ReportGenerator _generator = new();
        private readonly ReportSaver _saver = new();
        private readonly ReportPrinter _printer = new();

        public void ProcessReport()
        {
            var report = _generator.GenerateReport();
            _saver.SaveToFile(report);
            _printer.PrintReport(report);
        }
    }
}
