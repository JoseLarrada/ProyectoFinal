using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    
    public class Configuraciones
    {
        Datos.Obtencion_de_Id.Obtenciones par;
        public Configuraciones(string conexion)
        {
            par = new Datos.Obtencion_de_Id.Obtenciones(conexion);
        }
        public string CodigoConsulta(string Codigo)
        {
            string Id_CodigoConsulta = par.obtenerId(Codigo, "ObtenerId");
            return Id_CodigoConsulta;
        }
        public string FinalidadConsultas(string Finalidad)
        {
            string Id_FinalidadConsulta = par.obtenerId(Finalidad, "ObtenerFinalidades");
            return Id_FinalidadConsulta;
        }
        public string TipoIdentificacion(string tipoIdentificacion)
        {
            string Id_Tipo = par.obtenerId(tipoIdentificacion, "ObtenerTipo");
            return Id_Tipo;
        }
        public string DiagnosticoPrinciPal(string Diagnosticos)
        {
            string Id_codigo = par.obtenerId(Diagnosticos, "ObtenerDiagnostico");
            return Id_codigo;
        }
        public string CausasExternas(string CausaExternas) 
        {
            string Id_causas = par.obtenerId(CausaExternas, "ObtenerCausas");
            return Id_causas;
        }
        public string TipoUsuarios(string Tipo) 
        {
            string Id_tiposU = par.obtenerId(Tipo, "ObtenerTipoUsuario");
            return Id_tiposU;
        }
        public string Sexo(string sexo) 
        {
            string Id_sexo = par.obtenerId(sexo, "ObtenerSexo");
            return Id_sexo;
        }
        public string Departamentos(string departamentos)
        {
            string Id_Departamento = par.obtenerId(departamentos, "ObtenerDepartamento");
            return Id_Departamento;
        }
        public string Municipios(string municipios)
        {
            string Id_Municipio = par.obtenerId(municipios, "ObtenerMunicipio");
            return Id_Municipio;
        }
        public string TipoDiagnostico(string tipodiagnostico)
        {
            string Id_TipoD = par.obtenerId(tipodiagnostico, "ObtenerTipoDiagnostico");
            return Id_TipoD;
        }
        public string Zona(string zona)
        {
            string Id_Zona = par.obtenerId(zona, "ObtenerZona");
            return Id_Zona;
        }
        public string FinalidadProcedimientos(string finalidadProcedimientos)
        {
            string Id_Finalidad = par.obtenerId(finalidadProcedimientos, "ObtenerFinalidad");
            return Id_Finalidad;
        }
        public string FormaRealizacion(string formaRealizacion)
        {
            string Id_Forma= par.obtenerId(formaRealizacion, "ObtenerForma");
            return Id_Forma;
        }
        public string DiagnosticoProcedimiento(string diagnosticoProcedimiento)
        {
            string id_Diagnostico = par.obtenerId(diagnosticoProcedimiento, "ObtenerDiagProcedimientos");
            return id_Diagnostico;
        }
        public string Ambitos(string ambitos)
        {
            string id_Diagnostico = par.obtenerId(ambitos, "ObtenerAmbito");
            return id_Diagnostico;
        }

    }
}
