using athena.api.Models;
using athena.api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace athena.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoriController : ControllerBase
    {
        private readonly ProfesoriRepository _profesoriRepository;
        public ProfesoriController(ProfesoriRepository profesoriRepository) 
        {
            _profesoriRepository =  profesoriRepository;
        }

        [HttpPost]
        public async Task<ActionResult> AddProfesori([FromBody] Profesori profesori)
        {
            await _profesoriRepository.AddProfesori(profesori);
            return Ok();
        } 

    }
}
