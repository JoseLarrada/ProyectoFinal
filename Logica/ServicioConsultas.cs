using Datos;
using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Crmf;

namespace Logica
{
    public class ServicioConsultas : Idatos<Consultas>
    {
        List<Consultas> Listconsulta =new List<Consultas>();
        Datos.RConsultas repositorio;
        public ServicioConsultas(string conexion)
        {
            repositorio = new Datos.RConsultas(conexion);
        }
        public string Actualizar(Consultas Consulta)
        {
            try
            {
                return repositorio.Modificar(Consulta) + "  " + Consulta.NumeroAutorizacion;
            }
            catch (Exception)
            {
                return "NO SE PUDO MODIFICAR";
            }
        }

        public string Crear(Consultas cliente)
        {
            try
            {
                if(nulos(cliente))
                {
                    return "RELLENE LOS DATOS";
                }
                if (ExisteConsulta(cliente.NumeroAutorizacion))
                {
                    return "Ya existe una consulta asociada a este numero";
                }
                else
                {
                    return repositorio.Guardar(cliente);
                }
                
            }
            catch (Exception e)
            {

                return "No se puede crear la consulta  "+e.Message;
            }
        }

        public string Eliminar(Consultas cliente)
        {
            if (!ExisteConsulta(cliente.NumeroAutorizacion))
            {
                return "NO SE ENCONTRO LA CONSULTA";
            }
            else
            {
                string resp = repositorio.Eliminar(cliente);
                return resp;
            }
        }

        public bool ExisteConsulta(string numeroauto)
        {
            try
            {
                if (repositorio.GetAll() == null)
                {
                    return false;
                }
                else
                {
                    foreach (var item in ObtenerTodos())
                    {
                        if (item.NumeroAutorizacion == numeroauto)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Consultas ObtenerPorId(string identificacion)
        {
            foreach (var item in Listconsulta)
            {
                if (item.NumeroIdentificacion == identificacion)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Consultas> ObtenerTodos()
        {
            return repositorio.GetAll();
        }
        public void GenerarPDF()
        {
            // Crear un documento PDF
            Document documento = new Document();

            try
            {
                // Crear un escritor de PDF
                PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream("InformeConsultas.pdf", FileMode.Create));

                // Abrir el documento
                documento.Open();

                // Agregar contenido al documento
                foreach (var item in ObtenerTodos())
                {
                    // Agregar un párrafo con el registro al documento
                    documento.Add(new Paragraph(item.ToString()));
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                Console.WriteLine("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                // Cerrar el documento
                documento.Close();
            }
        }
        public bool nulos(Consultas cliente)
        {
            if (string.IsNullOrEmpty(cliente.NumeroFactura) || string.IsNullOrEmpty(cliente.TipoId) || string.IsNullOrEmpty(cliente.NumeroIdentificacion) || string.IsNullOrEmpty(cliente.FechaConsulta.ToString()) ||
                string.IsNullOrEmpty(cliente.NumeroAutorizacion) || string.IsNullOrEmpty(cliente.CodigoC) || string.IsNullOrEmpty(cliente.FinalidadConsulta) || string.IsNullOrEmpty(cliente.CausaExterna) ||
                string.IsNullOrEmpty(cliente.CodDiagPpal) || string.IsNullOrEmpty(cliente.TipoDiagPpal) || string.IsNullOrEmpty(cliente.ValorConsulta.ToString()) || string.IsNullOrEmpty(cliente.ValorCuoMod.ToString()) 
                || string.IsNullOrEmpty(cliente.ValorNetoPagar.ToString()))
            {
                return true;
            }
            return false;
        }
        public double total(string Valor_N,string cuotas)
        {
            if (double.Parse(cuotas) <= 0)
            {
                return double.Parse(Valor_N);
            }
            else
            {
                double total= Math.Round(double.Parse(Valor_N) / double.Parse(cuotas));
                return total;
            }
        }
        public string cuotas(int cuotas)
        {
            if (cuotas>48)
            {
                return "-1";
            }
            else
            {
                return cuotas.ToString();
            }
        }
    }
}
