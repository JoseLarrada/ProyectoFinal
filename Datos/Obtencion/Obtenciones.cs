﻿using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Datos.Obtencion_de_Id
{
    public class Obtenciones:Conexiones
    {
        public Obtenciones(string connectionString) : base(connectionString)
        {
        }

        public string obtenerId(string Nombre,string procedimiento)
        {
            try
            {
                string NombreRecibido=null;
                using (var Comando = conexion.CreateCommand())
                {
                    Open();
                    Comando.CommandText = procedimiento;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("mostrar",OracleType.Cursor).Direction = ParameterDirection.Output;
                    Comando.Parameters.Add("nombre", OracleType.VarChar).Value = Nombre;
                    OracleDataReader reader = Comando.ExecuteReader();
                    while (reader.Read())
                    {
                        NombreRecibido = reader.GetString(0);
                    }
                    Close();
                    return NombreRecibido;
                }
            }
            catch (Exception e)
            {

                return(e.Message);
            }
        }

        public string LlamadoGlobal(string id,string procedimiento)
        {
            try
            {
                string idRecibido = null;
                using (var Comando = conexion.CreateCommand())
                {
                    Open();
                    Comando.CommandText = procedimiento;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
                    Comando.Parameters.Add("id", OracleType.VarChar).Value = id;
                    OracleDataReader lector = Comando.ExecuteReader();
                    while (lector.Read())
                    {
                        idRecibido = lector.GetString(0);
                    }
                    Close();
                    return idRecibido;
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
            
        }
        public string ObtencionGlobal(string procedimiento)
        {
            try
            {
                int idRecibido = 0;
                using (var Comando = conexion.CreateCommand())
                {
                    Open();
                    Comando.CommandText = procedimiento;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
                    OracleDataReader lector = Comando.ExecuteReader();
                    while (lector.Read())
                    {
                        idRecibido = lector.GetInt32(0);
                    }
                    Close();
                    return idRecibido.ToString();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<string> ObtencionPrimerCampo(string procedimiento)
        {
            try
            {
                List<string> NombreDiagnostico =new List<string>();
                using (var Comando = conexion.CreateCommand())
                {
                    Open();
                    Comando.CommandText = procedimiento;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
                    OracleDataReader lector = Comando.ExecuteReader();
                    while (lector.Read())
                    {
                        NombreDiagnostico.Add(lector.GetString(0));
                    }
                    Close();
                    return NombreDiagnostico;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<int> ObtencionSegundoCampo(string procedimiento)
        {
            try
            {
                List<int> Cantidad = new List<int>();
                using (var Comando = conexion.CreateCommand())
                {
                    Open();
                    Comando.CommandText = procedimiento;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
                    OracleDataReader lector = Comando.ExecuteReader();
                    while (lector.Read())
                    {
                        
                        Cantidad.Add(lector.GetInt32(1));
                    }
                    Close();
                    return Cantidad;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
