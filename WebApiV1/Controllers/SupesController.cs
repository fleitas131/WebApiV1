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
                }
        };

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
    }
}
