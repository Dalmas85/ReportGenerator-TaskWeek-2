

namespace ReportGenerator
{
    public class ExcelReportCreator:ReportCreator
    {
        public override IReport CreateReport()
        {
            return new ExcelReport();
        }
    }
}
