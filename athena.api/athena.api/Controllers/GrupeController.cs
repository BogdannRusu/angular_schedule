using athena.api.Models;
using athena.api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace athena.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupeController : ControllerBase
    {
        private readonly GrupeRepository _grupeRepository;
        public GrupeController(GrupeRepository grupeRepository)
        {
            _grupeRepository = grupeRepository;
        }

        [HttpPost]
        public async Task<ActionResult> AddGrupa([FromBody] Grupe grp)
        {
            await _grupeRepository.AddGrupeAsync(grp);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetCabineteList()
        {
            var cab = await _grupeRepository.GetAllGrupaAsync();
            return Ok(cab);
        }
    }
}
