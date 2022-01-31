using DataStorage.Api.Models;
using System.Threading.Tasks;

namespace DataStorage.Api.Interfaces.Services
{
    public interface IDataService
    {
        Task UpdateDataObject(string repository, CreateObjectRequest request);
        Task<ExpectedObjectDTO> GetDataObject(string repository, string objectId);
        void DeleteDataObject(string repository, string objectId);
    }
}
