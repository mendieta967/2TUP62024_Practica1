using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controllers : ControllerBase
    {
        [HttpGet]

        public int Get(int uno, int dos, int tres)
        {
            return uno + dos + tres;
        }
    }
}
//Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.
//Ejemplo: [67, 92, 153, 15] → 67, 92

