namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IReportsService
    {
        Task<byte[]> GenerateDemoReport();
    }
}
