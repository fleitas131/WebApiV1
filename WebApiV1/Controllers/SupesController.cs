using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Supes>>> Get()
        {
            var supers = new List<Supes>()
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

            return Ok(supers);
        }
    }
}
