using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consultorio
    {
        public Consultorio()
        {
            
        }

        public Consultorio(string nombreConsultorio, string codigoConsultorio, DateTime fechaApertura, int numeroDoctores, string nombreDoctor, 
                           string tipoIdDoctor, DateTime fechaNacimiento, string numeroTeléfono, string correoElectrónico, string nombreUsuario, 
                           string contraseña)
        {
            NombreConsultorio=nombreConsultorio;
            CodigoConsultorio=codigoConsultorio;
            FechaApertura=fechaApertura;
            NumeroDoctores=numeroDoctores;
            NombreDoctor=nombreDoctor;
            TipoIdDoctor=tipoIdDoctor;
            FechaNacimiento=fechaNacimiento;
            NumeroTeléfono=numeroTeléfono;
            CorreoElectrónico=correoElectrónico;
            NombreUsuario=nombreUsuario;
            Contraseña=contraseña;
        }

        public string NombreConsultorio { get; set; }
        public string CodigoConsultorio { get; set; }
        public DateTime FechaApertura { get; set; }
        public int NumeroDoctores { get; set; }
        public string NombreDoctor { get; set; }
        public string TipoIdDoctor { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumeroTeléfono { get; set; }
        public string CorreoElectrónico { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        
    }
}
