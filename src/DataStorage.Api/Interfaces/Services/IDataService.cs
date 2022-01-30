namespace DataStorage.Api.Interfaces.Services
{
    public interface IDataService
    {
        void UpdateData(string repository);
        void GetDataObject(string repository, string objectId);
        void DeleteDataObject(string repository, string objectId);
    }
}
