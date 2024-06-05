using Microsoft.AspNetCore.Mvc;
using pruebaDesempeño.Models;
using pruebaDesempeño.Services.Owners;


namespace pruebaDesempeño.Controllers.Owners
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnersController : ControllerBase
    {
        private readonly IOwnersService _OwnersService;

        public OwnersController(IOwnersService OwnersService)
        {
            _OwnersService = OwnersService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategorieById(int id)
        {
            Owner result = await _OwnersService.GetOwnwerByIdAsync(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Owner>>> GetAllOwners()
        {
            IEnumerable<Owner> result = await _OwnersService.GetAllOwnerAsync();

            return Ok(result);
        }
        
    }
}