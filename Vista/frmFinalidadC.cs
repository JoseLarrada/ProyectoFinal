using Datos.DatosPrederminados;
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
    public partial class frmFinalidadC : Form
    {
        CFinalidad fin=new CFinalidad();
        public frmFinalidadC()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            var tipo= new FConsulta();
            tipo.FinalidadC = txtTipoF.Text;
            string msg = fin.Crear(tipo);
            MessageBox.Show(msg);
            limpiar();
            listFinalidad.Items.Add(tipo);
        }
        private void modificar()
        {
            var tipoN = new FConsulta();
            var tipoV = fin.ObtenerPorId(txtTipoF.Text);
            if (tipoV == null)
            {
                MessageBox.Show("Tipo de dato inexistente");
            }
            else
            {
                tipoN.FinalidadC = txtTipoF.Text;
                string msg = fin.Actualizar(tipoV, tipoN);
                MessageBox.Show(msg);
                limpiar();
            }
        }
        private void limpiar()
        {
            txtTipoF.Text = "";
        }
        private void eliminar()
        {
            var tipo = new FConsulta();
            tipo.FinalidadC = txtTipoF.Text;
            string msg = fin.Eliminar(tipo);
            MessageBox.Show(msg);
            limpiar();
        }

        private void btnAgregarF_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnModificarF_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnEliminarF_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void listFinalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTipoF.Text=listFinalidad.Text.Trim();
        }

        private void frmFinalidadC_Load(object sender, EventArgs e)
        {
            foreach (var item in fin.ObtenerTodos())
            {
                listFinalidad.Items.Add(item);
            }
        }
    }
}
