using Datos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmConsultas : Form
    {
        
        Logica.ServicioConsultas Consultas = new Logica.ServicioConsultas(ConfigConnection.connectionString);
        Logica.Configuraciones abstraccion =new Logica.Configuraciones(ConfigConnection.connectionString);
        Logica.Datos_Prederminados llenado=new Logica.Datos_Prederminados(ConfigConnection.connectionString);
        Manejo_Form manejo=new Manejo_Form();
        Logica.ConfiguracionNombres mostrado = new Logica.ConfiguracionNombres(ConfigConnection.connectionString);
        public FrmConsultas()
        {
            InitializeComponent();
        }
        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            llenarCombo();
            inicio();
            llenartabla();
        }
        private void inicio()
        {
            PanelDatos.Visible = true;
            PanelVista.Visible = false;
            btnModificar.Visible = false;
            BtnEliminar.Visible = false;
            btnInsertar.Visible = true;
            btnInsertar.Location = new System.Drawing.Point(415, 422);
        }
        private void llenarCombo()
        {
            llenado.FinalidadConsultas(cbbFinalidadConsulta);
            llenado.CodigoConsulta(ccbCConsulta);
            llenado.TipoDiagnostico(cbbTdiagP);
            llenado.DiagnosticoPrinciPal(cbbDiagnosticoP);
            llenado.DiagnosticoPrinciPal(cbbDiagR);
            llenado.DiagnosticoPrinciPal(cbbDiagR2);
            llenado.DiagnosticoPrinciPal(cbbDiagR3);
            llenado.TipoIdentificacion(cbbTipos);
            llenado.CausasExternas(cbbCausa);
        }
        private void guardar()
        {
            try
            {
                var consulta = new Consultas();
                consulta.NumeroFactura = txtNumeroFactura.Text;
                consulta.CodigoConsultorio = "750309";
                consulta.TipoId = abstraccion.TipoIdentificacion(cbbTipos.Text);
                consulta.NumeroIdentificacion = TxtIde.Text;
                consulta.FechaConsulta = Datetime.Value;
                consulta.NumeroAutorizacion = txtNumAuto.Text;
                consulta.CodigoC = abstraccion.CodigoConsulta(ccbCConsulta.Text);
                consulta.FinalidadConsulta = abstraccion.FinalidadConsultas(cbbFinalidadConsulta.Text);
                consulta.CausaExterna = abstraccion.CausasExternas(cbbCausa.Text);
                consulta.CodDiagPpal = abstraccion.DiagnosticoPrinciPal(cbbDiagnosticoP.Text);
                consulta.CodDiaRel1 = abstraccion.DiagnosticoPrinciPal(cbbDiagR.Text);
                consulta.CodDiaRel2 = abstraccion.DiagnosticoPrinciPal(cbbDiagR2.Text);
                consulta.CodDiaRel3 = abstraccion.DiagnosticoPrinciPal(cbbDiagR3.Text);
                consulta.TipoDiagPpal = abstraccion.TipoDiagnostico(cbbTdiagP.Text);
                consulta.ValorConsulta = Convert.ToInt32(txtVrlConsulta.Text);
                consulta.ValorCuoMod = Convert.ToInt32(txtVrlCuoM.Text);
                consulta.ValorNetoPagar = Convert.ToInt32(txtVrlNeto.Text);
                string msg = Consultas.Crear(consulta);
                MessageBox.Show(msg);
                Limpiar();
            }
            catch (Exception)
            {

                MessageBox.Show("Rellene los datos numericos");
            }
            
            
        }
        private void modificar()
        {
            var NuevaConsulta = new Consultas();
            var consulta = Consultas.ObtenerPorId(TxtIde.Text);

                NuevaConsulta.NumeroFactura = txtNumeroFactura.Text;
                NuevaConsulta.CodigoConsultorio = "750309";
                NuevaConsulta.TipoId = abstraccion.TipoIdentificacion(cbbTipos.Text);
                NuevaConsulta.NumeroIdentificacion = TxtIde.Text;
                NuevaConsulta.FechaConsulta = Datetime.Value;
                NuevaConsulta.NumeroAutorizacion = txtNumAuto.Text;
                NuevaConsulta.CodigoC = abstraccion.CodigoConsulta(ccbCConsulta.Text);
                NuevaConsulta.FinalidadConsulta = abstraccion.FinalidadConsultas(cbbFinalidadConsulta.Text);
                NuevaConsulta.CausaExterna = abstraccion.CausasExternas(cbbCausa.Text);
                NuevaConsulta.CodDiagPpal = abstraccion.DiagnosticoPrinciPal(cbbDiagnosticoP.Text);
                NuevaConsulta.CodDiaRel1 = abstraccion.DiagnosticoPrinciPal(cbbDiagR.Text);
                NuevaConsulta.CodDiaRel2 = abstraccion.DiagnosticoPrinciPal(cbbDiagR2.Text);
                NuevaConsulta.CodDiaRel3 = abstraccion.DiagnosticoPrinciPal(cbbDiagR3.Text);
                NuevaConsulta.TipoDiagPpal = abstraccion.TipoDiagnostico(cbbTdiagP.Text);
                NuevaConsulta.ValorConsulta = Convert.ToInt32(txtVrlConsulta.Text);
                NuevaConsulta.ValorCuoMod = Convert.ToInt32(txtVrlCuoM.Text);
                NuevaConsulta.ValorNetoPagar = Convert.ToInt32(txtVrlNeto.Text);
                string msg = Consultas.Actualizar(NuevaConsulta);
                MessageBox.Show(msg);
                Limpiar();
        }
        private void eliminar()
        {
            var consulta = new Consultas();
            consulta.NumeroAutorizacion = txtNumAuto.Text;
            string msg = Consultas.Eliminar(consulta);
            MessageBox.Show(msg);
            Limpiar();
        }
        private void llenartabla()
        {
            tablaConsultas.DataSource = Consultas.ObtenerTodos();
        }
        private void Limpiar()
        {
            txtNumAuto.Text = string.Empty;
            txtNumeroFactura.Text=string.Empty;
            txtVrlConsulta.Text = string.Empty;
            txtVrlCuoM.Text = string.Empty;
            txtVrlNeto.Text = string.Empty;
            TxtIde.Text = string.Empty;
            ccbCConsulta.Text = string.Empty;
            cbbCausa.Text = string.Empty;
            cbbDiagnosticoP.Text=string.Empty;
            cbbDiagR.Text = string.Empty;
            cbbDiagR2.Text = string.Empty;
            cbbDiagR3.Text = string.Empty;
            cbbFinalidadConsulta.Text = string.Empty;
            cbbTdiagP.Text = string.Empty;
            cbbTipos.Text = string.Empty;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtNumeroFactura);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void checkView_CheckedChanged(object sender, EventArgs e)
        {
            PanelDatos.Visible = false;
            PanelVista.Visible = true;
            btnInsertar.Visible = false;
            btnModificar.Visible = true;
            BtnEliminar.Visible = true;
            btnModificar.Location = new Point(144, 485);
            if (!checkView.Checked)
            {
                inicio();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void TxtIde_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, TxtIde);
            manejo.validarExtension(cbbTipos,e, TxtIde,btnInsertar);
            TxtIde.MaxLength=manejo.extensioncajadetexto(cbbTipos);
        }
        private void txtNumAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtNumAuto);
            txtNumAuto.MaxLength=6;
        }

        private void txtVrlConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtVrlConsulta);
        }

        private void txtVrlCuoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtVrlCuoM);
        }

        private void txtVrlNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtVrlNeto);
        }

        private void tablaConsultas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Datetime.Value= Datetime.Value = (DateTime)tablaConsultas.CurrentRow.Cells[0].Value;
            txtNumAuto.Text = tablaConsultas.CurrentRow.Cells[1].Value.ToString();
            cbbFinalidadConsulta.Text = mostrado.FinalidadConsultas(tablaConsultas.CurrentRow.Cells[2].Value.ToString());
            cbbCausa.Text = mostrado.CausasExternas(tablaConsultas.CurrentRow.Cells[3].Value.ToString());
            cbbDiagnosticoP.Text = mostrado.DiagnosticoPrinciPal(tablaConsultas.CurrentRow.Cells[4].Value.ToString());
            cbbDiagR.Text = mostrado.DiagnosticoPrinciPal(tablaConsultas.CurrentRow.Cells[5].Value.ToString());
            cbbDiagR2.Text = mostrado.DiagnosticoPrinciPal(tablaConsultas.CurrentRow.Cells[6].Value.ToString());
            cbbDiagR3.Text = mostrado.DiagnosticoPrinciPal(tablaConsultas.CurrentRow.Cells[7].Value.ToString());
            cbbTdiagP.Text = mostrado.TipoDiagnostico(tablaConsultas.CurrentRow.Cells[8].Value.ToString());
            txtVrlConsulta.Text = tablaConsultas.CurrentRow.Cells[9].Value.ToString();
            txtVrlCuoM.Text = tablaConsultas.CurrentRow.Cells[10].Value.ToString();
            txtVrlNeto.Text = tablaConsultas.CurrentRow.Cells[11].Value.ToString();
            txtNumeroFactura.Text = tablaConsultas.CurrentRow.Cells[12].Value.ToString();
            cbbTipos.Text = mostrado.TipoIdentificacion(tablaConsultas.CurrentRow.Cells[14].Value.ToString());
            TxtIde.Text = tablaConsultas.CurrentRow.Cells[15].Value.ToString();
            ccbCConsulta.Text = mostrado.CodigoConsulta(tablaConsultas.CurrentRow.Cells[16].Value.ToString());
        }
    }
}
