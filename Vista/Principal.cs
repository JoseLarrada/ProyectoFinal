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
            var con = new FrmConsultas();
            con.ShowDialog();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            var confi= new Configuracion();
            confi.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            var pacientes=new FmrPacieentes();
            pacientes.ShowDialog();
        }
    }
}
