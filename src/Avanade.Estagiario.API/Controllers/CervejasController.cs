using Avanade.Estagiario.API.Domain;
using Avanade.Estagiario.API.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avanade.Estagiario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CervejasController : ControllerBase
    {
        //CRUD

        [HttpPost]
        public IActionResult CadastrarCerveja([FromBody] Cerveja cerveja)
        {
            using (var ctx = new CervejaContext())
            {
                ctx.Cervejas.Add(cerveja);
                ctx.SaveChanges();
            }

            //var ctx1 = new CervejaContext();

            //ctx1.Cervejas.Add(cerveja);
            //ctx1.SaveChanges();

            return Ok();

            //TODO: Trocar para 201
        }

        [HttpGet("{IdCerveja}")]
        public IActionResult LerCerveja(int IdCerveja)
        {
            var ctx = new CervejaContext();
            var cerv = ctx.Cervejas.FirstOrDefault(c => c.Id == IdCerveja);

            if (cerv == null)
                return NotFound();
            else
                return Ok(cerv);
        }
    }
}
