using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pacientes
    {
        public Pacientes()
        {
            
        }

        public Pacientes(string tipoId, string numeroId, string codigoConsultorio, string tipoUsuario, string primerApellido, string segundoApellido, string primerNombre, string segundoNombre, string edad, string unidadMedidaEdad, string sexo, string codigoDepartamentosResidencia, string codigoMunicipioResidencia, string zonaResidencia)
        {
            TipoId=tipoId;
            NumeroId=numeroId;
            CodigoConsultorio=codigoConsultorio;
            TipoUsuario=tipoUsuario;
            PrimerApellido=primerApellido;
            SegundoApellido=segundoApellido;
            PrimerNombre=primerNombre;
            SegundoNombre=segundoNombre;
            Edad=edad;
            UnidadMedidaEdad=unidadMedidaEdad;
            Sexo=sexo;
            CodigoDepartamentosResidencia=codigoDepartamentosResidencia;
            CodigoMunicipioResidencia=codigoMunicipioResidencia;
            ZonaResidencia=zonaResidencia;
        }

        public string TipoId { get; set; }
        public string NumeroId { get; set; }
        public string CodigoConsultorio { get; set; }
        public string TipoUsuario { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Edad { get; set; }
        public string UnidadMedidaEdad { get; set; }
        public string Sexo { get; set; }
        public string CodigoDepartamentosResidencia { get; set; }
        public string CodigoMunicipioResidencia { get; set; }
        public string ZonaResidencia { get; set; }

        public override string ToString()
        {
            return $"{TipoId};{NumeroId};{CodigoConsultorio};{TipoUsuario};{PrimerApellido};{SegundoApellido};{PrimerNombre};{SegundoNombre};{Edad};{UnidadMedidaEdad};{Sexo};{CodigoDepartamentosResidencia};{CodigoMunicipioResidencia};{ZonaResidencia}";
        }
    }
}
