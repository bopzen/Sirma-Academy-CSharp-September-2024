namespace _05DependencyInversionPrincipleDIP
{
    public class PDFGenerator : IPDFGenerator
    {
        public string GeneratePDF()
        {
            return "PDF content";
        }
    }
}