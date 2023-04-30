using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RProcedimientos : IReportes<Procedimiento>
    {
        string ruta = "ReporteProcedimientos.txt";
        public RProcedimientos(string ruta)
        {
            this.ruta = ruta;
        }
        public RProcedimientos()
        {
            
        }
        public string GuardarContactos(Procedimiento Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Guardado Correctamente";
        }

        public Procedimiento mapear(string linea)
        {
            var tratamiento = new Procedimiento
            {
                NumeroFactura = linea.Split(';')[0],
                CodigoConsultorio = linea.Split(';')[1],
                TipoId = linea.Split(';')[2],
                NumeroIdentificacion = linea.Split(';')[3],
                CodigoC = linea.Split(';')[4],
                FechaProcedimiento = DateTime.Parse(linea.Split(';')[5]),
                NumeroAutorizacion = linea.Split(';')[6],
                AmbitoRealProce = linea.Split(';')[7],
                FinalidadProce = linea.Split(';')[8],
                PersonalAti = linea.Split(';')[9],
                DiagnosticoPpal = linea.Split(';')[10],
                CodigoDiagPpal = linea.Split(';')[11],
                FormaRealiActo = linea.Split(';')[12],
                VrlProcedimiento = double.Parse(linea.Split(';')[13])
            };
            return tratamiento;
        }

        public string Modificar_Eliminar(List<Procedimiento> listaActualizada)
        {
            string rutaTmp = "tmp.txt";
            try
            {
                var sw = new StreamWriter(rutaTmp);

                foreach (var item in listaActualizada)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
                File.Delete(ruta);
                File.Move(rutaTmp, ruta);
                return "Se actualizo el archivo";
            }

            catch (Exception)
            {
                return "Error al actualizar";

            }
        }

        public List<Procedimiento> ObtenerLista()
        {
            StreamReader sr;
            var lista = new List<Procedimiento>();
            try
            {
                sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    lista.Add(mapear(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {
                //sr.Close();
                return null;
            }
            finally { sr = null; }
        }
    }
}
