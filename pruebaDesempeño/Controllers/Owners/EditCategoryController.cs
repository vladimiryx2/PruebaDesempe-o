using Microsoft.AspNetCore.Mvc;
using pruebaDesempeño.Models;
using pruebaDesempeño.Services.Owners;


namespace DeleteOwner.Controllers.Owners
{
    [ApiController]
    [Route("api/[controller]")]
    public class EditOwnerController : ControllerBase
    {
        private readonly IOwnersService _OwnersService;

        public EditOwnerController(IOwnersService OwnersService)
        {
            _OwnersService = OwnersService;
        }

        [HttpPut]
        public async Task<ActionResult<Owner>> EditCategory([FromBody] Owner Owner)
        {
            return Ok(await _OwnersService.EditOwnerAsync( Owner));
        }
    }
}