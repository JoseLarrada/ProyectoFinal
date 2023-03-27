using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medicamento
    {
        public Medicamento()
        {
            
        }

        public Medicamento(string codigoConsultorio, string tipoIdPaciente, string numeroIdPaciente, string numeroAutorizacion, string tipoMedicamento, string nombreGenerico, string formaFarmaceutica, 
                           string concentracion, string unidadMedidas, string numeroUnidades)
        {
            CodigoConsultorio=codigoConsultorio;
            TipoIdPaciente=tipoIdPaciente;
            NumeroIdPaciente=numeroIdPaciente;
            NumeroAutorizacion=numeroAutorizacion;
            TipoMedicamento=tipoMedicamento;
            NombreGenerico=nombreGenerico;
            FormaFarmaceutica=formaFarmaceutica;
            Concentracion=concentracion;
            UnidadMedidas=unidadMedidas;
            NumeroUnidades=numeroUnidades;
        }

        public string CodigoConsultorio { get; set; }
        public string TipoIdPaciente { get; set; }
        public string NumeroIdPaciente { get; set; }
        public string NumeroAutorizacion { get; set; }
        public string TipoMedicamento { get; set; }
        public string NombreGenerico { get; set; }
        public string FormaFarmaceutica { get; set; }
        public string Concentracion { get; set; }
        public string UnidadMedidas { get; set; }
        public string NumeroUnidades { get; set; }
    }
}
