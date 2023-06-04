using Datos;
using Entidades;
using Logica;
using Logica.Conversiones;
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
        ErrorProvider Validar = new ErrorProvider();
        Logica.ServicioProcedimientos procedimiento = new ServicioProcedimientos(ConfigConnection.connectionString);
        Logica.ServicioConsultas consultas = new Logica.ServicioConsultas(ConfigConnection.connectionString);
        Manejo_Formulario manejo = new Manejo_Formulario();
        Logica.ServicioFacturacion factura = new Logica.ServicioFacturacion(ConfigConnection.connectionString);
        Manejo_Pdf servicios = new Manejo_Pdf();
        Logica.Conversiones.CoversionesHistoria conversionP= new Logica.Conversiones.CoversionesHistoria(ConfigConnection.connectionString);
        Logica.Conversiones.ConversionesFactura Conversion = new Logica.Conversiones.ConversionesFactura(ConfigConnection.connectionString);
        public FmrFacturacion()
        {
            InitializeComponent();
        }
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
            TablaFactura.DataSource = 0;
            LlenarTabla();
            limpiar();
        }
        private void limpiar()
        {
            txtNumeroContrato.Texts = "";
            txtNumeroFactura.Texts = "";
            txtNumeroPoliza.Texts = "";
            txtPlanBeneficios.Texts = "";
            txtValorComision.Texts = "";
            txtValorDescuentos.Texts = "";
            txtValorTotal.Texts = "";
        }
        private void imprimir()
        {
            if (consultas.ExisteConsulta(Conversion.ExtraerNumAutorizacion(txtNumeroFactura.Texts)))
            {
                string nombre = Conversion.ExtraerNombre(txtNumeroFactura.Texts);
                string id = Conversion.ExtraerId(txtNumeroFactura.Texts);
                string numeroAutorizacion = Conversion.ExtraerNumAutorizacion(txtNumeroFactura.Texts);
                string finalidad = Conversion.ExtraerFinalidad(txtNumeroFactura.Texts);
                string fecha = DateTime.Now.ToString();
                servicios.Guardar(txtNumeroFactura.Texts, nombre, id, fecha, numeroAutorizacion, finalidad, txtValorDescuentos.Texts, txtValorTotal.Texts);
            }
            else if(procedimiento.ExisteHistoria(conversionP.ExtraernumAuto(txtNumeroFactura.Texts))) 
            {
                string nombre = conversionP.ExtraerNombres(txtNumeroFactura.Texts);
                string id = conversionP.ExtraerNumeroId(txtNumeroFactura.Texts);
                string numeroAutorizacion = conversionP.ExtraernumAuto(txtNumeroFactura.Texts);
                string finalidad = conversionP.extraerFinalidadP(txtNumeroFactura.Texts);
                string fecha = DateTime.Now.ToString();
                servicios.Guardar(txtNumeroFactura.Texts, nombre, id, fecha, numeroAutorizacion, finalidad, txtValorDescuentos.Texts, txtValorTotal.Texts);
            }
            
        }
        private void eliminar()
        {
            var facturas = new Facturacion();
            facturas.NumeroFactura= txtNumeroFactura.Texts;
            string msg=factura.Eliminar(facturas);
            MessageBox.Show(msg);
            TablaFactura.DataSource = 0;
            LlenarTabla();
            limpiar();
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
            try
            {
                txtValorTotal.Texts = Convert.ToInt32(factura.ValorTotal(Convert.ToInt32(txtValorComision.Texts), Convert.ToInt32(txtValorDescuentos.Texts))).ToString();
                nulos();
            }
            catch (Exception)
            {

                MessageBox.Show("Rellene Los Datos antes de calcular");
            }
            
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
            btnEliminar.Enabled = true;
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
            txtNumeroFactura.Texts=manejo.extension(txtNumeroFactura.Texts,6);
        }
        private void txtNumeroContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumeroContrato);
            nulos();
            txtNumeroContrato.Texts = manejo.extension(txtNumeroContrato.Texts, 8);
        }

        private void txtPlanBeneficios_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtPlanBeneficios);
            nulos();
            txtPlanBeneficios.Texts = manejo.extension(txtPlanBeneficios.Texts, 8);
        }

        private void txtNumeroPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarN(e, txtNumeroPoliza);
            nulos();
            txtNumeroPoliza.Texts = manejo.extension(txtNumeroPoliza.Texts, 8);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
