namespace BehavioralPatterns.TemplateMethod
{
    public class ExcelReportGenerator : ReportGenerator
    {
        protected override void ExportReport()
        {
            Console.WriteLine("Exporting to Excel...");
        }
    }
}