using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4.Aplicacion.Chiste
{
    public interface IChisteService
    {
        IEnumerable<ChisteDto> GetAllChistes();
        ChisteDto GetChisteById(int id);
        void AddChiste(ChisteDto chisteDto);
        void UpdateChiste(ChisteDto chisteDto);
        void DeleteChiste(int id);
    }
}