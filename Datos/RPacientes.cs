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
    public class RPacientes : Conexiones,IReportes<Pacientes>
    {
        public RPacientes(string connectionString) : base(connectionString)
        {
        }

        public string Guardar(Pacientes Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = "InsertarUsuarios";
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("NumId", OracleType.VarChar).Value = Tipo.NumeroId;
                    Comando.Parameters.Add("tipoId", OracleType.VarChar).Value = Tipo.TipoId;
                    Comando.Parameters.Add("edad", OracleType.VarChar).Value = Tipo.Edad;
                    Comando.Parameters.Add("p_Nombre", OracleType.VarChar).Value = Tipo.PrimerNombre;
                    Comando.Parameters.Add("s_Nombre", OracleType.VarChar).Value = Tipo.SegundoNombre;
                    Comando.Parameters.Add("p_Apellido", OracleType.VarChar).Value = Tipo.PrimerApellido;
                    Comando.Parameters.Add("s_Apellido", OracleType.VarChar).Value = Tipo.SegundoApellido;
                    Comando.Parameters.Add("u_Edad", OracleType.VarChar).Value = Tipo.UnidadMedidaEdad;
                    Comando.Parameters.Add("TipoU", OracleType.VarChar).Value = Tipo.TipoUsuario;
                    Comando.Parameters.Add("sexo", OracleType.VarChar).Value = Tipo.Sexo;
                    Comando.Parameters.Add("departamento", OracleType.VarChar).Value = Tipo.CodigoDepartamentosResidencia;
                    Comando.Parameters.Add("municipio", OracleType.VarChar).Value = Tipo.CodigoMunicipioResidencia;
                    Comando.Parameters.Add("zona", OracleType.VarChar).Value = Tipo.ZonaResidencia;
                    Comando.Parameters.Add("consultorio", OracleType.VarChar).Value = Tipo.CodigoConsultorio;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                }
                return "Guardado Correctamente";
            }
            catch (Exception E)
            {

                return "No se pudo Actualizar, ERROR Desconocido: " + E.Message;
            }
        }
        public Pacientes Mapper(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Pacientes consulta = new Pacientes();
            consulta.NumeroId = dataReader.GetString(0);
            consulta.TipoId = dataReader.GetString(1);
            consulta.Edad = dataReader.GetString(2);
            consulta.PrimerNombre = dataReader.GetString(3);
            consulta.SegundoNombre = dataReader.GetString(4);
            consulta.PrimerApellido = dataReader.GetString(5);
            consulta.SegundoApellido = dataReader.GetString(6);
            consulta.UnidadMedidaEdad = dataReader.GetString(7);
            consulta.TipoUsuario = dataReader.GetString(8);
            consulta.Sexo = dataReader.GetString(9);
            consulta.CodigoDepartamentosResidencia = dataReader.GetString(10);
            consulta.CodigoMunicipioResidencia = dataReader.GetString(11);
            consulta.ZonaResidencia = dataReader.GetString(12);
            consulta.CodigoConsultorio = dataReader.GetString(13);
            return consulta;
        }
        public string Modificar(Pacientes Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = "ActualizarUsuario";
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("NUM_IDE", OracleType.VarChar).Value = Tipo.NumeroId;
                    Comando.Parameters.Add("TIPO_IDE", OracleType.VarChar).Value = Tipo.TipoId;
                    Comando.Parameters.Add("EDAD", OracleType.VarChar).Value = Tipo.Edad;
                    Comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = Tipo.PrimerNombre;
                    Comando.Parameters.Add("S_NOMBRE", OracleType.VarChar).Value = Tipo.SegundoNombre;
                    Comando.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = Tipo.PrimerApellido;
                    Comando.Parameters.Add("S_APELLIDO", OracleType.VarChar).Value = Tipo.SegundoApellido;
                    Comando.Parameters.Add("UNIDAD", OracleType.VarChar).Value = Tipo.UnidadMedidaEdad;
                    Comando.Parameters.Add("TIPO_U", OracleType.VarChar).Value = Tipo.TipoUsuario;
                    Comando.Parameters.Add("SEXO", OracleType.VarChar).Value = Tipo.Sexo;
                    Comando.Parameters.Add("DEPARTAMENTO", OracleType.VarChar).Value = Tipo.CodigoDepartamentosResidencia;
                    Comando.Parameters.Add("MUNICIPIO", OracleType.VarChar).Value = Tipo.CodigoMunicipioResidencia;
                    Comando.Parameters.Add("ZONA", OracleType.VarChar).Value = Tipo.ZonaResidencia;
                    Comando.Parameters.Add("CONSULTORIO", OracleType.VarChar).Value = Tipo.CodigoConsultorio;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                }
                return "Modificado con exito";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public string Eliminar(Pacientes Tipo)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandText = $"DELETE FROM USUARIOS WHERE NUM_IDENTIFICACION={Tipo.NumeroId}";
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

        public List<Pacientes> GetAll()
        {
            List<Pacientes> consulta = new List<Pacientes>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "select * from USUARIOS";
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
