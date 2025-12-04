using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Practica4.Web.Controllers
{
    public class AdivinanzaController : Controller
    {
        private List<Adivinanza> adivinanzas = new List<Adivinanza>
        {
            new Adivinanza { Id = 1, Pregunta = "Blanca por dentro, verde por fuera. Si quieres que te lo diga, espera.", Respuesta = "La pera" },
            new Adivinanza { Id = 2, Pregunta = "Oro parece, plata no es. ¿Qué es?", Respuesta = "El plátano" },
            new Adivinanza { Id = 3, Pregunta = "Tiene agujas pero no pincha. ¿Qué es?", Respuesta = "El reloj" }
        };

        public class Adivinanza
        {
            public int Id { get; set; }
            public string Pregunta { get; set; }
            public string Respuesta { get; set; }
        }

        // GET: /Adivinanza
        public ActionResult Index()
        {
            var random = new Random();
            var index = random.Next(adivinanzas.Count);
            var adivinanza = adivinanzas[index];

            ViewBag.Adivinanza = adivinanza;
            return View();
        }

        // POST: /Adivinanza/Verificar
        [HttpPost]
        public ActionResult Verificar(int id, string respuesta)
        {
            var adivinanza = adivinanzas.FirstOrDefault(a => a.Id == id);

            if (adivinanza == null)
            {
                TempData["Error"] = "No se encontró la adivinanza";
                return RedirectToAction("Index");
            }
            bool correcto = adivinanza.Respuesta.ToLower().Trim() == respuesta.ToLower().Trim();

            if (correcto)
            {
                TempData["Mensaje"] = "¡Correcto!";
            }
            else
            {
                TempData["Mensaje"] = "Incorrecto. La respuesta era: " + adivinanza.Respuesta;
            }
            return RedirectToAction("Index");
        }
    }
}