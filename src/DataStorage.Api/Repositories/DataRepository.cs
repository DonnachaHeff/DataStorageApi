using System.Linq;
using System.Collections.Generic;
using DataStorage.Api.Interfaces.Repository;
using DataStorage.EF.Context;
using DataStorage.Api.Models;
using DataStorage.EF.Entities;

namespace DataStorage.Api.Repositories
{
    public class DataRepository : IDataRepository
    {
        public void UpdateData(string repository, CreateObjectRequest request)
        {
            using (var db = new DataStorageContext())
            {
                var result = db.ExpectedObjects.FirstOrDefault(x => x.Repository == repository && x.ObjectId == request.oid);

                if (result != null)
                {
                    return;
                }    
                else
                {
                    var entity = new ExpectedObject
                    {
                        ObjectId = request.oid,
                        Size = request.size,
                        Repository = repository
                    };

                    db.ExpectedObjects.Add(entity);
                    db.SaveChanges();
                }
            }
        }

        public ExpectedObjectDTO GetDataObject(string repository, string objectId)
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
                    return new ExpectedObjectDTO
                    {
                        oid = result.ObjectId,
                        size = long.Parse(result.Size)
                    };

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
                    db.SaveChanges();
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
        }
    }
}
