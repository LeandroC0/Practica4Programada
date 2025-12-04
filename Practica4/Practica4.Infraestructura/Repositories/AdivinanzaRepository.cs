using Practica4.Domain.Entities;
using Practica4.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Practica4.Infraestructura.Repositories
{
    public class AdivinanzaRepository : IAdivinanzaRepository
    {
        private readonly List<Adivinanza> _adivinanzas = new List<Adivinanza>
        {
            new Adivinanza { Id = 1, Pregunta = "Blanca por dentro, verde por fuera. Si quieres que te lo diga, espera.", Respuesta = "La pera" },
            new Adivinanza { Id = 2, Pregunta = "Oro parece, plata no es. ¿Qué es?", Respuesta = "El plátano" },
            new Adivinanza { Id = 3, Pregunta = "Tiene agujas pero no pincha. ¿Qué es?", Respuesta = "El reloj" }
        };

        public Adivinanza GetById(int id)
        {
            return _adivinanzas.FirstOrDefault(a => a.Id == id);
        }

        public List<Adivinanza> GetAll()
        {
            return _adivinanzas;
        }

        public Adivinanza GetRandom()
        {
            if (_adivinanzas.Count == 0)
                return null;

            var random = new System.Random();
            var index = random.Next(_adivinanzas.Count);
            return _adivinanzas[index];
        }
    }
}