using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Informes : Conexiones
    {
        public Informes(string connectionString) : base(connectionString)
        {
        }

        public string InformesConsultas(List<Consultas> lista)
        {
            Document documento = new Document();
            try
            {
                PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream("InformeConsultas.pdf", FileMode.Create));
                documento.Open();
                foreach (var item in lista)
                {
                    documento.Add(new Paragraph(item.ToString()));
                }
                return "Generado Correctamente";
            }
            catch (Exception ex)
            {
                return("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                documento.Close();
            }
        }
        public string InformesProcedimientos(List<Procedimiento> lista)
        {
            Document documento = new Document();
            try
            {
                PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream("InformeProcedimientos.pdf", FileMode.Create));
                documento.Open();
                foreach (var item in lista)
                {
                    documento.Add(new Paragraph(item.ToString()));
                }
                return "Generado Correctamente";
            }
            catch (Exception ex)
            {
               return ("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                documento.Close();
            }
        }
        public string InformesFacturas(List<Facturacion> lista)
        {
            Document documento = new Document();
            try
            {
                PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream("InformeFacturas.pdf", FileMode.Create));
                documento.Open();
                foreach (var item in lista)
                {
                    documento.Add(new Paragraph(item.ToString()));
                }
                return "Generado Correctamente";
            }
            catch (Exception ex)
            {
                return "Error al generar el PDF: " + ex.Message;
            }
            finally
            {
                documento.Close();
            }
        }
        public string InformesHistorias(List<HistoriaClinica> lista)
        {
            Document documento = new Document();
            try
            {
                PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream("InformeHistorias.pdf", FileMode.Create));
                documento.Open();
                foreach (var item in lista)
                {
                    documento.Add(new Paragraph(item.ToString()));
                }
                return "Generado Correctamente";
            }
            catch (Exception ex)
            {
                return "Error al generar el PDF: " + ex.Message;
            }
            finally
            {
                documento.Close();
            }
        }

    }
}
