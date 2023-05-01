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
    public partial class FrmConsultas : Form
    {
        Configuraciones tiposid = new Configuraciones();
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            foreach (var item in tiposid.ObtenerTodos())
            {
                cbbTipos.Items.Add(item);
            }
        }
    }
}
