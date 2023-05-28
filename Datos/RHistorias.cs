using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RHistorias : Conexiones, IReportes<HistoriaClinica>
    {
        public RHistorias(string connectionString) : base(connectionString)
        {
        }

        public string Eliminar(HistoriaClinica Tipo)
        {
            throw new NotImplementedException();
        }

        public List<HistoriaClinica> GetAll()
        {
            List<HistoriaClinica> factura = new List<HistoriaClinica>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "select * from historia_clinica";
            Open();
            OracleDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                factura.Add(Mapper(lector));
            }
            Close();
            return factura;
        }

        public string Guardar(HistoriaClinica Tipo)
        {
            try
            {
                using (var Comando=conexion.CreateCommand())
                {
                    Comando.CommandText = "INSERTARHISTORIA";
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.Parameters.Add("idHisto", OracleType.VarChar).Value = Tipo.CodigoConsultorio;
                    Comando.Parameters.Add("TipoId", OracleType.VarChar).Value = Tipo.TipoId;
                    Comando.Parameters.Add("NumId", OracleType.VarChar).Value = Tipo.NumeroIdentificacion;
                    Comando.Parameters.Add("IdDiag", OracleType.VarChar).Value = Tipo.CodigoC;
                    Comando.Parameters.Add("Edad", OracleType.VarChar).Value = Tipo.Edad;
                    Comando.Parameters.Add("fechaExpe", OracleType.DateTime).Value = Tipo.Fecha;
                    Comando.Parameters.Add("primerNom", OracleType.VarChar).Value = Tipo.PrimerNombre;
                    Comando.Parameters.Add("primerApellido", OracleType.VarChar).Value = Tipo.PrimerApellido;
                    Comando.Parameters.Add("Nom_Diag", OracleType.VarChar).Value = Tipo.NombreDiagnostico;
                    Comando.Parameters.Add("NumAut", OracleType.VarChar).Value = Tipo.NumeroAutorizacion;
                    Comando.Parameters.Add("Tratmiento", OracleType.VarChar).Value = Tipo.Tratamiento;
                    Comando.Parameters.Add("Medicina", OracleType.VarChar).Value = Tipo.Medicacion;
                    Open();
                    Comando.ExecuteNonQuery();
                    Close();
                    return "Generada Correctamente";
                }
            }
            catch (Exception E)
            {

                return "No se pudo Generar La Historia Clinica"+E.Message;
            }
        }

        public HistoriaClinica Mapper(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            HistoriaClinica historia = new HistoriaClinica();
            historia.NumeroFactura = dataReader.GetString(0);
            historia.TipoId = dataReader.GetString(1);
            historia.NumeroIdentificacion = dataReader.GetString(2);
            historia.CodigoC = dataReader.GetString(3);
            historia.Edad = dataReader.GetString(4);
            historia.Fecha = dataReader.GetDateTime(5);
            historia.PrimerNombre = dataReader.GetString(6);
            historia.PrimerApellido = dataReader.GetString(7);
            historia.NombreDiagnostico = dataReader.GetString(8);
            historia.NumeroAutorizacion = dataReader.GetString(9);
            historia.Tratamiento = dataReader.GetString(10);
            historia.Medicacion = dataReader.GetString(11);
            return historia;
        }

        public string Modificar(HistoriaClinica Tipo)
        {
            throw new NotImplementedException();
        }
    }
}
