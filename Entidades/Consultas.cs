using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consultas : DatosBsc
    {
        public Consultas()
        {
        }

        public Consultas(string numeroFactura, string codigoConsultorio, string tipoId, string numeroIdentificacion, string codigoC,DateTime fechaConsulta, string numeroAutorizacion, string finalidadConsulta, string causaExterna, string codDiagPpal, string codDiaRel1, string codDiaRel2, string codDiaRel3, string tipoDiagPpal, double valorConsulta, double valorCuoMod,
                        double valorNetoPagar) : base(numeroFactura,codigoConsultorio,tipoId,numeroIdentificacion,codigoC)
        {
            FechaConsulta=fechaConsulta;
            NumeroAutorizacion=numeroAutorizacion;
            FinalidadConsulta=finalidadConsulta;
            CausaExterna=causaExterna;
            CodDiagPpal=codDiagPpal;
            CodDiaRel1=codDiaRel1;
            CodDiaRel2=codDiaRel2;
            CodDiaRel3=codDiaRel3;
            TipoDiagPpal=tipoDiagPpal;
            ValorConsulta=valorConsulta;
            ValorCuoMod=valorCuoMod;
            ValorNetoPagar=valorNetoPagar;
        }



        public DateTime FechaConsulta { get; set; }
        public string NumeroAutorizacion { get; set; }
        public string FinalidadConsulta { get; set; }
        public string CausaExterna { get; set; }
        public string CodDiagPpal { get; set; }
        public string CodDiaRel1 { get; set; }
        public string CodDiaRel2 { get; set; }
        public string CodDiaRel3 { get; set; }
        public string TipoDiagPpal { get; set; }
        public double ValorConsulta { get; set; }
        public double ValorCuoMod { get; set; }
        public double ValorNetoPagar { get; set; }


    }
}
