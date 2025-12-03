using Practica4.Domain.Entities;   
using System.Collections.Generic;


namespace Practica4.Domain.Repositories
{
    public interface IDatoRepository
    {
        IEnumerable<Datos> GetAllDatos();
        Datos GetDatoById(int id);
        void AddDato(Datos dato);
        void UpdateDato(Datos dato);
        void DeleteDato(int id);

    }
}
