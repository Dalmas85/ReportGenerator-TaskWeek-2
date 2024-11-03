namespace ReportGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var ascidocReport = new AskidocReport();
            ascidocReport.Generate();

            var excelReport= new ExcelReport();
            excelReport.Generate();

            var PdfReport=new PdfReport();
            PdfReport.Generate();

            var WordReport=new WordReport();
            WordReport.Generate();

            
            Console.WriteLine();
            
        }
    }
}
