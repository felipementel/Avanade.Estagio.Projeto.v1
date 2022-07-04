using Avanade.Estagiario.API.Domain;
using Avanade.Estagiario.API.Repositorio;
using Avanade.Estagiario.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avanade.Estagiario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CervejasController : ControllerBase
    {
        private ICervejaService _cerveja;
        public CervejasController(ICervejaService cerveja)
        {
            _cerveja = cerveja;
        }

        [HttpGet]
        public IActionResult ListarCervejas()
        {
            var cerv = _cerveja.ListarCervejas();
            if (cerv == null)
                return NotFound();
            return Ok(cerv);
        }

        [HttpGet("{IdCerveja}")]
        public IActionResult LerCerveja(int IdCerveja)
        {
            var cerv = _cerveja.LerCerveja(IdCerveja);
            if (cerv == null)
                return NotFound();
            return Ok(cerv);
        }

        [HttpPost]
        public IActionResult CadastrarCerveja([FromBody] Cerveja cerveja)
        {
            if (cerveja == null) return BadRequest();
            return Ok(_cerveja.CadastrarCerveja(cerveja)); ;
        }
        
        [HttpPut]
        public IActionResult Update([FromBody] Cerveja cerveja)
        {
            if (cerveja == null) return BadRequest();
            return Ok(_cerveja.AtualizarCerveja(cerveja));
        }

        [HttpDelete("{IdCerveja}")]
        public IActionResult Delete(int IdCerveja)
        {
            if(_cerveja.ExcluirCerveja(IdCerveja))
                return NoContent();
            return NotFound();
        }
    }
}
