using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Procedimiento : DatosBsc
    {
        public Procedimiento()
        {
            
        }

        public Procedimiento(string numeroFactura, string codigoConsultorio, string tipoId, string numeroIdentificacion, string codigoC, DateTime fechaProcedimiento, string numeroAutorizacion, string ambitoRealProce, string finalidadProce, string personalAti, string diagnosticoPpal, string codigoDiagPpal,
                             string formaRealiActo, double vrlProcedimiento) : base(numeroFactura, codigoConsultorio, tipoId, numeroIdentificacion, codigoC)
        {
            FechaProcedimiento=fechaProcedimiento;
            NumeroAutorizacion=numeroAutorizacion;
            AmbitoRealProce=ambitoRealProce;
            FinalidadProce=finalidadProce;
            PersonalAti=personalAti;
            DiagnosticoPpal=diagnosticoPpal;
            CodigoDiagPpal=codigoDiagPpal;
            FormaRealiActo=formaRealiActo;
            VrlProcedimiento=vrlProcedimiento;
        }

        public DateTime FechaProcedimiento { get; set; }
        public string NumeroAutorizacion { get; set; }
        public string AmbitoRealProce { get; set; }
        public string FinalidadProce { get; set; }
        public string PersonalAti { get; set; }
        public string DiagnosticoPpal { get; set; }
        public string CodigoDiagPpal { get; set; }
        public string FormaRealiActo { get; set; }
        public double VrlProcedimiento { get; set; }

        public override string ToString()
        {
            return $"{NumeroFactura};{CodigoConsultorio};{TipoId};{NumeroIdentificacion};{CodigoC};{FechaProcedimiento.ToShortDateString()};{NumeroAutorizacion};{AmbitoRealProce};{FinalidadProce};{PersonalAti};{DiagnosticoPpal};{CodigoDiagPpal};{FormaRealiActo};{VrlProcedimiento}";
        }
    }
}
