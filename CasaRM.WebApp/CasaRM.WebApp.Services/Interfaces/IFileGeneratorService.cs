using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IFileGeneratorService
    {
        XLWorkbook GenerateExcelFromDataTable(DataTable dataTable);

        byte[] XLWorkbookToBytes(XLWorkbook workbook);
    }
}
