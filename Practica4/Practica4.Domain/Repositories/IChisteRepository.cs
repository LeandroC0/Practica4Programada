using Practica4.Domain.Entities;
using System.Collections.Generic;

namespace Practica4.Domain.Repositories
{
    public interface IChisteRepository
    {
        IEnumerable<Chistes> GetAllChistes();
        Chistes GetChisteById(int id);
        void AddChiste(Chistes chiste);
        void UpdateChiste(Chistes chiste);
        void DeleteChiste(int id);
    }
}