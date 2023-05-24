using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal interface Idatos<T>
    {
        string Crear(T cliente);
        string Actualizar(T Cliente);
        string Eliminar(T cliente);
        List<T> ObtenerTodos();
    }
}
