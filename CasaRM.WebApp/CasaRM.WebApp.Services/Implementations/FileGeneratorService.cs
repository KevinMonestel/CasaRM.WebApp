using CasaRM.WebApp.Services.Interfaces;
using ClosedXML.Excel;
using System.Data;

namespace CasaRM.WebApp.Services.Implementations
{
    public class FileGeneratorService : IFileGeneratorService
    {
        public XLWorkbook GenerateExcelFromDataTable(DataTable dataTable)
        {
            var workbook = new XLWorkbook();
            workbook.Worksheets.Add(dataTable, "Report");

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
