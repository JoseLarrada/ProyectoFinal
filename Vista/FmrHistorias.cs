using Entidades;
using Logica;
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
    public partial class FmrHistorias : Form
    {
        Logica.ConfiguracionNombres nombres = new Logica.ConfiguracionNombres(ConfigConnection.connectionString);
        Logica.Conversiones.ConversionesFactura conversionfactura = new Logica.Conversiones.ConversionesFactura(ConfigConnection.connectionString);
        Logica.Conversiones.CoversionesHistoria conversionHistoria = new Logica.Conversiones.CoversionesHistoria(ConfigConnection.connectionString);
        Logica.ServicioHistoriaClinica Hclinica=new Logica.ServicioHistoriaClinica(ConfigConnection.connectionString);
        Logica.ServicioFacturacion facturas=new Logica.ServicioFacturacion(ConfigConnection.connectionString);
        Manejo_Formulario manejo = new Manejo_Formulario();
        ErrorProvider Validar = new ErrorProvider();
        public FmrHistorias()
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
        public void Modificar()
        {
            var historia=new HistoriaClinica();
            historia.NumeroIdentificacion = conversionfactura.ExtraerId(txtNumF.Texts);
            historia.Tratamiento = txtTratamiento.Texts;
            historia.Medicacion = txtMedicacion.Texts;
            string msg=Hclinica.Actualizar(historia);
            MessageBox.Show(msg);
        }
        public void eliminar()
        {
            var historia=new HistoriaClinica();
            historia.NumeroIdentificacion= conversionfactura.ExtraerId(txtNumF.Texts);
            string msg=Hclinica.Eliminar(historia);
            MessageBox.Show(msg);
        }
        public void llenartabla()
        {
            TablaFactura.DataSource = facturas.ObtenerTodos();
            tablaHistorias.DataSource=Hclinica.ObtenerTodos();
        }
        public ErrorProvider validarN(KeyPressEventArgs e, pruebas h)
        {
            bool error = manejo.SoloNumeros(e);
            if (!error)
            {
                Validar.SetError(h, "Solo numeros");
                return null;
            }
            else
            {
                Validar.Clear();
                return null;
            }
        }
        private void Historias_Load(object sender, EventArgs e)
        {
            llenartabla();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Guardar();
            txtNumF.Enabled = true;
        }
        private void TablaFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumF.Texts = TablaFactura.CurrentRow.Cells[12].Value.ToString();
            txtNumF.Enabled = false;
        }

        private void txtNumF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumF);
            txtNumF.Texts = manejo.extension(txtNumF.Texts,6);
        }

        private void txtTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTratamiento.Texts = manejo.extension(txtTratamiento.Texts, 300);
        }

        private void txtMedicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMedicacion.Texts = manejo.extension(txtMedicacion.Texts, 150);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
