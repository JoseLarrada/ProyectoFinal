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
        //PROCEDIMIENTOS
        public string ExtraerDiagnosticoProcedimientos(string codigo)
        {
            string IdDiagnostico = consulta.LlamadoGlobal(codigo, "ConsultasProcedimientos.ExtraerDiagnosticoP");
            return IdDiagnostico;
        }
        public string ExtraerTipoIdProcedimiento(string codigo)
        {
            string Tipo = consulta.LlamadoGlobal(codigo, "ConsultasProcedimientos.ExtraerTipoIdeP");
            return Tipo;
        }
        public string ExtraerEdadProcedimiento(string codigo)
        {
            string edad = consulta.LlamadoGlobal(codigo, "ConsultasProcedimientos.ExtraerEdadP");
            return edad;
        }
        public string ExtraernumAuto(string codigo)
        {
            string autorizacion = consulta.LlamadoGlobal(codigo, "ConsultasProcedimientos.ExtraeraAuto");
            return autorizacion;
        }
        public string ExtraerNombres(string codigo)
        {
            string nombre = consulta.LlamadoGlobal(codigo, "ConsultasProcedimientos.ExtraerNombreP");
            return nombre;
        }
        public string ExtraerApellidos(string codigo)
        {
            string apellido = consulta.LlamadoGlobal(codigo, "ConsultasProcedimientos.ExtraerApellidoP");
            return apellido;
        }
        public string ExtraerNumeroId(string codigo)
        {
            string numero = consulta.LlamadoGlobal(codigo, "ConsultasProcedimientos.ExtraerIdP");
            return numero;
        }
        public string extraerFinalidadP(string codigo)
        {
            string fin = consulta.LlamadoGlobal(codigo, "ConsultasProcedimientos.ExtraerFinalidad");
            return fin;
        }

    }
}
