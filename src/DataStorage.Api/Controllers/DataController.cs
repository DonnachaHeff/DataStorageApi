using System;
using System.Collections.Generic;
using DataStorage.Api.Interfaces.Services;
using DataStorage.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DataStorage.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IDataService _dataService;

        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [ProducesResponseType(201)]
        [HttpPut]
        [Route("{repository}")]
        public IActionResult UploadObjectAsync(string repository, CreateObjectRequest request)
        {
            if (string.IsNullOrEmpty(repository))
            {
                return BadRequest("Repository needs to be specified");
            }

            try 
            {
                _dataService.UpdateDataObject(repository, request);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [HttpGet]
        [Route("{repository}/{objectID}")]
        public IActionResult DownloadObject(string repository, string objectID)
        {
            if (string.IsNullOrEmpty(repository) || string.IsNullOrEmpty(objectID))
            {
                return BadRequest();

            }

            try
            {
                var result = _dataService.GetDataObject(repository, objectID);
                return Ok(result);
            }
            catch(KeyNotFoundException e)
            {
                return NotFound();
            }
        }

        [ProducesResponseType(200)]
        [HttpDelete]
        [Route("{repository}/{objectID}")]
        public IActionResult DeleteObject(string repository, string objectID)
        {
            if (string.IsNullOrEmpty(repository) || string.IsNullOrEmpty(objectID))
            {
                return BadRequest();

            }

            try
            {
                _dataService.DeleteDataObject(repository, objectID);
                return Ok();
            }
            catch(KeyNotFoundException e)
            {
                return NotFound();
            }
        }
    }
}
