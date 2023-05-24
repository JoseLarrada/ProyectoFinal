using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Datos_Prederminados
    {
        Datos.Obtenciones.Llenado predeterminados;
        public Datos_Prederminados(string conexion)
        {
            predeterminados =new Datos.Obtenciones.Llenado(conexion);
        }
        public void CodigoConsulta(ComboBox codigoconsulta)
        {
            predeterminados.LlenarCombobox(codigoconsulta, "NOM_CODIGO", "CODIGO_CONSULTAS");
        }
        public void FinalidadConsultas(ComboBox finalidadconsultas) 
        {
            predeterminados.LlenarCombobox(finalidadconsultas, "NOM_FINALIDAD", "FINALIDADES");
        }
        public void TipoIdentificacion(ComboBox tipoidentificacion) 
        {
            predeterminados.LlenarCombobox(tipoidentificacion, "NOM_TIPOI", "TIPO_IDENTIFICACIONES");
        }
        public void DiagnosticoPrinciPal(ComboBox Diagnosticos)
        {
            predeterminados.LlenarCombobox(Diagnosticos, "NOM_DIAGNOSTICO", "DIAGNOSTICOS");
        }
        public void CausasExternas(ComboBox CausaExternas)
        {
            predeterminados.LlenarCombobox(CausaExternas, "NOM_CAUSA", "CAUSAS_EXTERNAS");
        }
        public void TipoUsuarios(ComboBox Tipo)
        {
            predeterminados.LlenarCombobox(Tipo, "NOM_TIPO", "TIPOS_USUARIOS");
        }
        public void Sexo(ComboBox sexo)
        {
            predeterminados.LlenarCombobox(sexo, "NOM_SEXO", "SEXOS");
        }
        public void Departamentos(ComboBox departamentos)
        {
            predeterminados.LlenarCombobox(departamentos, "NOMBRE_DEPARTAMENTO", "DEPARTAMENTOS");
        }
        public void Municipios(ComboBox municipios)
        {
            predeterminados.LlenarCombobox(municipios, "NOM_MUNICIPIO", "MUNICIPIOS");
        }
        public void TipoDiagnostico(ComboBox tipodiagnostico)
        {
            predeterminados.LlenarCombobox(tipodiagnostico, "NOM_TIPOD", "TIPODIAGNOSTICO");
        }
        public void Zona(ComboBox zona)
        {
            predeterminados.LlenarCombobox(zona, "NOM_ZONA", "ZONAS");
        }
        public void filtro(ComboBox ciudad,string filtro)
        {
            predeterminados.filtrarciudades(ciudad, filtro);
        }
        public void Ambitos(ComboBox ambitos)
        {
            predeterminados.LlenarCombobox(ambitos, "nom_ambito", "ambitos");
        }
        public void DiagnosticoProcedimiento(ComboBox procedimiento)
        {
            predeterminados.LlenarCombobox(procedimiento, "nom_codigop", "CODIGOS_PROCEDIMIENTOS");
        }
        public void FinalidadProcedimiento(ComboBox finalidadprocedimiento)
        {
            predeterminados.LlenarCombobox(finalidadprocedimiento, "nom_fdiagnostico", "finalidad_procedimientos");
        }
        public void Forma(ComboBox forma)
        {
            predeterminados.LlenarCombobox(forma, "nom_forma", "FORMA_REALIZACION");
        }
    }
}
