using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Practica4.API.Controllers
{
    [RoutePrefix("api/datos")]
    public class DatosController : ApiController
    {
        private static readonly List<string> DatosCuriosos = new List<string>
        {
            "Una aranna tiene 8 patas.",
            "Los perros ven en blanco y negro.",
            "El cerebro humano genera suficiente electricidad para encender una bombilla pequeña."
        };

        private static int _ultimoIndice = -1;

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetDato()
        {
            _ultimoIndice++;

            if (_ultimoIndice >= DatosCuriosos.Count)
                _ultimoIndice = 0;

            return Ok(new
            {
                Dato = DatosCuriosos[_ultimoIndice],
            });
        }
    }
}
