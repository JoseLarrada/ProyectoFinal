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
        ConfCConsultas codigo = new ConfCConsultas();
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
            txtCodCons.Text = "";
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
            mandarlist();
        }

        private void ListaTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTipo.Text=ListaTipos.Text.Trim();
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
            cod.CConsulta=txtCodCons.Text;
            string msg= codigo.Eliminar(cod);
            MessageBox.Show(msg);
            limpiar();
        }
        private void mandarlist()
        {
            foreach (var item in ID.ObtenerTodos())
            {
                TxtTipo.Text = item.NombreTipo;
                ListaTipos.Items.Add(TxtTipo.Text);
            }

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

        private void ListaCodConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodCons.Text = ListaCodConsultas.Text.Trim();
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            eliminarCod();
        }
    }
}
