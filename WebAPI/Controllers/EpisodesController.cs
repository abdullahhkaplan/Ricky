using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        IEpisodeService _episodeService;
        public EpisodesController(IEpisodeService episodeService)
        {
            _episodeService = episodeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {


            var result = _episodeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _episodeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _episodeService.GetByName(name);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyepisode")]
        public IActionResult Episode(string name)
        {
            var result = _episodeService.Episode(name);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}







