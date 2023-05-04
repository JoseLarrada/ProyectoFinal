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
        ConfCConsultas codigoconsulta = new ConfCConsultas();
        CFinalidad CFinalidad = new CFinalidad();
        ErrorProvider Validar = new ErrorProvider();
        ServicioConsultas Consultas = new ServicioConsultas();
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
            //Tipos de  Identificacion
            foreach (var item in tiposid.ObtenerTodos())
            {
                cbbTipos.Items.Add(item);
            }
            //Codigos COnsultas
            foreach (var item in codigoconsulta.ObtenerTodos())
            {
                ccbCConsulta.Items.Add(item);
            }
            //Finalidad De consultas
            foreach (var item in CFinalidad.ObtenerTodos())
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
        public bool SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false; return true;
            }else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false; return true;
            }
            else
            {
                e.Handled=true; return false;
            }
        }
        private ErrorProvider validarN(KeyPressEventArgs e, System.Windows.Forms.TextBox h)
        {
            bool error = SoloNumeros(e);
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
        private void guardar()
        {
            var consulta = new Consultas();
            consulta.NumeroFactura = txtNumeroFactura.Text;
            consulta.CodigoConsultorio = "3052023";
            consulta.TipoId = cbbTipos.Text;
            consulta.NumeroIdentificacion = TxtIde.Text;
            consulta.FechaConsulta=Datetime.Value;
            consulta.NumeroAutorizacion=txtNumAuto.Text;
            consulta.CodigoC = ccbCConsulta.Text;
            consulta.FinalidadConsulta=cbbFinalidadConsulta.Text;
            consulta.CausaExterna=cbbCausa.Text;
            consulta.CodDiagPpal=cbbDiagnosticoP.Text; ;
            consulta.CodDiaRel1= cbbDiagR.Text;
            consulta.CodDiaRel2 = cbbDiagR2.Text;
            consulta.CodDiaRel3 = cbbDiagR3.Text;
            consulta.TipoDiagPpal=cbbTdiagP.Text;
            consulta.ValorConsulta=double.Parse(txtVrlConsulta.Text);
            consulta.ValorCuoMod= double.Parse(txtVrlCuoM.Text);
            consulta.ValorNetoPagar= double.Parse(txtVrlNeto.Text);
            string msg = Consultas.Crear(consulta);
            MessageBox.Show(msg);
        }
        private void llenartabla()
        {
            foreach (var item in Consultas.ObtenerTodos())
            {

                TablaConsultas.Rows.Add(item.NumeroFactura,item.NumeroIdentificacion,item.NumeroAutorizacion,item.ValorConsulta,item.ValorCuoMod,item.ValorNetoPagar);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumeroFactura);
        }

        private void btnModificar_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void checkView_CheckedChanged(object sender, EventArgs e)
        {
            PanelDatos.Visible = false;
            PanelVista.Visible = true;
            btnInsertar.Visible = false;
            btnModificar.Visible = true;
            BtnEliminar.Visible = true;
            btnModificar.Location = new Point(231, 422);
            if (!checkView.Checked)
            {
                inicio();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
