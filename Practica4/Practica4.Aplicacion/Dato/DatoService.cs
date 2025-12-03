// Practica4.Aplicacion/Dato/DatoService.cs
using Practica4.Domain.Entities;
using Practica4.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Practica4.Aplicacion.Dato
{
    public class DatoService : IDatoService
    {
        private readonly IDatoRepository _repo;

        public DatoService(IDatoRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<DatosDto> GetAllDatos()
        {
            return _repo.GetAllDatos()
                        .Select(d => new DatosDto
                        {
                            Id = d.Id,
                            NombreDato = d.NombreDato
                        });
        }

        public DatosDto GetDatoById(int id)
        {
            var dato = _repo.GetDatoById(id);
            if (dato == null) return null;

            return new DatosDto
            {
                Id = dato.Id,
                NombreDato = dato.NombreDato
            };
        }

        public void AddDato(DatosDto datoDto)
        {
            var dato = new Datos
            {
                NombreDato = datoDto.NombreDato
            };

            _repo.AddDato(dato);
        }

        public void UpdateDato(DatosDto datoDto)
        {
            var dato = new Datos
            {
                Id = datoDto.Id,
                NombreDato = datoDto.NombreDato
            };

            _repo.UpdateDato(dato);
        }

        public void DeleteDato(int id)
        {
            _repo.DeleteDato(id);
        }
    }
}
