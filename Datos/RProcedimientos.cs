using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RProcedimientos : Conexiones,IReportes<Procedimiento>
    {
        public RProcedimientos(string connectionString) : base(connectionString)
        {
        }

        public string Guardar(Procedimiento Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = "InsertarProcedimiento";
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("Id_Procedimiento", OracleType.VarChar).Value = Tipo.CodigoC;
                    Comando.Parameters.Add("NumeroFactura", OracleType.VarChar).Value = Tipo.NumeroFactura;
                    Comando.Parameters.Add("CodigoC", OracleType.VarChar).Value = Tipo.CodigoConsultorio;
                    Comando.Parameters.Add("Tipo_Id", OracleType.VarChar).Value = Tipo.TipoId;
                    Comando.Parameters.Add("Num_Id", OracleType.VarChar).Value = Tipo.NumeroIdentificacion;
                    Comando.Parameters.Add("Fecha_P", OracleType.DateTime).Value = Tipo.FechaProcedimiento;
                    Comando.Parameters.Add("Num_Au", OracleType.VarChar).Value = Tipo.NumeroAutorizacion;
                    Comando.Parameters.Add("Id_Ambito", OracleType.VarChar).Value = Tipo.AmbitoRealProce;
                    Comando.Parameters.Add("Id_Finalidad", OracleType.VarChar).Value = Tipo.FinalidadProce;
                    Comando.Parameters.Add("personaA", OracleType.VarChar).Value = Tipo.PersonalAti;
                    Comando.Parameters.Add("Id_DiagP", OracleType.VarChar).Value = Tipo.DiagnosticoPpal;
                    Comando.Parameters.Add("Id_Forma", OracleType.VarChar).Value = Tipo.FormaRealiActo;
                    Comando.Parameters.Add("Valor_Pr", OracleType.Number).Value = Tipo.VrlProcedimiento;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                }
                return "Guardado Correctamente";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public Procedimiento Mapper(OracleDataReader dataReader)
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
        public string Modificar(Procedimiento Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = "ACTUALIZARPROCEDIMIENTOS";
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("Id_Procedimiento", OracleType.VarChar).Value = Tipo.CodigoC;
                    Comando.Parameters.Add("NumeroFactura", OracleType.VarChar).Value = Tipo.NumeroFactura;
                    Comando.Parameters.Add("CodigoC", OracleType.VarChar).Value = Tipo.CodigoConsultorio;
                    Comando.Parameters.Add("Tipo_Id", OracleType.VarChar).Value = Tipo.TipoId;
                    Comando.Parameters.Add("Num_Id", OracleType.VarChar).Value = Tipo.NumeroIdentificacion;
                    Comando.Parameters.Add("Fecha_P", OracleType.DateTime).Value = Tipo.FechaProcedimiento.Date;
                    Comando.Parameters.Add("Num_Au", OracleType.VarChar).Value = Tipo.NumeroAutorizacion;
                    Comando.Parameters.Add("Id_Ambito", OracleType.VarChar).Value = Tipo.AmbitoRealProce;
                    Comando.Parameters.Add("Id_Finalidad", OracleType.VarChar).Value = Tipo.FinalidadProce;
                    Comando.Parameters.Add("personaA", OracleType.VarChar).Value = Tipo.PersonalAti;
                    Comando.Parameters.Add("Id_DiagP", OracleType.VarChar).Value = Tipo.DiagnosticoPpal;
                    Comando.Parameters.Add("Id_Forma", OracleType.VarChar).Value = Tipo.FormaRealiActo;
                    Comando.Parameters.Add("Valor_Pr", OracleType.Number).Value = Tipo.VrlProcedimiento;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                }
                return "El Procedimiento con id Num: " + Tipo.CodigoC + " Ha sido Modificaco";
            }
            catch (Exception e )
            {

                return e.Message;
            }
        }

        public string Eliminar(Procedimiento Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = $"DELETE FROM PROCEDIMIENTOS WHERE ID_PROCEDIMIENTO={Tipo.CodigoC}";
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

        public List<Procedimiento> GetAll()
        {
            List<Procedimiento> consulta = new List<Procedimiento>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "select * from Procedimientos";
            Open();
            OracleDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                consulta.Add(Mapper(lector));
            }
            Close();
            return consulta;
        }
    }
}
