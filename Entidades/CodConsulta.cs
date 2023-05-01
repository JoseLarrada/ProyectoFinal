using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CodConsulta
    {
        public CodConsulta()
        {

        }

        public CodConsulta(string nombreTipo)
        {
            CConsulta = nombreTipo;
        }

        public string CConsulta { get; set; }

        public override string ToString()
        {
            return $"{CConsulta}";
        }
    }
}
