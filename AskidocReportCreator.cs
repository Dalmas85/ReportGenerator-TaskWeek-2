

namespace ReportGenerator
{
   public class AskidocReportCreator:ReportCreator
    {
        public override IReport CreateReport()
        {
            return new AskidocReport();
        }
    }
}
