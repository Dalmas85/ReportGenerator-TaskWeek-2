

namespace ReportGenerator
{
   public class PdfReportCreator:ReportCreator
    {

        public override IReport CreateReport()
        {
            return new PdfReport();
        }
    }
}
