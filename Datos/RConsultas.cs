using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RConsultas : Conexiones,IReportes<Consultas>
    {
        public RConsultas(string connectionString) : base(connectionString)
        {
        }

        private Consultas Mapper(OracleDataReader dataReader)
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
        public string Eliminar(Consultas Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText= $"DELETE FROM Consultas WHERE NUMERO_AUTORIZACION={Tipo.NumeroAutorizacion}";
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                    return "Eliminado Satisfactoriamente";
                }
            }
            catch (Exception e)
            {

                return "NO eliminado:  "+ e.Message;
            }
        }

        public List<Consultas> GetAll()
        {
            List<Consultas> consulta = new List<Consultas>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "select * from Consultas";
            Open();
            OracleDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                consulta.Add(Mapper(lector));
            }
            Close();
            return consulta;
        }
        
        public string Guardar(Consultas Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = "InsertarConsultas";
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("Num_Factura", OracleType.VarChar).Value = Tipo.NumeroFactura;
                    Comando.Parameters.Add("Id_Consultorio", OracleType.VarChar).Value = Tipo.CodigoConsultorio;
                    Comando.Parameters.Add("Tipo_Ide", OracleType.VarChar).Value = Tipo.TipoId;
                    Comando.Parameters.Add("Num_Ide", OracleType.VarChar).Value = Tipo.NumeroIdentificacion;
                    Comando.Parameters.Add("Id_CC", OracleType.VarChar).Value = Tipo.CodigoC;
                    Comando.Parameters.Add("Fecha_C", OracleType.DateTime).Value = Tipo.FechaConsulta.Date;
                    Comando.Parameters.Add("Num_Au", OracleType.VarChar).Value = Tipo.NumeroAutorizacion;
                    Comando.Parameters.Add("Id_Fina", OracleType.VarChar).Value = Tipo.FinalidadConsulta;
                    Comando.Parameters.Add("Id_Causa", OracleType.VarChar).Value = Tipo.CausaExterna;
                    Comando.Parameters.Add("Id_Diag", OracleType.VarChar).Value = Tipo.CodDiagPpal;
                    Comando.Parameters.Add("Id_Diag1", OracleType.VarChar).Value = Tipo.CodDiaRel1;
                    Comando.Parameters.Add("Id_Diag2", OracleType.VarChar).Value = Tipo.CodDiaRel2;
                    Comando.Parameters.Add("Id_Diag3", OracleType.VarChar).Value = Tipo.CodDiaRel3;
                    Comando.Parameters.Add("Id_tipo", OracleType.VarChar).Value = Tipo.TipoDiagPpal;
                    Comando.Parameters.Add("VrlCons", OracleType.Number).Value = Tipo.ValorConsulta;
                    Comando.Parameters.Add("VrlCuota", OracleType.Number).Value = Tipo.ValorCuoMod;
                    Comando.Parameters.Add("VrlNeto", OracleType.Number).Value = Tipo.ValorNetoPagar;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                }
                return "Guardado Correctamente";
            }
            catch (Exception E)
            {

                return "No se pudo Actualizar, ERROR Desconocido: "+E.Message;
            }
        }

        public string Modificar(Consultas Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = "ActualizarConsultas2";
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("Num_Factura", OracleType.VarChar).Value = Tipo.NumeroFactura;
                    Comando.Parameters.Add("Id_Consultorio", OracleType.VarChar).Value = Tipo.CodigoConsultorio;
                    Comando.Parameters.Add("Tipo_Ide", OracleType.VarChar).Value = Tipo.TipoId;
                    Comando.Parameters.Add("Num_Ide", OracleType.VarChar).Value = Tipo.NumeroIdentificacion;
                    Comando.Parameters.Add("Id_CC", OracleType.VarChar).Value = Tipo.CodigoC;
                    Comando.Parameters.Add("Fecha_C", OracleType.DateTime).Value = Tipo.FechaConsulta;
                    Comando.Parameters.Add("Num_Au", OracleType.VarChar).Value = Tipo.NumeroAutorizacion;
                    Comando.Parameters.Add("Id_Fina", OracleType.VarChar).Value = Tipo.FinalidadConsulta;
                    Comando.Parameters.Add("Id_Causa", OracleType.VarChar).Value = Tipo.CausaExterna;
                    Comando.Parameters.Add("Id_Diag", OracleType.VarChar).Value = Tipo.CodDiagPpal;
                    Comando.Parameters.Add("Id_Diag1", OracleType.VarChar).Value = Tipo.CodDiaRel1;
                    Comando.Parameters.Add("Id_Diag2", OracleType.VarChar).Value = Tipo.CodDiaRel2;
                    Comando.Parameters.Add("Id_Diag3", OracleType.VarChar).Value = Tipo.CodDiaRel3;
                    Comando.Parameters.Add("Id_tipo", OracleType.VarChar).Value = Tipo.TipoDiagPpal;
                    Comando.Parameters.Add("VrlCons", OracleType.Number).Value = Tipo.ValorConsulta;
                    Comando.Parameters.Add("VrlCuota", OracleType.Number).Value = Tipo.ValorCuoMod;
                    Comando.Parameters.Add("VrlNeto", OracleType.Number).Value = Tipo.ValorNetoPagar;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                }
                return "Modificado Exitosamente";
            }
            catch (Exception e)
            {

                return "No se pudo Actualizar, ERROR Desconocido"+e.Message;
            }
        }
    }
}
