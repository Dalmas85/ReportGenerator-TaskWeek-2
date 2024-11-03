

namespace ReportGenerator
{
    public class WordReportCreator:ReportCreator
    {

        public override IReport CreateReport()
        {
            return new WordReport();
        }
    }
}
