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
        string Actualizar(T Cliente, T NuevoC);
        string Eliminar(T cliente);
        List<T> ObtenerTodos();
        bool Existe(T Cliente);
        bool VExtension(string Cliente, int longitud);
        int ValidarEnteros(string numero);
        double ValidarDouble(string numero);
        T ObtenerPorId(string identificacion);

    }
}
