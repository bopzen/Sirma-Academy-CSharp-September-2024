using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversionPrincipleDIP
{
    public class ReportGenerator
    {
        private readonly IEmailSender _emailSender;
        private readonly IPDFGenerator _pdfGenerator;

        public ReportGenerator(IEmailSender emailSender, IPDFGenerator pdfGenerator)
        {
            _emailSender = emailSender;
            _pdfGenerator = pdfGenerator;
        }

        public void GenerateAndSendReport()
        {
            var report = _pdfGenerator.GeneratePDF();
            _emailSender.SendEmail("customer@example.com", report);
        }
    }

}
