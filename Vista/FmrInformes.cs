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
        public FmrInformes()
        {
            InitializeComponent();
        }
        private void generarConsulta()
        {
            if (cbbConsultas.Checked == true)
            {
                DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string msg = rips.GenerarConsultas(Fechas.Value);
                    MessageBox.Show(msg);
                    cbbConsultas.Checked = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    cbbConsultas.Checked = false;
                }
            }
        }
        private void generarProcedimiento()
        {
            if (cbbProcedimientos.Checked == true)
            {
                DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string msg = rips.GenerarProcedimiento(Fechas.Value);
                    MessageBox.Show(msg);
                    cbbProcedimientos.Checked = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    cbbProcedimientos.Checked = false;
                }
            }
        }
        private void GenerarFactura()
        {
            if (cbbFacturas.Checked == true)
            {
                DialogResult result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string msg = rips.GenerarFactura(Fechas.Value);
                    MessageBox.Show(msg);
                    cbbFacturas.Checked = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    cbbFacturas.Checked = false;
                }
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
    }
}
