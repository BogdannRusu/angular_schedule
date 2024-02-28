using athena.api.Models;
using athena.api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace athena.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabineteController : ControllerBase
    {
        private readonly CabineteRepository _cabineteRepository;
        public CabineteController(CabineteRepository cabineteRepository)
        {
            _cabineteRepository = cabineteRepository;
        }

        [HttpPost]
        public async Task<ActionResult> AddCabinete([FromBody] Cabinete cabin)
        {
            await _cabineteRepository.AddCabineteAsync(cabin);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetCabineteList()
        {
            var cab = await _cabineteRepository.GetAllCabineteAsync();
            return Ok(cab);
        }
    }
}
