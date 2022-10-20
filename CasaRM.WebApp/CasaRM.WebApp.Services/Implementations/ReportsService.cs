using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.SocialStudy;
using ClosedXML.Excel;

namespace CasaRM.WebApp.Services.Implementations
{
    public class ReportsService : IReportsService
    {
		private readonly IFileGeneratorService _fileGeneratorService;
		private readonly IMinorPersonDataRepository _minorPersonDataRepository;

		public ReportsService(IMinorPersonDataRepository minorPersonDataRepository,
			IFileGeneratorService fileGeneratorService)
		{
			_minorPersonDataRepository = minorPersonDataRepository;
			_fileGeneratorService = fileGeneratorService;
		}

        public async Task<byte[]> GenerateDemoReport()
        {
            IEnumerable<MinorPersonDataDto> data = await _minorPersonDataRepository.GetAllEntriesAsync();
            XLWorkbook workbook = _fileGeneratorService.GenerateExcelFromDataTable(data.ToList().ToDataTable());

            return _fileGeneratorService.XLWorkbookToBytes(workbook);
        }
    }
}
