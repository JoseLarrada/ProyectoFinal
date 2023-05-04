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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            var tipo=new frmCTipoDato();
            tipo.ShowDialog();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            var codigo= new frmCodConsulta();
            codigo.ShowDialog();
        }

        private void btnFinalidad_Click(object sender, EventArgs e)
        {
            var finalidad = new frmFinalidadC();
            finalidad.ShowDialog();
        }
    }
}
