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
    public partial class FmrVistas : Form
    {
        Logica.ServicioVistas vistas=new Logica.ServicioVistas(ConfigConnection.connectionString);
        public FmrVistas()
        {
            InitializeComponent();
        }

        private void FmrVistas_Load(object sender, EventArgs e)
        {
            llenargrafico();
            llenarlbls();
            
        }
        private void llenargrafico()
        {
            graficoTorta.Series[0].Points.DataBindXY(vistas.CodigoDiagnostico(),vistas.Cantidad());
            graficoBarras.Series[0].Points.DataBindXY(vistas.usuarios(), vistas.CantidadUsuarios());
        }
        private void llenarlbls()
        {
            
            lblConsultasActivas.Text = vistas.ConsultasActivas();
            lblFacturasnopagas.Text=vistas.FacturasNoPagadas();
            lblFacturasPagas.Text=vistas.FacturasPagadas();
            lblNumeroHistorias.Text=vistas.TotalHistorias();
            lblProcedientosAc.Text = vistas.ProcedimientosActivos();
            lblTotalConsultas.Text=vistas.TotalConsulta();
            lblTotalFactura.Text=vistas.TotalRecaudado();
            lblUsuariosActivos.Text=vistas.NumeroDeUsuarios();
            lbTtalProce.Text=vistas.TotalProcedimiento();
        }
    }
}
