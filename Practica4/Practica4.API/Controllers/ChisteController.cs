using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Practica4.API.Controllers
{
    [RoutePrefix("api/chistes")]
    public class ChisteController : ApiController
    {
        private static readonly List<string> Chistes = new List<string>
        {
            
            "¿Qué le dice un semáforo a otro? No me mires, me estoy cambiando.",
            "¿Cómo se llama el campeón de buceo japonés? Tokofondo.",
            "¿Por qué el libro de matemáticas está triste? Porque tiene demasiados problemas.",
            "¿Cómo se despiden los químicos? Ácido un placer.",
            "¿Qué le dice un gusano a otro gusano? Voy a dar una vuelta a la manzana."
        };

        private static int _ultimoIndice = -1;

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetChiste()
        {
            _ultimoIndice++;

            if (_ultimoIndice >= Chistes.Count)
                _ultimoIndice = 0;

            return Ok(new
            {
                Chiste = Chistes[_ultimoIndice],
                Indice = _ultimoIndice
            });
        }
    }
}

