using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4.Aplicacion.Dato
{
    public interface IDatoService
    {
        IEnumerable<DatosDto> GetAllDatos();
        DatosDto GetDatoById(int id);
        void AddDato(DatosDto dato);
        void UpdateDato(DatosDto dato);
        void DeleteDato(int id);
    }
}
