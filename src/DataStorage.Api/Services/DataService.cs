using DataStorage.Api.Interfaces.Repository;
using DataStorage.Api.Interfaces.Services;
using DataStorage.Api.Models;
using System.Threading.Tasks;

namespace DataStorage.Api.Services
{
    public class DataService : IDataService
    {
        private readonly IDataRepository _dataRepository;

        public DataService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task UpdateDataObject(string repository, CreateObjectRequest request)
        {
            await _dataRepository.UpdateData(repository, request);
        }

        public async Task<ExpectedObjectDTO> GetDataObject(string repository, string objectId)
        {
            return await _dataRepository.GetDataObject(repository, objectId);
        }

        public void DeleteDataObject(string repository, string objectId)
        {
            _dataRepository.DeleteDataObject(repository, objectId);
        }
    }
}
