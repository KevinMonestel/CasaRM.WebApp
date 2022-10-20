using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IFileGeneratorService
    {
        XLWorkbook GenerateExcelAsync(DataTable dataTable);

        byte[] WorkbookToBytes(XLWorkbook workbook);
    }
}
