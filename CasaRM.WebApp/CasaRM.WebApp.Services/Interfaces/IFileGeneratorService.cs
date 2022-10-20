using ClosedXML.Excel;
using System.Data;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IFileGeneratorService
    {
        XLWorkbook GenerateExcelFromDataTable(DataTable dataTable);

        byte[] XLWorkbookToBytes(XLWorkbook workbook);
    }
}
