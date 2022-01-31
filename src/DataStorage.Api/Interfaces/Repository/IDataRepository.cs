using DataStorage.Api.Models;
using System.Threading.Tasks;

namespace DataStorage.Api.Interfaces.Repository
{
    public interface IDataRepository
    {
        Task UpdateData(string repository, CreateObjectRequest request);
        Task<ExpectedObjectDTO>  GetDataObject(string repository, string objectId);
        void DeleteDataObject(string repository, string objectId);
    }
}
