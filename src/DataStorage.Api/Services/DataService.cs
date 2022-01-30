using DataStorage.Api.Interfaces.Repository;
using DataStorage.Api.Interfaces.Services;
using DataStorage.Api.Models;

namespace DataStorage.Api.Services
{
    public class DataService : IDataService
    {
        private readonly IDataRepository _dataRepository;

        public DataService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public void UpdateDataObject(string repository, CreateObjectRequest request)
        {
            _dataRepository.UpdateData(repository, request);
        }

        public ExpectedObjectDTO GetDataObject(string repository, string objectId)
        {
            return _dataRepository.GetDataObject(repository, objectId);
        }

        public void DeleteDataObject(string repository, string objectId)
        {
            _dataRepository.DeleteDataObject(repository, objectId);
        }
    }
}
