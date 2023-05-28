using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Conversiones
{
    public class CoversionesHistoria
    {
        Datos.Obtencion_de_Id.Obtenciones consulta;
        public CoversionesHistoria(string conexion)
        {
            consulta = new Datos.Obtencion_de_Id.Obtenciones(conexion);
        }
        public string ExtraerDiagnostico(string codigo)
        {
            string IdDiagnostico = consulta.LlamadoGlobal(codigo, "ExtraerHistoriasC.ExtraerDiagnostico");
            return IdDiagnostico;
        }
        public string ExtraerTipoId(string codigo)
        {
            string Tipo = consulta.LlamadoGlobal(codigo, "ExtraerHistoriasC.ExtraerTipoId");
            return Tipo;
        }
        public string ExtraerEdad(string codigo)
        {
            string edad = consulta.LlamadoGlobal(codigo, "ExtraerHistoriasC.ExtraerEdad");
            return edad;
        }
    }
}
