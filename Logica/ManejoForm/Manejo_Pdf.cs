using Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Logica.ManejoForm
{
    public class Manejo_Pdf
    {
        

        public void Guardar(string idfactura, string nombrecliente, string idcliente, string fecha, string Autorizacion, string descripcion,
            string descuento, string total)
        {
            SaveFileDialog imprimir = new SaveFileDialog();
            imprimir.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + "FC.pdf";
            string pagina = Properties.Resources.muestra.ToString();
            pagina = pagina.Replace("@Numero", idfactura);
            pagina = pagina.Replace("@CLIENTE", nombrecliente);
            pagina = pagina.Replace("@DOCUMENTO", idcliente);
            pagina = pagina.Replace("@FECHA", fecha);

            string filas = string.Empty;
            double TotalF = 0.0;
            filas += "<tr>";
            filas += "<td>" + Autorizacion + "</td>";
            filas += "<td>" + descripcion + "</td>";
            filas += "<td>" + descuento + "</td>";
            filas += "<td>" + total + "</td>";
            filas += "</tr>";
            TotalF += double.Parse(total);

            pagina = pagina.Replace("@FILAS", filas);
            pagina = pagina.Replace("@TOTAL", TotalF.ToString());

            if (imprimir.ShowDialog() == DialogResult.OK)
            {
                string filePath = imprimir.FileName;
                string extension = Path.GetExtension(filePath);

                if (extension != ".pdf")
                {
                    filePath = Path.ChangeExtension(filePath, ".pdf");
                }

                using (FileStream stream = new FileStream(imprimir.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter pdf = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    incrustarhtml(pdf, pdfDoc,pagina);
                    pdfDoc.Close();
                    stream.Close();

                }
            }
        }
        private void incrustarhtml(PdfWriter writer, Document pdfdoc,string pagina)
        {
            try
            {
                
                using (StringReader stringReader = new StringReader(pagina))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfdoc, stringReader);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public void GuardarHistoria(HistoriaClinica registro)
        {
            SaveFileDialog imprimir = new SaveFileDialog();
            imprimir.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + "HC.pdf";
            string nombres = registro.PrimerNombre + " " + registro.PrimerApellido;
            string pagina = Properties.Resources.historia.ToString();
            pagina = pagina.Replace("[Fecha]", registro.Fecha.ToString());
            pagina = pagina.Replace("[Numero]", registro.CodigoConsultorio);
            pagina = pagina.Replace("[CLIENTE]", nombres);
            pagina = pagina.Replace("[DOCUMENTO]", registro.NumeroIdentificacion);
            pagina = pagina.Replace("[Tipo]", registro.TipoId);
            pagina = pagina.Replace("[Edad]", registro.Edad);
            pagina = pagina.Replace("[CodigoD]", registro.CodigoC);
            pagina = pagina.Replace("[Diagnostico]", registro.NombreDiagnostico);
            pagina = pagina.Replace("[Autorizacion]", registro.NumeroAutorizacion);
            pagina = pagina.Replace("[Tratamiento]", registro.Tratamiento);
            pagina = pagina.Replace("[Medicacion]", registro.Medicacion);
            if (imprimir.ShowDialog() == DialogResult.OK)
            {
                string filePath = imprimir.FileName;
                string extension = Path.GetExtension(filePath);

                if (extension != ".pdf")
                {
                    filePath = Path.ChangeExtension(filePath, ".pdf");
                }

                using (FileStream stream = new FileStream(imprimir.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter pdf = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    incrustarhtml(pdf, pdfDoc, pagina);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
