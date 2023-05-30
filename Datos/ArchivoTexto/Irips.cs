using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ArchivoTexto
{
    public interface Irips<T>
    {
        string Generar(T Tipo);
        List<T> GetRips(DateTime Fecha);
    }
}
