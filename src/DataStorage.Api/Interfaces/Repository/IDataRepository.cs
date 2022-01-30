using DataStorage.Api.Models;

namespace DataStorage.Api.Interfaces.Repository
{
    public interface IDataRepository
    {
        void UpdateData(string repository, CreateObjectRequest request);
        ExpectedObjectDTO  GetDataObject(string repository, string objectId);
        void DeleteDataObject(string repository, string objectId);
    }
}
