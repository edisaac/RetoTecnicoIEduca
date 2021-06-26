using IEduca.Model.Dto;
using IEduca.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace IEduca.Api.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<AlbumSingleDto>> GetById(int id)
        {
            return await _albumService.GetById(id);
        }


    }
}
