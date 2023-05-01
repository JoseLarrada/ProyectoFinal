using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DatosPrederminados
{
    public class CodigoConsulta
    {
        string ruta = "CodigoConsulta.txt";
        public CodigoConsulta(string ruta)
        {
            this.ruta = ruta;
        }
        public CodigoConsulta()
        {

        }

        public string Guardar(CodConsulta Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Guardado Correctamente";
        }

        public List<CodConsulta> ObtenerLista()
        {
            StreamReader sr;
            var lista = new List<CodConsulta>();
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

        public string Modificar_Eliminar(List<CodConsulta> listaActualizada)
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
                return "Se actualizo el Paciente";
            }

            catch (Exception)
            {
                return "Error al actualizar";

            }
        }

        public CodConsulta mapear(string linea)
        {
            var dato = new CodConsulta
            {
                CConsulta = linea.Split(';')[0],
            };
            return dato;
        }
    }
}
