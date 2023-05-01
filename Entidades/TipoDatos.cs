using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoDatos
    {
        public TipoDatos()
        {
            
        }

        public TipoDatos(string nombreTipo)
        {
            NombreTipo = nombreTipo;
        }

        public string NombreTipo { get; set; }

        public override string ToString()
        {
            return $"{NombreTipo}";
        }
    }
}
