using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupesController : ControllerBase
    {
        private static List<Supes> supers = new List<Supes>()
            {
                new Supes
                {
                    id = 1,
                    name = "Batman",
                    nombre = "Bruce",
                    apellido = "Wayne",
                    lugar = "Gotham City"
                },
                new Supes
                {
                    id = 2,
                    name = "Superman",
                    nombre = "Clark",
                    apellido = "Kent",
                    lugar = "Metropolis"
                }
        };

        [HttpGet("{id}")]
        public async Task<ActionResult<Supes>> Get(int id)
        {
            var heroe = supers.Find(x => x.id == id);
            if (heroe == null)
                return BadRequest("Super no encontrado");
            return Ok(heroe);
        }

        [HttpGet]
        public async Task<ActionResult<List<Supes>>> Get()
        {
            return Ok(supers);
        }

        [HttpPost]
        public async Task<ActionResult<List<Supes>>> AddSupe(Supes supe)
        {
            supers.Add(supe);
            return Ok(supers);
        }

        [HttpPut]
        public async Task<ActionResult<List<Supes>>> UpdateSupe(Supes request)
        {
            var heroe = supers.Find(x => x.id == request.id);
            if (heroe == null)
                return BadRequest("Super no encontrado");
            
            heroe.name = request.name;
            heroe.nombre = request.nombre;
            heroe.apellido = request.apellido;
            heroe.lugar = request.lugar;

            return Ok(supers);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Supes>>> DeleteSupe(int id)
        {
            var heroe = supers.Find(x => x.id == id);
            if (heroe == null)
                return BadRequest("Super no encontrado");

            supers.Remove(heroe);
            return Ok(supers);
        }
    }
}
