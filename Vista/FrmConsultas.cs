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
        ConfCConsultas codigoconsulta = new ConfCConsultas();
        CFinalidad CFinalidad = new CFinalidad();
        ErrorProvider Validar = new ErrorProvider();
        ServicioConsultas Consultas = new ServicioConsultas();
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
        private void guardartabla(Consultas table)
        {
            tablaConsultas.Rows.Add(txtNumeroFactura.Text, TxtIde.Text, txtNumAuto.Text, txtVrlConsulta.Text, txtVrlCuoM.Text, txtVrlNeto.Text);
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
            consulta.CodDiagPpal=cbbDiagnosticoP.Text;
            consulta.CodDiaRel1= cbbDiagR.Text;
            consulta.CodDiaRel2 = cbbDiagR2.Text;
            consulta.CodDiaRel3 = cbbDiagR3.Text;
            consulta.TipoDiagPpal=cbbTdiagP.Text;
            consulta.ValorConsulta=double.Parse(txtVrlConsulta.Text);
            consulta.ValorCuoMod= double.Parse(txtVrlCuoM.Text);
            consulta.ValorNetoPagar= double.Parse(txtVrlNeto.Text);
            string msg = Consultas.Crear(consulta);
            guardartabla(consulta);
            MessageBox.Show(msg);
            Limpiar();
            
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
                modificartabla();
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
            tablaConsultas.Rows.RemoveAt(posicion);
        }
        private void llenartabla()
        {
            foreach (var item in Consultas.ObtenerTodos())
            {

                tablaConsultas.Rows.Add(item.NumeroFactura,item.NumeroIdentificacion,item.NumeroAutorizacion,item.ValorConsulta,item.ValorCuoMod,item.ValorNetoPagar);
            }
        }
        private void modificartabla()
        {
            tablaConsultas[0, posicion].Value = txtNumeroFactura.Text;
            tablaConsultas[1, posicion].Value = TxtIde.Text;
            tablaConsultas[2, posicion].Value = txtNumAuto.Text;
            tablaConsultas[3, posicion].Value = txtVrlConsulta.Text;
            tablaConsultas[4, posicion].Value = txtVrlCuoM.Text;
            tablaConsultas[5, posicion].Value = txtVrlNeto.Text;
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
        private void extension(System.Windows.Forms.TextBox h, int valorMaximo, int valorMinimo)
        {
            if (h.Text.Length > valorMaximo || h.Text.Length < valorMinimo)
            {
                Validar.SetError(h, "Numero de caracteres superado"); btnInsertar.Enabled = false;
            }
            else
            {
                btnInsertar.Enabled = true;
            }
        }
        private ErrorProvider validarExtension(KeyPressEventArgs e, System.Windows.Forms.TextBox h)
        {
            switch (cbbTipos.SelectedIndex)
            {
                case 0:
                    extension(h, 10, 6);
                    break;
                case 1:
                    extension(h, 11, 6);
                    break;
                case 2:
                    extension(h, 6, 3);
                    break;
                case 3:
                    extension(h, 16, 10);
                    break;
                case 4:
                    extension(h, 16, 10);
                    break;
                case 5:
                    extension(h, 16, 10);
                    break;
                case 6:
                    extension(h, 15, 10);
                    break;
                case 7:
                    extension(h, 11, 10);
                    break;
                case 8:
                    extension(h, 9, 5);
                    break;
            }
            return null;
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
            validarN(e, TxtIde);
            validarExtension(e, TxtIde);
        }

        private void txtNumAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumAuto);
            txtNumAuto.MaxLength=5;
        }

        private void txtVrlConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtVrlConsulta);
        }

        private void txtVrlCuoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtVrlCuoM);
        }

        private void txtVrlNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtVrlNeto);
        }

        private void TablaConsultas_Click(object sender, EventArgs e)
        { 
        }

        private void TablaConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TablaConsultas2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
