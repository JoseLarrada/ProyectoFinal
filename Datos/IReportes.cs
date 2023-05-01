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
        List<T> ObtenerLista();
        string Modificar_Eliminar(List<T> listaActualizada);
        T mapear(string linea);
    }
}
