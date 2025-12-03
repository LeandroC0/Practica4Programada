using MvcTienda.Infraestructura.Data;
using Practica4.Domain.Entities;
using Practica4.Domain.Repositories;
using Practica4.Infraestructura.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Practica4.Infraestructura.Repositories
{
    public class ChisteRepository : IChisteRepository
    {
        private readonly AppDbContext _context;

        public ChisteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Chistes> GetAllChistes()
        {
            return _context.Chistes.ToList();
        }

        public Chistes GetChisteById(int id)
        {
            return _context.Chistes.Find(id);
        }

        public void AddChiste(Chistes chiste)
        {
            _context.Chistes.Add(chiste);
            _context.SaveChanges();
        }

        public void UpdateChiste(Chistes chiste)
        {
            _context.Entry(chiste).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteChiste(int id)
        {
            var chiste = _context.Chistes.Find(id);
            if (chiste != null)
            {
                _context.Chistes.Remove(chiste);
                _context.SaveChanges();
            }
        }
    }
}