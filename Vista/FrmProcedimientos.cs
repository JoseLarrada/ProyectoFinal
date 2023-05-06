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

namespace Vista
{
    public partial class FrmProcedimientos : Form
    {
        public FrmProcedimientos()
        {
            InitializeComponent();
        }
        ErrorProvider Validar = new ErrorProvider();
        Configuraciones Combos = new Configuraciones();
        ServicioProcedimientos procesos=new ServicioProcedimientos();
        int posicion = 0;
        private void llenarCombobox()
        {
            //Ambito Procedimiento
            cbbAmbitoP.Items.Add("Urgencias");
            cbbAmbitoP.Items.Add("Hospitalario");
            //FinalidadProcedimiento
            cbbFinalidadProcedimiento.Items.Add("Diagnostico");
            cbbFinalidadProcedimiento.Items.Add("Proteccion Especifica");
            cbbFinalidadProcedimiento.Items.Add("Detección temprana de enfermedad general");
            cbbFinalidadProcedimiento.Items.Add("Detección temprana de enfermedad labora");
            //Diagnosticos
            foreach (var item in Combos.DiagnosticoPPal())
            {
                cbbDiagnosticoP.Items.Add(item);
            }
            //FormaRealizacion
            cbbFormaRealizacion.Items.Add("Unilateral");
            cbbFormaRealizacion.Items.Add("Bilateral Tipo 1");
            cbbFormaRealizacion.Items.Add("Bilateral Tipo 2");
            cbbFormaRealizacion.Items.Add("Bilateral Tipo 3");
            cbbFormaRealizacion.Items.Add("Bilateral Tipo 4");
            //DATOS DE ID
            foreach (var item in Combos.ObtenerTodos())
            {
                cbbTipos.Items.Add(item);
            }
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
            procedimiento.CodigoConsultorio = "3052023";
            procedimiento.TipoId = cbbTipos.Text;
            procedimiento.NumeroIdentificacion = TxtIde.Text;
            procedimiento.CodigoC = txtCodigoProcedimiento.Text;
            procedimiento.FechaProcedimiento = Datetime.Value;
            procedimiento.NumeroAutorizacion = txtNumAuto.Text;
            procedimiento.AmbitoRealProce = cbbAmbitoP.Text;
            procedimiento.FinalidadProce = cbbFinalidadProcedimiento.Text;
            procedimiento.DiagnosticoPpal=cbbDiagnosticoP.Text;
            procedimiento.FormaRealiActo=cbbFormaRealizacion.Text;
            procedimiento.VrlProcedimiento = double.Parse(txtVrlProcedimiento.Text);
            string msg = procesos.Crear(procedimiento);
            guardartabla(procedimiento);
            MessageBox.Show(msg);
            Limpiar();

        }
        private void modificar()
        {
            var NuevoProcedimiento = new Procedimiento();
            var procedimiento = procesos.ObtenerPorId(TxtIde.Text);
            NuevoProcedimiento.NumeroFactura = txtNumeroFactura.Text;
            NuevoProcedimiento.CodigoConsultorio = "3052023";
            NuevoProcedimiento.TipoId = cbbTipos.Text;
            NuevoProcedimiento.NumeroIdentificacion = TxtIde.Text;
            NuevoProcedimiento.CodigoC = txtCodigoProcedimiento.Text;
            NuevoProcedimiento.FechaProcedimiento = Datetime.Value;
            NuevoProcedimiento.NumeroAutorizacion = txtNumAuto.Text;
            NuevoProcedimiento.AmbitoRealProce = cbbAmbitoP.Text;
            NuevoProcedimiento.FinalidadProce = cbbFinalidadProcedimiento.Text;
            NuevoProcedimiento.DiagnosticoPpal = cbbDiagnosticoP.Text;
            NuevoProcedimiento.FormaRealiActo = cbbFormaRealizacion.Text;
            NuevoProcedimiento.VrlProcedimiento = double.Parse(txtVrlProcedimiento.Text);
            string msg = procesos.Actualizar(procedimiento, NuevoProcedimiento);
            MessageBox.Show(msg);
            modificartabla();
            Limpiar();
        }
        private void eliminar()
        {
            var proceso=new Procedimiento();
            proceso.NumeroIdentificacion = TxtIde.Text;
            string msg = procesos.Eliminar(proceso);
            MessageBox.Show(msg);
            tablaProcedimientos.Rows.RemoveAt(posicion);
            Limpiar();
        }
        private void guardartabla(Procedimiento table)
        {
            tablaProcedimientos.Rows.Add(txtNumAuto.Text,TxtIde.Text,txtNumeroFactura.Text,cbbAmbitoP.Text, cbbDiagnosticoP.Text, txtVrlProcedimiento.Text);
        }
        private void modificartabla()
        {
            tablaProcedimientos[0, posicion].Value = txtNumAuto.Text;
            tablaProcedimientos[1, posicion].Value = TxtIde.Text;
            tablaProcedimientos[2, posicion].Value = txtNumeroFactura.Text;
            tablaProcedimientos[3, posicion].Value = cbbAmbitoP.Text;
            tablaProcedimientos[4, posicion].Value = cbbDiagnosticoP.Text;
            tablaProcedimientos[5, posicion].Value = txtVrlProcedimiento.Text;
        }
        private void llenartabla()
        {
            foreach (var item in procesos.ObtenerTodos())
            {
                tablaProcedimientos.Rows.Add(item.NumeroAutorizacion, item.NumeroIdentificacion, item.NumeroFactura, item.AmbitoRealProce, item.DiagnosticoPpal, item.VrlProcedimiento);
            }
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
            txtNumAuto.Text = tablaProcedimientos.CurrentRow.Cells[0].Value.ToString();
            TxtIde.Text= tablaProcedimientos.CurrentRow.Cells[1].Value.ToString();
            txtNumeroFactura.Text = tablaProcedimientos.CurrentRow.Cells[2].Value.ToString();
            cbbAmbitoP.Text= tablaProcedimientos.CurrentRow.Cells[3].Value.ToString();
            cbbDiagnosticoP.Text= tablaProcedimientos.CurrentRow.Cells[4].Value.ToString();
            txtVrlProcedimiento.Text= tablaProcedimientos.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
