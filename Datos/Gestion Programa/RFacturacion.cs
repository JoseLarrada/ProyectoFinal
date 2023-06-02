using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RFacturacion : Conexiones,IReportes<Facturacion>
    {
        Mapeadores mapp=new Mapeadores();
        public RFacturacion(string connectionString) : base(connectionString)
        {
        }

        public string Guardar(Facturacion Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = "InsertarFactura";
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("num_factura", OracleType.VarChar).Value = Tipo.NumeroFactura;
                    Comando.Parameters.Add("id_Consultorio", OracleType.VarChar).Value = Tipo.CodigoConsultorio;
                    Comando.Parameters.Add("tipoi", OracleType.VarChar).Value = Tipo.TipoId;
                    Comando.Parameters.Add("numIde", OracleType.VarChar).Value = Tipo.NumeroIdentificacion;
                    Comando.Parameters.Add("nomprestador", OracleType.VarChar).Value = Tipo.NombrePrestador;
                    Comando.Parameters.Add("fechaexpe", OracleType.DateTime).Value = Tipo.FechaExpedicion;
                    Comando.Parameters.Add("fecha_inicio", OracleType.VarChar).Value = Tipo.FechaInicio;
                    Comando.Parameters.Add("fechafinal", OracleType.VarChar).Value = Tipo.FechaFinal;
                    Comando.Parameters.Add("nomEa", OracleType.VarChar).Value = Tipo.NombreConsultorio;
                    Comando.Parameters.Add("NumeroContrato", OracleType.Number).Value = Tipo.NumeroContrato;
                    Comando.Parameters.Add("PlanBeneficio", OracleType.Number).Value = Tipo.PlanBeneficios;
                    Comando.Parameters.Add("NumeroPoliza", OracleType.Number).Value = Tipo.NumeroPoliza;
                    Comando.Parameters.Add("ValorComision", OracleType.Number).Value = Tipo.VrlComision;
                    Comando.Parameters.Add("ValorDescuento", OracleType.Number).Value = Tipo.VrlTDescuento;
                    Comando.Parameters.Add("ValorNeto", OracleType.Number).Value = Tipo.VrlNetoP;
                    Comando.Parameters.Add("Estado", OracleType.Char).Value = Tipo.CodigoC;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                    return "Guardado Corretamente";

                }
            }
            catch (Exception e)
            {

                return "No se pudo Guardar la factura: "+ e.Message;
            }
        }
        public string Modificar(Facturacion Tipo)
        {
            try
            {
                using (var Comando=conexion.CreateCommand())
                {
                    Comando.CommandText = "ActualizarFactura";
                    Comando.CommandType=System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("numFac", OracleType.VarChar).Value = Tipo.NumeroFactura;
                    Comando.Parameters.Add("fechafinal", OracleType.DateTime).Value = Tipo.FechaFinal.Date;
                    Comando.Parameters.Add("numerocontrato", OracleType.VarChar).Value = Tipo.NumeroContrato;
                    Comando.Parameters.Add("planbeneficios", OracleType.Number).Value = Tipo.PlanBeneficios;
                    Comando.Parameters.Add("poliza", OracleType.Number).Value = Tipo.NumeroPoliza;
                    Comando.Parameters.Add("valordescuento", OracleType.Number).Value = Tipo.VrlTDescuento;
                    Comando.Parameters.Add("valorneto", OracleType.Number).Value = Tipo.VrlNetoP;
                    Comando.Parameters.Add("estado1", OracleType.VarChar).Value = Tipo.CodigoC;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                    return "Modificado Corretamente";
                }
            }
            catch (Exception e)
            {

                return "No se puedo modificar debido a: " + e.Message;
            }
        }

        public string Eliminar(Facturacion Tipo)
        {
            try
            {
                using (var Comando=conexion.CreateCommand())
                {
                    Comando.CommandText = $"DELETE FROM FACTURACION WHERE NUMERO_FACTURA={Tipo.NumeroFactura}";
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                    return "Eliminado Satisfactoriamente";
                }
            }
            catch (Exception e)
            {

                return "NO eliminado:  " + e.Message;
            }
        }

        public List<Facturacion> GetAll()
        {
            List<Facturacion> factura = new List<Facturacion>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "select * from Facturacion";
            Open();
            OracleDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                factura.Add(mapp.MapperFacturas(lector));
            }
            Close();
            return factura;
        }
        public List<Facturacion> GetEstadoD()
        {
            List<Facturacion> factura = new List<Facturacion>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "ConsultasFacturacion.FiltrarEstado";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
            Open();
            OracleDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                factura.Add(mapp.MapperFacturas(lector));
            }
            Close();
            return factura;
        }
    }
}
