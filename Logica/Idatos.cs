﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal interface Idatos<T>
    {
        string Crear(T cliente);
        string Actualizar(T cliente);
        string Eliminar(T cliente);
    }
}
