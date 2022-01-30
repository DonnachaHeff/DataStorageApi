using System.Linq;
using System.Collections.Generic;
using DataStorage.Api.Interfaces.Repository;
using DataStorage.EF.Context;

namespace DataStorage.Api.Repositories
{
    public class DataRepository : IDataRepository
    {
        public void UpdateData(string repository)
        {
            using (var db = new DataStorageContext())
            {
                var result = db.ExpectedObjects.FirstOrDefault(x => x.Repository == repository);

                // if data already exists, don't allow duplicate
                // else create new
            }
        }

        public void GetDataObject(string repository, string objectId)
        {
            using (var db = new DataStorageContext())
            {
                var result = db.ExpectedObjects.FirstOrDefault(x => x.Repository == repository && x.ObjectId == objectId);

                if (result == null)
                {
                    throw new KeyNotFoundException();
                }
                else
                {
                    // map result and return
                }
            }
        }

        public void DeleteDataObject(string repository, string objectId)
        {
            using (var db = new DataStorageContext())
            {
                var entityToBeRemoved = db.ExpectedObjects.FirstOrDefault(x => x.Repository == repository && x.ObjectId == objectId);

                if (entityToBeRemoved != null)
                {
                    db.Remove(entityToBeRemoved);
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
        }
    }
}
