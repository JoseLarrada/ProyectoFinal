using Entidades;
using Logica;
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
    public partial class frmConfiguraciones : Form
    {
        Configuraciones ID= new Configuraciones();
        
        public frmConfiguraciones()
        {
            InitializeComponent();
        }
        private void guardar()
        {
            var tipo = new TipoDatos();
            tipo.NombreTipo = TxtTipo.Text;
            string msg = ID.Crear(tipo);
            MessageBox.Show(msg);
            limpiar();
            ListaTipos.Items.Add(tipo);
        }
        private void modificar()
        {
            var tipoN = new TipoDatos();
            var tipoV = ID.ObtenerPorId(TxtTipo.Text);
            if (tipoV==null) 
            {
                MessageBox.Show("Tipo de dato inexistente");
            }
            else
            {
                tipoN.NombreTipo=TxtTipo.Text;
                string msg= ID.Actualizar(tipoV,tipoN);
                MessageBox.Show(msg);
                limpiar();
            }
        }
        private void limpiar()
        {
            TxtTipo.Text = "";
        }
        private void eliminar()
        {
            var tipo= new TipoDatos();
            tipo.NombreTipo = TxtTipo.Text;
            string msg=ID.Eliminar(tipo);
            MessageBox.Show(msg);
            limpiar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void frmConfiguraciones_Load(object sender, EventArgs e)
        {
            foreach (var item in ID.ObtenerTodos())
            {
                TxtTipo.Text = item.NombreTipo;
                ListaTipos.Items.Add(TxtTipo.Text);
            }
        }

        private void ListaTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTipo.Text=ListaTipos.Text.Trim();
        }        
        private void btnAgregar2_Click(object sender, EventArgs e)
        {
        }
        private void btnModificar2_Click(object sender, EventArgs e)
        {
        }
        private void ListaCodConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnEliminar2_Click(object sender, EventArgs e)
        {
        }
    }
}
