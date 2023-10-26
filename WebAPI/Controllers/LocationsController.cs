using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        ILocationService _locationService;
        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        [HttpGet("getall")]
    public IActionResult GetAll()
    {


        var result = _locationService.GetAll();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);

    }
        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _locationService.GetByName(name);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _locationService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyteype")]
        public IActionResult GetByType(string type)
        {
            var result = _locationService.GetByType(type);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
       
        [HttpGet("getbydimension")]
        public IActionResult GetByDimension(string dimension)
        {
            var result = _locationService.GetByDimension(dimension);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
   
}











