using IEduca.Model.Dto;
using IEduca.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace IEduca.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AlbumListDto>>> GetAll()
        {
            return await _albumService.GetAll();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<AlbumDto>> GetById(int id)
        {
            return await _albumService.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult> Create(AlbumCreateDto model)
        {
            var result = await _albumService.Create(model);

            return CreatedAtAction(
                "GetById",
                new { id = result.Id },
                result
            );
        }
    }
}
