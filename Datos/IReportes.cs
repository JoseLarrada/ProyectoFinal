using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IReportes<T>
    {
        string Guardar(T Tipo);
        string Modificar(T Tipo);
        string Eliminar(T Tipo);
        List<T> GetAll();
    }
}
