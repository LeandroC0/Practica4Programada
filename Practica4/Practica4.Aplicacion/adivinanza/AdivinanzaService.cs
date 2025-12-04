using Practica4.Domain.Entities;
using Practica4.Domain.Repositories;
using System;

namespace Practica4.Aplicacion.Adivinanza
{
    public class AdivinanzaService : IAdivinanzaService
    {
        private readonly IAdivinanzaRepository _repository;

        public AdivinanzaService(IAdivinanzaRepository repository)
        {
            _repository = repository;
        }

        public bool Adivinar(AdivinanzaDto dto, out string respuestaCorrecta)
        {
            respuestaCorrecta = null;

            if (dto == null)
                return false;

            var adivinanza = _repository.GetById(dto.Id);

            if (adivinanza == null)
                return false;

            respuestaCorrecta = adivinanza.Respuesta;

            return adivinanza.Respuesta.Trim().ToLower() ==
                   dto.Respuesta.Trim().ToLower();
        }

        public AdivinanzaDto GetById(int id)
        {
            var adivinanza = _repository.GetById(id);

            if (adivinanza == null)
                return null;

            return new AdivinanzaDto
            {
                Id = adivinanza.Id,
                Respuesta = adivinanza.Respuesta
            };
        }

        public object ObtenerAdivinanza()
        {
            var adivinanza = _repository.GetRandom();

            if (adivinanza == null)
                return null;

            return new
            {
                id = adivinanza.Id,
                pregunta = adivinanza.Pregunta
            };
        }
    }
}