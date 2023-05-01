using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FConsulta
    {

        public FConsulta()
        {
            
        }
        public FConsulta(string finalidadC)
        {
            FinalidadC = finalidadC;
        }

        public string FinalidadC { get; set; }

        public override string ToString()
        {
            return $"{FinalidadC}";
        }
    }
}
