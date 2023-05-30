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
    public class RipsProcedimientos : Conexiones,Irips<Procedimiento>
    {
        Mapeadores mapp = new Mapeadores();
        protected string ruta = "RipsProcedimientos.txt";
        public RipsProcedimientos(string connectionString) : base(connectionString)
        {
        }
        public string Generar(Procedimiento Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Generado Correctamente";
        }
        public List<Procedimiento> GetRips(DateTime Fecha)
        {
            List<Procedimiento> procedimientos = new List<Procedimiento>();
            using (var Comando=conexion.CreateCommand())
            {
                Comando.CommandText = "Rips.FiltrarProcedimientos";
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
                Comando.Parameters.Add("fecha", OracleType.DateTime).Value = Fecha;
                Open();
                OracleDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    procedimientos.Add(mapp.MapperProcedimientos(reader));
                }
                Close();
                return procedimientos;
            }
        }
    }
}
