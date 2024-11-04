
namespace ReportGenerator
{
    public abstract class ReportCreator
    {
        public abstract IReport CreateReport();

        public void Generate()
        {
            IReport report = CreateReport();
            report.Generate();
        }
    }
}
