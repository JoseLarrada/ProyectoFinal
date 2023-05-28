using Entidades;
using Logica.Conversiones;
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
    public partial class Historias : Form
    {
        Logica.ConfiguracionNombres nombres = new Logica.ConfiguracionNombres(ConfigConnection.connectionString);
        Logica.Conversiones.ConversionesFactura conversionfactura = new Logica.Conversiones.ConversionesFactura(ConfigConnection.connectionString);
        Logica.Conversiones.CoversionesHistoria conversionHistoria = new Logica.Conversiones.CoversionesHistoria(ConfigConnection.connectionString);
        Logica.ServicioHistoriaClinica Hclinica=new Logica.ServicioHistoriaClinica(ConfigConnection.connectionString);
        Logica.ServicioFacturacion facturas=new Logica.ServicioFacturacion(ConfigConnection.connectionString);
        public Historias()
        {
            InitializeComponent();
        }
        public void Guardar()
        {
            var historia = new HistoriaClinica();
            historia.CodigoConsultorio = DateTime.Now.ToString("ddMMyyyyHHmmss");
            historia.TipoId = conversionHistoria.ExtraerTipoId(txtNumF.Texts);
            historia.NumeroIdentificacion = conversionfactura.ExtraerId(txtNumF.Texts);
            historia.CodigoC = conversionHistoria.ExtraerDiagnostico(txtNumF.Texts);
            historia.Edad= conversionHistoria.ExtraerEdad(txtNumF.Texts);
            historia.Fecha = dtpFecha.Value;
            historia.PrimerNombre= conversionfactura.ExtraerNombre(txtNumF.Texts);
            historia.PrimerApellido= conversionfactura.ExtraerApellido(txtNumF.Texts);
            historia.NombreDiagnostico = nombres.DiagnosticoPrinciPal(conversionHistoria.ExtraerDiagnostico(txtNumF.Texts));
            historia.NumeroAutorizacion= conversionfactura.ExtraerNumAutorizacion(txtNumF.Texts);
            historia.Tratamiento=txtTratamiento.Texts;
            historia.Medicacion=txtMedicacion.Texts;
            string msg = Hclinica.Crear(historia);
            MessageBox.Show(msg);
        }
        public void llenartabla()
        {
            TablaFactura.DataSource = facturas.ObtenerTodos();
            tablaHistorias.DataSource=Hclinica.ObtenerTodos();
        }

        private void Historias_Load(object sender, EventArgs e)
        {
            llenartabla();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
