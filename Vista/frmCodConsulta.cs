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
    public partial class frmCodConsulta : Form
    {
        ConfCConsultas codigo = new ConfCConsultas();
        public frmCodConsulta()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtCodCons.Text = "";
        }
        private void agregarCod()
        {
            var tipo = new CodConsulta();
            tipo.CConsulta = txtCodCons.Text;
            string msg = codigo.Crear(tipo);
            MessageBox.Show(msg);
            limpiar();
            ListaCodConsultas.Items.Add(tipo);
        }
        private void modificarCod()
        {
            var tipoN = new CodConsulta();
            var tipoV = codigo.ObtenerPorId(txtCodCons.Text);
            if (tipoV == null)
            {
                MessageBox.Show("Tipo de dato inexistente");
            }
            else
            {
                tipoN.CConsulta = txtCodCons.Text;
                string msg = codigo.Actualizar(tipoV, tipoN);
                MessageBox.Show(msg);
                limpiar();
            }
        }
        private void eliminarCod()
        {
            var cod = new CodConsulta();
            cod.CConsulta = txtCodCons.Text;
            string msg = codigo.Eliminar(cod);
            MessageBox.Show(msg);
            limpiar();
        }
        private void mandarlist()
        {
            // CODIGO DE CONSULTAS
            foreach (var item in codigo.ObtenerTodos())
            {
                txtCodCons.Text = item.CConsulta;
                ListaCodConsultas.Items.Add(txtCodCons.Text);
            }
            limpiar();
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            agregarCod();
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            modificarCod();
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            eliminarCod();
        }

        private void ListaCodConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodCons.Text=ListaCodConsultas.Text.Trim();
        }

        private void frmCodConsulta_Load(object sender, EventArgs e)
        {
            mandarlist();
        }
    }
}
