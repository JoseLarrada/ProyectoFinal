using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ArchivoTexto
{
    public class RipsConsultas: Conexiones,Irips<Consultas>
    {
        protected string ruta = "RipsConsultas.txt";
        Mapeadores mapp = new Mapeadores();
        public RipsConsultas(string connectionString) : base(connectionString)
        {
        }

        public string Generar(Consultas Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Generado Correctamente";
        }

        public List<Consultas> GetRips(DateTime Fecha)
        {
            List<Consultas> consulta= new List<Consultas>();
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Rips.FiltrarConsultas";
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
                Comando.Parameters.Add("fecha", OracleType.DateTime).Value = Fecha;
                Open();
                OracleDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    consulta.Add(mapp.MapperConsultas(reader));
                }
                Close();
                return consulta;
            }
        }
    }
}
