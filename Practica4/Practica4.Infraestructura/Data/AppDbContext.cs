using Practica4.Domain.Entities;
using System.Data.Entity;

namespace MvcTienda.Infraestructura.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("MVCPractica4")
        {
        }

        public DbSet<Datos> Datos { get; set; }
    }
}