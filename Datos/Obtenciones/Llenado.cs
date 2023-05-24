using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos.Obtenciones
{
    public class Llenado : Conexiones
    {
        public Llenado(string connectionString) : base(connectionString)
        {
        }
        public void LlenarCombobox(ComboBox comboBox,string NombreAtributo,string NombreTabla)
        {
            var comando = conexion.CreateCommand();
            comando.CommandText = $"select {NombreAtributo} from {NombreTabla}";
            Open();
            OracleDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBox.Items.Add(lector.GetString(0));
            }
            Close();
        }
        public void filtrarciudades(ComboBox ciudad, string filtrar)
        {
            try
            {
                var comando = conexion.CreateCommand();
                comando.CommandText = "filtrar_Muni2";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("filtro", OracleType.VarChar).Value = filtrar;
                comando.Parameters.Add("mostrar", OracleType.Cursor).Direction = ParameterDirection.Output;
                Open();
                comando.ExecuteNonQuery();
                OracleDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    ciudad.Items.Add(reader.GetString(0));
                }
                Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
    }
}
