using CasaRM.WebApp.Services.Interfaces;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace CasaRM.WebApp.Services.Implementations
{
    public class FileGeneratorService : IFileGeneratorService
    {
        public XLWorkbook GenerateExcelFromDataTable(DataTable dataTable)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sample Sheet");
            worksheet.Cell("A1").Value = "Hello World!";
            worksheet.Cell("A2").FormulaA1 = "=MID(A1, 7, 5)";

            return workbook;
        }

        public byte[] XLWorkbookToBytes(XLWorkbook workbook)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                workbook.SaveAs(memoryStream);
                memoryStream.Position = 0;

                return memoryStream.ToArray();
            }
        }
    }
}
