using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HistoriaClinica: DatosBsc
    {
        public HistoriaClinica()
        {
            
        }
        public HistoriaClinica(string numeroFactura, string codigoConsultorio, string tipoId, string numeroIdentificacion, 
                               string codigoC, string edad, DateTime fecha, string primernombre, string segundonombre, string primerapellido, string segundoapellido,
                               string nombreDiagnostico, string numeroAutorizacion,string tratamiento, string medicacion) : base(numeroFactura, codigoConsultorio, tipoId, numeroIdentificacion, codigoC)
        {
            Edad = edad;
            Fecha = fecha;
            PrimerNombre = primernombre;
            SegundoNombre= segundonombre;
            PrimerApellido= primerapellido;
            SegundoApellido= segundoapellido;
            NombreDiagnostico = nombreDiagnostico;
            NumeroAutorizacion = numeroAutorizacion;
            Tratamiento = tratamiento;
            Medicacion = medicacion;
        }
        public string Edad { get; set; }
        public DateTime Fecha { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NombreDiagnostico { get; set; }
        public string NumeroAutorizacion { get; set; }
        public string Tratamiento { get; set; }
        public string Medicacion { get; set; }
    }
}
