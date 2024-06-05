using pruebaDesempeño.Models;
using pruebaDesempeño.Services.Owners;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace pruebaDesempeño.Controllers.Owners
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateOwnersController : ControllerBase
    {
        private readonly IOwnersService _ownersService;

        public CreateOwnersController(IOwnersService ownersService)
        {
            _ownersService = ownersService;
        }

        [HttpPost]
        public async Task<ActionResult<Owner>> CreateCategorie([FromBody] Owner owners)
        {
            Owner result = await _ownersService.CreateOwnerAsync(owners);
            return Ok(result);
        }
    }
}