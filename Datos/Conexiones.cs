using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace Datos
{
    public  class Conexiones
    {
        protected OracleConnection conexion;

        public Conexiones(string connectionString)
        {
            conexion = new OracleConnection(connectionString);
        }
        public void Open()
        {
            conexion.Open();
        }
        public void Close()
        {
            conexion.Close();
        }
    }
}
