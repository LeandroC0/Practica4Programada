using Practica4.Domain.Entities;

namespace Practica4.Domain.Repositories
{
    public interface IAdivinanzaRepository
    {
        Adivinanza GetById(int id);
    }
}
