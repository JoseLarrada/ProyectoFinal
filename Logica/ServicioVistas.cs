using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioVistas
    {
        Datos.Obtencion_de_Id.Obtenciones repositorio;
        public ServicioVistas(string conexion)
        {
            repositorio = new Datos.Obtencion_de_Id.Obtenciones(conexion);
        }
        public string TotalConsulta()
        {
            return repositorio.ObtencionGlobal("estadisticas.TotalConsulta");
        }
        public string TotalProcedimiento()
        {
            return repositorio.ObtencionGlobal("estadisticas.TotalProcedimiento");
        }
        public string NumeroDeUsuarios()
        {
            return repositorio.ObtencionGlobal("estadisticas.NumeroDeusuariosActivos");
        }
        public string FacturasPagadas()
        {
            return repositorio.ObtencionGlobal("estadisticas.numerosFacturasPagadas");
        }
        public string FacturasNoPagadas()
        {
            return repositorio.ObtencionGlobal("estadisticas.numerosFacturasNopagas");
        }
        public string ConsultasActivas()
        {
            return repositorio.ObtencionGlobal("estadisticas.NumConsultasActivas");
        }
        public string ProcedimientosActivos()
        {
            return repositorio.ObtencionGlobal("estadisticas.NumProcedimientosActivos");
        }
        public string TotalHistorias()
        {
            return repositorio.ObtencionGlobal("estadisticas.Numdehistorias");
        }
        public string TotalRecaudado()
        {
            return repositorio.ObtencionGlobal("estadisticas.TotalFacturas");
        }
        public List<string> CodigoDiagnostico()
        {
            return repositorio.ObtencionPrimerCampo("estadisticas.DiagnosticosComunes");
        }
        public List<int> Cantidad()
        {
            return repositorio.ObtencionSegundoCampo("estadisticas.DiagnosticosComunes");
        }
        public List<string> usuarios()
        {
            return repositorio.ObtencionPrimerCampo("estadisticas.UsuariosConsultas");
        }
        public List<int> CantidadUsuarios()
        {
            return repositorio.ObtencionSegundoCampo("estadisticas.UsuariosConsultas");
        }
    }
}
