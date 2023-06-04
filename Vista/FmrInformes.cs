using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FmrInformes : Form
    {
        Logica.ServicioRips rips = new Logica.ServicioRips(ConfigConnection.connectionString);
        Logica.ServicioConsultas consulta=new Logica.ServicioConsultas(ConfigConnection.connectionString);
        Logica.ServicioFacturacion facturacion=new Logica.ServicioFacturacion(ConfigConnection.connectionString);
        Logica.ServicioHistoriaClinica clinica=new Logica.ServicioHistoriaClinica(ConfigConnection.connectionString);
        Logica.ServicioProcedimientos procedimientos=new Logica.ServicioProcedimientos(ConfigConnection.connectionString);
        public FmrInformes()
        {
            InitializeComponent();
        }
        private void generarConsulta()
        {
           
            
                DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string msg = rips.GenerarConsultas(Fechas.Value);
                    MessageBox.Show(msg);
                    
                }
                else if (result == DialogResult.Cancel)
                {
                    
                }
            
        }
        private void generarProcedimiento()
        {
            
            
                DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string msg = rips.GenerarProcedimiento(Fechas.Value);
                    MessageBox.Show(msg);
                }
                else if (result == DialogResult.Cancel)
                {
                }
            
        }
        private void GenerarFactura()
        {
           DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
           if (result == DialogResult.OK)
           {
                string msg = rips.GenerarFactura(Fechas.Value);
                MessageBox.Show(msg);
           }
           else if (result == DialogResult.Cancel)
           {
                MessageBox.Show("MUCHAS GRACIAS");
           }
            
        }

        private void cbbConsultas_CheckedChanged(object sender, EventArgs e)
        {
            generarConsulta();
        }

        private void cbbProcedimientos_CheckedChanged(object sender, EventArgs e)
        {
            generarProcedimiento();
        }

        private void cbbFacturas_CheckedChanged(object sender, EventArgs e)
        {
            GenerarFactura();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            generarConsulta();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            GenerarFactura();
        }

        private void btnProcedimientos_Click(object sender, EventArgs e)
        {
            generarProcedimiento();
        }

        private void btnConsultasR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string msg = consulta.GenerarPDF();
                MessageBox.Show(msg);

            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void btnProcedimientosR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string msg = procedimientos.GenerarPdf();
                MessageBox.Show(msg);

            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void btnFacturasR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string msg = facturacion.GenerarPdf();
                MessageBox.Show(msg);

            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void btnHistoriasR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string msg = clinica.GenerarPDF();
                MessageBox.Show(msg);

            }
            else if (result == DialogResult.Cancel)
            {

            }
        }
    }
}
