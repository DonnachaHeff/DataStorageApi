﻿using DataStorage.Api.Interfaces.Repository;
using DataStorage.Api.Interfaces.Services;

namespace DataStorage.Api.Services
{
    public class DataService : IDataService
    {
        private readonly IDataRepository _dataRepository;

        public DataService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public void UpdateData(string repository)
        {
            _dataRepository.UpdateData(repository);
        }

        public void GetDataObject(string repository, string objectId)
        {
            _dataRepository.GetDataObject(repository, objectId);
        }

        public void DeleteDataObject(string repository, string objectId)
        {
            _dataRepository.DeleteDataObject(repository, objectId);
        }
    }
}