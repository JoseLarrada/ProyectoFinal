using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public  class ConfiguracionNombres
    {
        Datos.Obtencion_de_Id.Obtenciones par;
        public ConfiguracionNombres(string conexion)
        {
            par = new Datos.Obtencion_de_Id.Obtenciones(conexion);
        }
        public string CodigoConsulta(string Codigo)
        {
            string Id_CodigoConsulta = par.obtenerNombres(Codigo, " TraerNombres.codigoconsultas");
            return Id_CodigoConsulta;
        }
        public string FinalidadConsultas(string Finalidad)
        {
            string Id_FinalidadConsulta = par.obtenerNombres(Finalidad, "TraerNombres.finalidad_consultas");
            return Id_FinalidadConsulta;
        }
        public string TipoIdentificacion(string tipoIdentificacion)
        {
            string Id_Tipo = par.obtenerNombres(tipoIdentificacion, "TraerNombres.tiposidentificacion");
            return Id_Tipo;
        }
        public string DiagnosticoPrinciPal(string Diagnosticos)
        {
            string Id_codigo = par.obtenerNombres(Diagnosticos, "TraerNombres.diagnosticosconsultas");
            return Id_codigo;
        }
        public string CausasExternas(string CausaExternas)
        {
            string Id_causas = par.obtenerNombres(CausaExternas, "TraerNombres.causasexternas");
            return Id_causas;
        }
        public string TipoUsuarios(string Tipo)
        {
            string Id_tiposU = par.obtenerNombres(Tipo, "TraerNombres.tipousuario");
            return Id_tiposU;
        }
        public string Sexo(string sexo)
        {
            string Id_sexo = par.obtenerNombres(sexo, "TraerNombres.o_sexos");
            return Id_sexo;
        }
        public string Departamentos(string departamentos)
        {
            string Id_Departamento = par.obtenerNombres(departamentos, "TraerNombres.departamentos");
            return Id_Departamento;
        }
        public string Municipios(string municipios)
        {
            string Id_Municipio = par.obtenerNombres(municipios, "TraerNombres.O_municipios");
            return Id_Municipio;
        }
        public string TipoDiagnostico(string tipodiagnostico)
        {
            string Id_TipoD = par.obtenerNombres(tipodiagnostico, "TraerNombres.o_tipodiagnostico");
            return Id_TipoD;
        }
        public string Zona(string zona)
        {
            string Id_Zona = par.obtenerNombres(zona, "TraerNombres.o_zonas");
            return Id_Zona;
        }
        public string FinalidadProcedimientos(string finalidadProcedimientos)
        {
            string Id_Finalidad = par.obtenerNombres(finalidadProcedimientos, "TraerNombres.finalidad_procedimiento");
            return Id_Finalidad;
        }
        public string FormaRealizacion(string formaRealizacion)
        {
            string Id_Forma = par.obtenerNombres(formaRealizacion, "TraerNombres.formarealizacion");
            return Id_Forma;
        }
        public string DiagnosticoProcedimiento(string diagnosticoProcedimiento)
        {
            string id_Diagnostico = par.obtenerNombres(diagnosticoProcedimiento, "TraerNombres.codigoprocedimiento");
            return id_Diagnostico;
        }
        public string Ambitos(string ambitos)
        {
            string id_Diagnostico = par.obtenerNombres(ambitos, "TraerNombres.o_ambitos");
            return id_Diagnostico;
        }
    }
}
