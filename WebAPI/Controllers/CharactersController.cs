using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        ICharacterService _characterService;
        public CharactersController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            

            var result = _characterService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _characterService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _characterService.GetByName(name);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbystatus")]
        public IActionResult GetByStatus(string status)
        {
            var result = _characterService.GetByStatus(status);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyspecies")]
        public IActionResult GetBySpecies(string species)
        {
            var result = _characterService.GetBySpecies(species);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbytype")]
        public IActionResult GetByType(string type)
        {
            var result = _characterService.GetByType(type);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbygender")]
        public IActionResult GetByGender(string gender)
        {
            var result = _characterService.GetByGender(gender);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


    }
}






