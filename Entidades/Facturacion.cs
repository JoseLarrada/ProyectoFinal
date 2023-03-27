using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturacion : DatosBsc
    {
        public Facturacion()
        {
            
        }

        public Facturacion(string numeroFactura, string codigoConsultorio, string tipoId, string numeroIdentificacion, string codigoC, string nombrePrestador, 
                           DateTime fechaExpedicion, DateTime fechaInicio, DateTime fechaFinal, string nombreConsultorio, string numeroContrato, string planBeneficios, 
                           string numeroPoliza, double vrlTotCo, double vrlComision, double vrlTDescuento,
                           double vrlNetoP) : base(numeroFactura, codigoConsultorio, tipoId, numeroIdentificacion, codigoC)
        {
            NombrePrestador=nombrePrestador;
            FechaExpedicion=fechaExpedicion;
            FechaInicio=fechaInicio;
            FechaFinal=fechaFinal;
            NombreConsultorio=nombreConsultorio;
            NumeroContrato=numeroContrato;
            PlanBeneficios=planBeneficios;
            NumeroPoliza=numeroPoliza;
            VrlTotCo=vrlTotCo;
            VrlComision=vrlComision;
            VrlTDescuento=vrlTDescuento;
            VrlNetoP=vrlNetoP;
        }

        public string NombrePrestador { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string NombreConsultorio { get; set; }
        public string NumeroContrato { get; set; }
        public string PlanBeneficios { get; set; }
        public string NumeroPoliza { get; set; }
        public double VrlTotCo { get; set; }
        public double VrlComision { get; set; }
        public double VrlTDescuento { get; set; }
        public double VrlNetoP { get; set; }
    }
}
