﻿using Datos;
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

namespace Vista
{
    public partial class FrmProcedimientos : Form
    {
        public FrmProcedimientos()
        {
            InitializeComponent();
        }
        ErrorProvider Validar = new ErrorProvider();
        Logica.Configuraciones abstraccion = new Logica.Configuraciones(ConfigConnection.connectionString);
        Logica.ConfiguracionNombres mostrado = new Logica.ConfiguracionNombres(ConfigConnection.connectionString);
        Logica.Datos_Prederminados llenado = new Logica.Datos_Prederminados(ConfigConnection.connectionString);
        Logica.ServicioProcedimientos procesos=new Logica.ServicioProcedimientos(ConfigConnection.connectionString);

        int posicion = 0;
        private void llenarCombobox()
        {
            llenado.TipoIdentificacion(cbbTipos);
            llenado.Ambitos(cbbAmbitoP);
            llenado.FinalidadProcedimiento(cbbFinalidadProcedimiento);
            llenado.DiagnosticoProcedimiento(cbbDiagnosticoP);
            llenado.Forma(cbbFormaRealizacion);
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
        public bool SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false; return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false; return true;
            }
            else
            {
                e.Handled = true; return false;
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
            var procedimiento = new Procedimiento();
            procedimiento.NumeroFactura = txtNumeroFactura.Text;
            procedimiento.CodigoConsultorio = "750309";
            procedimiento.TipoId = abstraccion.TipoIdentificacion(cbbTipos.Text);
            procedimiento.NumeroIdentificacion = TxtIde.Text;
            procedimiento.CodigoC = txtCodigoProcedimiento.Text;
            procedimiento.FechaProcedimiento = Datetime.Value;
            procedimiento.NumeroAutorizacion = txtNumAuto.Text;
            procedimiento.AmbitoRealProce = abstraccion.Ambitos(cbbAmbitoP.Text);
            procedimiento.PersonalAti = "0";
            procedimiento.FinalidadProce = abstraccion.FinalidadProcedimientos(cbbFinalidadProcedimiento.Text);
            procedimiento.DiagnosticoPpal= abstraccion.DiagnosticoProcedimiento(cbbDiagnosticoP.Text);
            procedimiento.FormaRealiActo= abstraccion.FormaRealizacion(cbbFormaRealizacion.Text);
            procedimiento.VrlProcedimiento = Convert.ToInt32(txtVrlProcedimiento.Text);
            string msg = procesos.Crear(procedimiento);
            MessageBox.Show(msg);
            Limpiar();
        }
        private void modificar()
        {
            var procedimiento = new Procedimiento();
            procedimiento.NumeroFactura = txtNumeroFactura.Text;
            procedimiento.CodigoConsultorio = "750309";
            procedimiento.TipoId = abstraccion.TipoIdentificacion(cbbTipos.Text);
            procedimiento.NumeroIdentificacion = TxtIde.Text;
            procedimiento.CodigoC = txtCodigoProcedimiento.Text;
            procedimiento.FechaProcedimiento = Datetime.Value;
            procedimiento.NumeroAutorizacion = txtNumAuto.Text;
            procedimiento.AmbitoRealProce = abstraccion.Ambitos(cbbAmbitoP.Text);
            procedimiento.PersonalAti = "0";
            procedimiento.FinalidadProce = abstraccion.FinalidadProcedimientos(cbbFinalidadProcedimiento.Text);
            procedimiento.DiagnosticoPpal = abstraccion.DiagnosticoProcedimiento(cbbDiagnosticoP.Text);
            procedimiento.FormaRealiActo = abstraccion.FormaRealizacion(cbbFormaRealizacion.Text);
            procedimiento.VrlProcedimiento = Convert.ToInt32(txtVrlProcedimiento.Text);
            string msg = procesos.Actualizar(procedimiento);
            MessageBox.Show(msg);
            Limpiar();
        }
        private void eliminar()
        {
            var proceso=new Procedimiento();
            proceso.CodigoC = txtCodigoProcedimiento.Text;
            string msg = procesos.Eliminar(proceso);
            MessageBox.Show(msg);
            Limpiar();
        }
        private void llenartabla()
        {
            tablaProcedimientos.DataSource=procesos.ObtenerTodos();
        }
        private void Limpiar()
        {
            txtCodigoProcedimiento.Text = string.Empty;
            txtNumAuto.Text = string.Empty;
            txtNumeroFactura.Text=string.Empty;
            txtVrlProcedimiento.Text=string.Empty;
            TxtIde.Text = string.Empty;
            cbbAmbitoP.Text = string.Empty;
            cbbDiagnosticoP.Text = string.Empty;
            cbbFinalidadProcedimiento.Text = string.Empty;
            cbbFormaRealizacion.Text = string.Empty;
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

        private void FrmProcedimientos_Load(object sender, EventArgs e)
        {
            llenarCombobox();
            inicio();
            llenartabla();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumeroFactura);
            txtNumeroFactura.MaxLength = 6;
        }

        private void TxtIde_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarExtension(e, TxtIde);
            validarN(e, TxtIde);
        }

        private void txtCodigoProcedimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtCodigoProcedimiento);
        }

        private void txtNumAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumAuto);
        }

        private void txtVrlProcedimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtVrlProcedimiento);
        }

        private void tablaProcedimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion= tablaProcedimientos.CurrentRow.Index;
            Datetime.Value = (DateTime)tablaProcedimientos.CurrentRow.Cells[0].Value;
            txtNumAuto.Text = tablaProcedimientos.CurrentRow.Cells[1].Value.ToString();
            cbbAmbitoP.Text= mostrado.Ambitos(tablaProcedimientos.CurrentRow.Cells[2].Value.ToString());
            cbbFinalidadProcedimiento.Text = mostrado.FinalidadProcedimientos(tablaProcedimientos.CurrentRow.Cells[3].Value.ToString());
            cbbDiagnosticoP.Text= mostrado.DiagnosticoProcedimiento(tablaProcedimientos.CurrentRow.Cells[5].Value.ToString());
            cbbFormaRealizacion.Text = mostrado.FormaRealizacion(tablaProcedimientos.CurrentRow.Cells[6].Value.ToString());
            txtVrlProcedimiento.Text = tablaProcedimientos.CurrentRow.Cells[7].Value.ToString();
            txtNumeroFactura.Text = tablaProcedimientos.CurrentRow.Cells[8].Value.ToString();
            cbbTipos.Text = mostrado.TipoIdentificacion(tablaProcedimientos.CurrentRow.Cells[10].Value.ToString());
            TxtIde.Text = tablaProcedimientos.CurrentRow.Cells[11].Value.ToString();
            txtCodigoProcedimiento.Text=tablaProcedimientos.CurrentRow.Cells[12].Value.ToString();
        }
    }
}
