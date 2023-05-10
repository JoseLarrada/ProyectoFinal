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
        Configuraciones tiposid = new Configuraciones();
        ServicioConsultas Consultas = new ServicioConsultas();
        Manejo_Form manejo=new Manejo_Form();
        Manejo_Form_Consulta manejoC=new Manejo_Form_Consulta();
        public FrmConsultas()
        {
            InitializeComponent();
        }
        int posicion = 0;
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
            //Tipos de  Identificacion
            foreach (var item in tiposid.TipoIdentificacion())
            {
                cbbTipos.Items.Add(item);
            }
            //Codigos COnsultas
            foreach (var item in tiposid.CodigoConsulta())
            {
                ccbCConsulta.Items.Add(item);
            }
            //Finalidad De consultas
            foreach (var item in tiposid.FinalidadConsultas())
            {
                cbbFinalidadConsulta.Items.Add(item);
            }
            //Diagnostico Principal
            
            foreach (var item in tiposid.DiagnosticoPPal())
            {
                cbbDiagnosticoP.Items.Add(item);
                cbbDiagR.Items.Add(item);
                cbbDiagR2.Items.Add(item);
                cbbDiagR3.Items.Add(item);
            }
            //Tipo de Diagnostico Principal
            cbbTdiagP.Items.Add("Impresion Diagnostica");
            cbbTdiagP.Items.Add("Confirmado Nuevo");
            cbbTdiagP.Items.Add("Confirmado Repetido");
            //Causa Externa
            foreach (var item in tiposid.CausaE())
            {
                cbbCausa.Items.Add(item);
            }
        }
        private void guardar()
        {
            try
            {
                var consulta = new Consultas();
                consulta.NumeroFactura = txtNumeroFactura.Text;
                consulta.CodigoConsultorio = "3052023";
                consulta.TipoId = cbbTipos.Text;
                consulta.NumeroIdentificacion = TxtIde.Text;
                consulta.FechaConsulta = Datetime.Value;
                consulta.NumeroAutorizacion = txtNumAuto.Text;
                consulta.CodigoC = ccbCConsulta.Text;
                consulta.FinalidadConsulta = cbbFinalidadConsulta.Text;
                consulta.CausaExterna = cbbCausa.Text;
                consulta.CodDiagPpal = cbbDiagnosticoP.Text;
                consulta.CodDiaRel1 = cbbDiagR.Text;
                consulta.CodDiaRel2 = cbbDiagR2.Text;
                consulta.CodDiaRel3 = cbbDiagR3.Text;
                consulta.TipoDiagPpal = cbbTdiagP.Text;
                consulta.ValorConsulta = double.Parse(txtVrlConsulta.Text);
                consulta.ValorCuoMod = double.Parse(txtVrlCuoM.Text);
                consulta.ValorNetoPagar = double.Parse(txtVrlNeto.Text);
                string msg = Consultas.Crear(consulta);
                manejoC.guardartabla(tablaConsultas, consulta, txtNumAuto, TxtIde, txtNumeroFactura, txtVrlConsulta, txtVrlCuoM, txtVrlNeto);
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
                NuevaConsulta.CodigoConsultorio = "3052023";
                NuevaConsulta.TipoId = cbbTipos.Text;
                NuevaConsulta.NumeroIdentificacion = TxtIde.Text;
                NuevaConsulta.FechaConsulta = Datetime.Value;
                NuevaConsulta.NumeroAutorizacion = txtNumAuto.Text;
                NuevaConsulta.CodigoC = ccbCConsulta.Text;
                NuevaConsulta.FinalidadConsulta = cbbFinalidadConsulta.Text;
                NuevaConsulta.CausaExterna = cbbCausa.Text;
                NuevaConsulta.CodDiagPpal = cbbDiagnosticoP.Text;
                NuevaConsulta.CodDiaRel1 = cbbDiagR.Text;
                NuevaConsulta.CodDiaRel2 = cbbDiagR2.Text;
                NuevaConsulta.CodDiaRel3 = cbbDiagR3.Text;
                NuevaConsulta.TipoDiagPpal = cbbTdiagP.Text;
                NuevaConsulta.ValorConsulta = double.Parse(txtVrlConsulta.Text);
                NuevaConsulta.ValorCuoMod = double.Parse(txtVrlCuoM.Text);
                NuevaConsulta.ValorNetoPagar = double.Parse(txtVrlNeto.Text);
                string msg = Consultas.Actualizar(consulta, NuevaConsulta);
                MessageBox.Show(msg);
                manejoC.modificartabla(tablaConsultas,posicion,txtNumAuto,TxtIde,txtNumeroFactura, txtVrlConsulta, txtVrlCuoM, txtVrlNeto);
                Limpiar();
        }
        private void eliminar()
        {
            var consulta = new Consultas();
            consulta.NumeroIdentificacion = TxtIde.Text;
            string msg = Consultas.Eliminar(consulta);
            MessageBox.Show(msg);
            tablaConsultas.Rows.RemoveAt(posicion);
            Limpiar();
        }
        private void llenartabla()
        {
            foreach (var item in Consultas.ObtenerTodos())
            {

                tablaConsultas.Rows.Add(item.NumeroFactura,item.NumeroIdentificacion,item.NumeroAutorizacion,item.ValorConsulta,item.ValorCuoMod,item.ValorNetoPagar);
            }
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
        }
        private void txtNumAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtNumAuto);
            txtNumAuto.MaxLength=5;
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
            posicion = tablaConsultas.CurrentRow.Index;
            txtNumAuto.Text = tablaConsultas.CurrentRow.Cells[0].Value.ToString();
            TxtIde.Text = tablaConsultas.CurrentRow.Cells[1].Value.ToString();
            txtNumeroFactura.Text = tablaConsultas.CurrentRow.Cells[2].Value.ToString();
            txtVrlConsulta.Text = tablaConsultas.CurrentRow.Cells[3].Value.ToString();
            txtVrlCuoM.Text = tablaConsultas.CurrentRow.Cells[4].Value.ToString();
            txtVrlNeto.Text = tablaConsultas.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
