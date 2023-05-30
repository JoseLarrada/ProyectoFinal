using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Mapeadores
    {
        public Mapeadores()
        {
            
        }
        public Procedimiento MapperProcedimientos(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Procedimiento consulta = new Procedimiento();
            consulta.CodigoC = dataReader.GetString(0);
            consulta.NumeroFactura = dataReader.GetString(1);
            consulta.CodigoConsultorio = dataReader.GetString(2);
            consulta.TipoId = dataReader.GetString(3);
            consulta.NumeroIdentificacion = dataReader.GetString(4);
            consulta.FechaProcedimiento = dataReader.GetDateTime(5);
            consulta.NumeroAutorizacion = dataReader.GetString(6);
            consulta.AmbitoRealProce = dataReader.GetString(7);
            consulta.FinalidadProce = dataReader.GetString(8);
            consulta.PersonalAti = dataReader.GetString(9);
            consulta.DiagnosticoPpal = dataReader.GetString(10);
            consulta.FormaRealiActo = dataReader.GetString(11);
            consulta.VrlProcedimiento = dataReader.GetInt32(12);
            return consulta;
        }
        public Consultas MapperConsultas(OracleDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Consultas consulta = new Consultas();
            consulta.NumeroFactura = dataReader.GetString(0);
            consulta.CodigoConsultorio = dataReader.GetString(1);
            consulta.TipoId = dataReader.GetString(2);
            consulta.NumeroIdentificacion = dataReader.GetString(3);
            consulta.CodigoC = dataReader.GetString(4);
            consulta.FechaConsulta = dataReader.GetDateTime(5);
            consulta.NumeroAutorizacion = dataReader.GetString(6);
            consulta.FinalidadConsulta = dataReader.GetString(7);
            consulta.CausaExterna = dataReader.GetString(8);
            consulta.CodDiagPpal = dataReader.GetString(9);
            consulta.CodDiaRel1 = dataReader.GetString(10);
            consulta.CodDiaRel2 = dataReader.GetString(11);
            consulta.CodDiaRel3 = dataReader.GetString(12);
            consulta.TipoDiagPpal = dataReader.GetString(13);
            consulta.ValorConsulta = dataReader.GetInt32(14);
            consulta.ValorCuoMod = dataReader.GetInt32(15);
            consulta.ValorNetoPagar = dataReader.GetInt32(16);
            return consulta;

        }
        public Facturacion MapperFacturas(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Facturacion factura = new Facturacion();
            factura.NumeroFactura = dataReader.GetString(0);
            factura.CodigoConsultorio = dataReader.GetString(1);
            factura.TipoId = dataReader.GetString(2);
            factura.NumeroIdentificacion = dataReader.GetString(3);
            factura.NombrePrestador = dataReader.GetString(4);
            factura.FechaExpedicion = dataReader.GetDateTime(5);
            factura.FechaInicio = dataReader.GetDateTime(6);
            factura.FechaFinal = dataReader.GetDateTime(7);
            factura.NombreConsultorio = dataReader.GetString(8);
            factura.NumeroContrato = dataReader.GetInt32(9);
            factura.PlanBeneficios = dataReader.GetInt32(10);
            factura.NumeroPoliza = dataReader.GetInt32(11);
            factura.VrlComision = dataReader.GetInt32(12);
            factura.VrlTDescuento = dataReader.GetInt32(13);
            factura.VrlNetoP = dataReader.GetInt32(14);
            factura.CodigoC = dataReader.GetString(15);
            return factura;
        }
    }
}
