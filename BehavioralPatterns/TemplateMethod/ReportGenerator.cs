namespace BehavioralPatterns.TemplateMethod
{
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            GenerateHeader();
            GenerateContent();
            ExportReport();
        }

        protected virtual void GenerateHeader()
        {
            Console.WriteLine("Generating report header...");
        }

        protected virtual void GenerateContent()
        {
            Console.WriteLine("Generating report content...");
        }

        protected abstract void ExportReport();
    }
}