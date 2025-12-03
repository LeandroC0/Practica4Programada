using Practica4.Aplicacion.Adivinanza;
using Practica4.Domain.Entities;
using Practica4.Infraestructura.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

[RoutePrefix("api/adivinanza")]
public class AdivinanzaController : ApiController
{
    private readonly List<Adivinanza> _adivinanzas = new List<Adivinanza>
        {
            new Adivinanza { Id = 1, Pregunta = "Blanca por dentro, verde por fuera. Si quieres que te lo diga, espera.", Respuesta = "La pera" },
            new Adivinanza { Id = 2, Pregunta = "Oro parece, plata no es. ¿Qué es?", Respuesta = "El plátano" },
            new Adivinanza { Id = 3, Pregunta = "Tiene agujas pero no pincha. ¿Qué es?", Respuesta = "El reloj" }
        };


    [HttpPost]
    [Route("")]
    public IHttpActionResult Verificar(AdivinanzaDto dto)
    {
        if (dto == null)
        {
            return BadRequest("El objeto AdivinanzaDto no puede ser nulo.");
        }
        var adivinanza = _adivinanzas.FirstOrDefault(a => a.Id == dto.Id);

        if (adivinanza == null)
            return NotFound();

        bool correcto = adivinanza.Respuesta.Trim().ToLower() ==
                        dto.Respuesta.Trim().ToLower();

        if (correcto)
        {
            return Ok(new
            {
                correcto = true,
                mensaje = "¡Respuesta correcta!"
            });
        }

        return Ok(new
        {
            correcto = false,
            mensaje = "Respuesta incorrecta",
            respuestaCorrecta = adivinanza.Respuesta
        });
    }
}
