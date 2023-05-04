using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface Iconfiguraciones<T>
    {
        T ObtenerPorId(string Nombre);
        string Crear(T cliente);
        string Actualizar(T Cliente, T NuevoC);
        string Eliminar(T cliente);
        bool Existe(T Cliente);
        List<T> ObtenerTodos();
    }
}
