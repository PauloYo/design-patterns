namespace BehavioralPatterns.TemplateMethod
{
    public class PdfReportGenerator : ReportGenerator
    {
        protected override void ExportReport()
        {
            Console.WriteLine("Exporting to PDF...");
        }
    }
}