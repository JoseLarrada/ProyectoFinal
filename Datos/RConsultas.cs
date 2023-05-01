using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RConsultas : IReportes<Consultas>
    {
        string ruta = "ReporteConsulta.txt";
        public RConsultas(string ruta)
        {
            this.ruta = ruta;
        }
        public RConsultas()
        {
            
        }
        public string Guardar(Consultas Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Guardado Correctamente";
        }

        public Consultas mapear(string linea)
        {
            var Consulta = new Consultas
            {
                NumeroFactura = linea.Split(';')[0],
                CodigoConsultorio = linea.Split(';')[1],
                TipoId = linea.Split(';')[2],
                NumeroIdentificacion = linea.Split(';')[3],
                FechaConsulta = DateTime.Parse(linea.Split(';')[4]),
                NumeroAutorizacion = linea.Split(';')[5],
                CodigoC = linea.Split(';')[6],
                FinalidadConsulta = linea.Split(';')[7],
                CausaExterna = linea.Split(';')[8],
                CodDiagPpal = linea.Split(';')[9],
                CodDiaRel1 = linea.Split(';')[10],
                CodDiaRel2 = linea.Split(';')[11],
                CodDiaRel3 = linea.Split(';')[12],
                TipoDiagPpal = linea.Split(';')[13],
                ValorConsulta = double.Parse(linea.Split(';')[14]),
                ValorCuoMod = double.Parse(linea.Split(';')[15]),
                ValorNetoPagar = double.Parse(linea.Split(';')[16])

            };
            return Consulta;
        }

        public string Modificar_Eliminar(List<Consultas> listaActualizada)
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

        public List<Consultas> ObtenerLista()
        {
            StreamReader sr;
            var lista = new List<Consultas>();
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
