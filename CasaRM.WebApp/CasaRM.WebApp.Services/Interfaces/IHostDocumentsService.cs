namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IHostDocumentsService
    {
        Task<string> GetDocumentWithFormat(string hostId, int documentId);
    }
}
