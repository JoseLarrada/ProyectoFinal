using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RFacturacion : IReportes<Facturacion>
    {
        string ruta = "ReporteFacturas.txt";
        public RFacturacion(string ruta)
        {
            this.ruta = ruta;
        }
        public RFacturacion()
        {
            
        }
        public string Guardar(Facturacion Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Guardado Correctamente";
        }

        public Facturacion mapear(string linea)
        {
            var Factura = new Facturacion
            {
                CodigoConsultorio = linea.Split(';')[0],
                NombrePrestador = linea.Split(';')[1],
                TipoId = linea.Split(';')[2],
                NumeroIdentificacion = linea.Split(';')[3],
                NumeroFactura = linea.Split(';')[4],
                FechaExpedicion = DateTime.Parse(linea.Split(';')[5]),
                FechaInicio = DateTime.Parse(linea.Split(';')[6]),
                FechaFinal = DateTime.Parse(linea.Split(';')[7]),
                CodigoC = linea.Split(';')[8],
                NombreConsultorio = linea.Split(';')[9],
                NumeroContrato = linea.Split(';')[10],
                PlanBeneficios = linea.Split(';')[11],
                NumeroPoliza = linea.Split(';')[12],
                VrlTotCo = double.Parse(linea.Split(';')[13]),
                VrlComision = double.Parse(linea.Split(';')[14]),
                VrlTDescuento = double.Parse(linea.Split(';')[15]),
                VrlNetoP = double.Parse(linea.Split(';')[16])
            };
            return Factura;
        }

        public string Modificar_Eliminar(List<Facturacion> listaActualizada)
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

        public List<Facturacion> ObtenerLista()
        {
            StreamReader sr;
            var lista = new List<Facturacion>();
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

        public string Modificar(Facturacion Tipo)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(Facturacion Tipo)
        {
            throw new NotImplementedException();
        }

        public List<Facturacion> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
