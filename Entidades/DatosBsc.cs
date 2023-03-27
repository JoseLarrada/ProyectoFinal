using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosBsc
    {
        public DatosBsc()
        {
            
        }

        public DatosBsc(string numeroFactura, string codigoConsultorio, string tipoId, string numeroIdentificacion, string codigoC)
        {
            NumeroFactura=numeroFactura;
            CodigoConsultorio=codigoConsultorio;
            TipoId=tipoId;
            NumeroIdentificacion=numeroIdentificacion;
            CodigoC=codigoC;
        }

        public string NumeroFactura { get; set; }
        public string CodigoConsultorio { get; set; }
        public string TipoId { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string CodigoC { get; set; }
    }
}
