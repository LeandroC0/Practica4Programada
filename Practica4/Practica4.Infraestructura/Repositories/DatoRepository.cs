
using MvcTienda.Infraestructura.Data;
using Practica4.Domain.Entities;
using Practica4.Domain.Repositories;
using Practica4.Infraestructura.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Practica4.Infraestructura.Repositories
{
    public class DatoRepository : IDatoRepository
    {
        private readonly AppDbContext _context;

        public DatoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Datos> GetAllDatos()
        {
            return _context.Datos.ToList();
        }

        public Datos GetDatoById(int id)
        {
            return _context.Datos.Find(id);
        }

        public void AddDato(Datos dato)
        {
            _context.Datos.Add(dato);
            _context.SaveChanges();
        }

        public void UpdateDato(Datos dato)
        {
            _context.Entry(dato).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteDato(int id)
        {
            var dato = _context.Datos.Find(id);
            if (dato != null)
            {
                _context.Datos.Remove(dato);
                _context.SaveChanges();
            }
        }
    }
}
