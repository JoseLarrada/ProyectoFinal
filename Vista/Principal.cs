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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnConsultas_Click_1(object sender, EventArgs e)
        {
            PanelVista.Visible = true;
            abrirForm(new FrmConsultas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPacientes_Click_1(object sender, EventArgs e)
        {
            
            abrirForm(new FmrPacieentes());
            PanelVista.Visible = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            PanelVista.Visible=false;
        }
        private void abrirForm(object form)
        {
            if (this.PanelVista.Controls.Count > 0)
            {
                this.PanelVista.Controls.RemoveAt(0);
            }
            Form view = form as Form;
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            this.PanelVista.Controls.Add(view);
            this.PanelVista.Tag=view;
            view.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelVista.Visible = true;
            abrirForm(new FrmProcedimientos());
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            PanelVista.Visible = true;
            abrirForm(new FmrFacturacion());
        }

        private void btnHistoriasClinicas_Click(object sender, EventArgs e)
        {
            PanelVista.Visible = true;
            abrirForm(new FmrHistorias());
        }

        private void BtnRips_Click(object sender, EventArgs e)
        {
            PanelVista.Visible = true;
            abrirForm(new FmrInformes());
        }

        private void btnVistas_Click(object sender, EventArgs e)
        {
            PanelVista.Visible = true;
            abrirForm(new FmrVistas());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
