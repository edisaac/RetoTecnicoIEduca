using IEduca.Model.Dto;
using IEduca.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace IEduca.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CancionController : ControllerBase
    {
        private readonly ICancionService _cancionService;

        public CancionController(ICancionService cancionService)
        {
            _cancionService = cancionService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CancionSingleDto>> GetById(int id)
        {
            return await _cancionService.GetById(id);
        }


    }
}
