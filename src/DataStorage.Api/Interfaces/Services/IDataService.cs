using DataStorage.Api.Models;

namespace DataStorage.Api.Interfaces.Services
{
    public interface IDataService
    {
        void UpdateDataObject(string repository, CreateObjectRequest request);
        ExpectedObjectDTO GetDataObject(string repository, string objectId);
        void DeleteDataObject(string repository, string objectId);
    }
}
