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
    public class RipsFacturas : Conexiones,Irips<Facturacion>
    {
        protected string ruta = "RipsFacturas.txt";
        Mapeadores mapp = new Mapeadores();
        public RipsFacturas(string connectionString) : base(connectionString)
        {
        }

        public string Generar(Facturacion Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Generado Correctamente";
        }
        public List<Facturacion> GetRips(DateTime Fecha)
        {
            List<Facturacion> Factura = new List<Facturacion>();
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Rips.FiltrarBill";
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
                Comando.Parameters.Add("fecha", OracleType.DateTime).Value = Fecha;
                Open();
                OracleDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Factura.Add(mapp.MapperFacturas(reader));
                }
                Close();
                return Factura;
            }
        }
    }
}
