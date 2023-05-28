using Entidades;
using Logica;
using Logica.ManejoForm;
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
    public partial class FmrFacturacion : Form
    {
        public FmrFacturacion()
        {
            InitializeComponent();
        }
        ErrorProvider Validar = new ErrorProvider();
        Manejo_Form manejo = new Manejo_Form();
        Logica.ServicioFacturacion factura = new Logica.ServicioFacturacion(ConfigConnection.connectionString);
        Manejo_Pdf servicios = new Manejo_Pdf();
        Logica.Conversiones.ConversionesFactura Conversion=new Logica.Conversiones.ConversionesFactura(ConfigConnection.connectionString);
        private void LlenarTabla()
        {
            TablaFactura.DataSource = factura.ObtenerNoPagados();
        }
        private void modificar()
        {
            var facturas = new Facturacion();
            facturas.NumeroFactura = txtNumeroFactura.Texts;
            facturas.FechaFinal = dttFechaFinal.Value;
            facturas.NumeroContrato = Convert.ToInt32(txtNumeroContrato.Texts);
            facturas.PlanBeneficios = Convert.ToInt32(txtPlanBeneficios.Texts);
            facturas.NumeroPoliza = Convert.ToInt32(txtNumeroPoliza.Texts);
            facturas.VrlComision = Convert.ToInt32(txtValorComision.Texts);
            facturas.VrlTDescuento = Convert.ToInt32(txtValorDescuentos.Texts);
            facturas.VrlNetoP = Convert.ToInt32(txtValorComision.Texts);
            facturas.CodigoC = "P";
            string msg = factura.Actualizar(facturas);
            MessageBox.Show(msg);
        }
        private void imprimir()
        {
            string nombre = Conversion.ExtraerNombre(txtNumeroFactura.Texts);
            string id = Conversion.ExtraerId(txtNumeroFactura.Texts);
            string numeroAutorizacion = Conversion.ExtraerNumAutorizacion(txtNumeroFactura.Texts);
            string finalidad = Conversion.ExtraerFinalidad(txtNumeroFactura.Texts);
            string fecha = TablaFactura.CurrentRow.Cells[1].Value.ToString();
            servicios.Guardar(txtNumeroFactura.Texts, nombre, id, fecha, numeroAutorizacion, finalidad, txtValorDescuentos.Texts, txtValorTotal.Texts);
        }
        private void nulos()
        {
            if(factura.nulos(txtNumeroFactura.Texts,txtNumeroContrato.Texts,txtPlanBeneficios.Texts,txtNumeroPoliza.Texts,
                           txtValorComision.Texts, txtValorDescuentos.Texts, txtValorTotal.Texts))
            {
                btnModificar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
            }
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
        private void FmrFacturacion_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            nulos();
        }
        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            txtValorTotal.Texts = Convert.ToInt32(factura.ValorTotal(Convert.ToInt32(txtValorComision.Texts), Convert.ToInt32(txtValorDescuentos.Texts))).ToString();
            nulos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            imprimir();
        }
        private void TablaFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtValorComision.Texts = TablaFactura.CurrentRow.Cells[9].Value.ToString();
            txtNumeroFactura.Texts = TablaFactura.CurrentRow.Cells[12].Value.ToString();
        }
        private void cbxFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            TablaFactura.DataSource = factura.ObtenerTodos();
            btnModificar.Enabled = false; 
            btnEliminar.Enabled = false;
            if (!cbxFiltrar.Checked)
            {
                LlenarTabla();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumeroFactura);
            nulos();
        }

        private void txtNumeroContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumeroContrato);
            nulos();
        }

        private void txtPlanBeneficios_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtPlanBeneficios);
            nulos();
        }

        private void txtNumeroPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumeroPoliza);
            nulos();
        }

        private void txtValorComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtValorComision);
            nulos();
        }

        private void txtValorDescuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtValorDescuentos);
            nulos();
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtValorTotal);
            nulos();
        }
    }
}
