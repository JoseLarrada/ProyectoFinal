using Datos;
using Entidades;
using Logica;
using Logica.Configuraciones;
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
    public partial class FmrPacieentes : Form
    {
        public FmrPacieentes()
        {
            InitializeComponent();
        }
        int posicion = 0;
        Manejo_Formulario manejo = new Manejo_Formulario();
        Manejo_Edades edades = new Manejo_Edades();
        ManejoUnidad unidad=new ManejoUnidad();
        Logica.ConfiguracionNombres muestra = new Logica.ConfiguracionNombres(ConfigConnection.connectionString);
        ServicioPacientes pacientes = new ServicioPacientes(ConfigConnection.connectionString);
        Logica.ConfiguracionesCodigos abstraccion = new Logica.ConfiguracionesCodigos(ConfigConnection.connectionString);
        Logica.Datos_Prederminados llenado = new Logica.Datos_Prederminados(ConfigConnection.connectionString);
        private void llenarcombo()
        {
            llenado.TipoIdentificacion(cbbTipos);
            llenado.Departamentos(cbbDepartamentos);
            llenado.Zona(cbbZona);
            llenado.Sexo(cbbSexo);
            llenado.TipoUsuarios(ccbTipoUsuario);
        }
        private void guardar()
        {
            
                var paciente = new Pacientes();
                paciente.TipoId = abstraccion.TipoIdentificacion(cbbTipos.Text);
                paciente.NumeroId = txtNumI.Text;
                paciente.CodigoConsultorio = "750309";
                paciente.TipoUsuario = abstraccion.TipoUsuarios(ccbTipoUsuario.Text);
                paciente.PrimerApellido = txtxPapellido.Text;
                paciente.SegundoApellido = txtxSapellido.Text;
                paciente.PrimerNombre = txtxPnombre.Text;
                paciente.SegundoNombre = txtxSnombre.Text;
                paciente.Edad = txtEdad.Text;
                paciente.UnidadMedidaEdad = txtMedidaEdad.Text;
                paciente.CodigoDepartamentosResidencia = abstraccion.Departamentos(cbbDepartamentos.Text);
                paciente.CodigoMunicipioResidencia = abstraccion.Municipios(cbbCiudad.Text);
                paciente.ZonaResidencia = abstraccion.Zona(cbbZona.Text);
                paciente.Sexo = abstraccion.Sexo(cbbSexo.Text);
                string msg = pacientes.Crear(paciente);
                MessageBox.Show(msg);
                limpiar();
        }
        private void modificar()
        {
            var pacientenuevo = new Pacientes();
                pacientenuevo.TipoId = abstraccion.TipoIdentificacion(cbbTipos.Text);
                pacientenuevo.NumeroId = txtNumI.Text;
                pacientenuevo.CodigoConsultorio = "750309";
                pacientenuevo.TipoUsuario = abstraccion.TipoUsuarios(ccbTipoUsuario.Text);
                pacientenuevo.PrimerApellido = txtxPapellido.Text;
                pacientenuevo.SegundoApellido = txtxSapellido.Text;
                pacientenuevo.PrimerNombre = txtxPnombre.Text;
                pacientenuevo.SegundoNombre = txtxSnombre.Text;
                pacientenuevo.Edad = txtEdad.Text;
                pacientenuevo.UnidadMedidaEdad = txtMedidaEdad.Text;
                pacientenuevo.CodigoDepartamentosResidencia = abstraccion.Departamentos(cbbDepartamentos.Text);
                pacientenuevo.CodigoMunicipioResidencia = abstraccion.Municipios(cbbCiudad.Text);
                pacientenuevo.ZonaResidencia = abstraccion.Zona(cbbZona.Text);
                pacientenuevo.Sexo = abstraccion.Sexo(cbbSexo.Text);
                string msg = pacientes.Actualizar(pacientenuevo);
                MessageBox.Show(msg);
                limpiar();
        }
        private void eliminar()
        {
            var paciente = new Pacientes();
            paciente.NumeroId = txtNumI.Text;
            MessageBox.Show(paciente.NumeroId);
            string msg = pacientes.Eliminar(paciente);
            MessageBox.Show(msg);
            limpiar(); 
        }
        private void inicio()
        {
            PanelDatos.Visible = true;
            PanelVista.Visible = false;
            btnModificar.Visible = false;
            BtnEliminar.Visible = false;
            btnInsertar.Visible = true;
            btnInsertar.Location = new System.Drawing.Point(403,485);
        }
        private void limpiar()
        {
            txtNumI.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtxPapellido.Text = string.Empty;
            txtMedidaEdad.Text = string.Empty;
            txtxPnombre.Text = string.Empty;
            txtxSapellido.Text = string.Empty;
            txtxSnombre.Text = string.Empty;
            cbbCiudad.Text = string.Empty;
            cbbDepartamentos.Text = string.Empty;
            cbbSexo.Text = string.Empty;
            cbbTipos.Text = string.Empty;
            cbbZona.Text = string.Empty;
        }
        private void llenartabla()
        {
            tablap.DataSource = pacientes.ObtenerTodos();
        }
        private void FmrPacieentes_Load(object sender, EventArgs e)
        {
            llenarcombo();
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

        private void checkView_CheckedChanged(object sender, EventArgs e)
        {
            PanelDatos.Visible = false;
            PanelVista.Visible = true;
            btnInsertar.Visible = false;
            btnModificar.Visible = true;
            BtnEliminar.Visible = true;
            btnModificar.Location = new Point(144,485);
            if (!checkView.Checked)
            {
                inicio();
            }
            tablap.DataSource = 0;
            llenartabla();
        }

        private void tablap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tablap.CurrentRow.Index;
            cbbTipos.Text = muestra.TipoIdentificacion(tablap.CurrentRow.Cells[0].Value.ToString());
            txtNumI.Text = tablap.CurrentRow.Cells[1].Value.ToString();
            ccbTipoUsuario.Text= muestra.TipoUsuarios(tablap.CurrentRow.Cells[3].Value.ToString());
            txtxPapellido.Text= tablap.CurrentRow.Cells[4].Value.ToString();
            txtxSapellido.Text= tablap.CurrentRow.Cells[5].Value.ToString();
            txtxPnombre.Text= tablap.CurrentRow.Cells[6].Value.ToString();
            txtxSnombre.Text= tablap.CurrentRow.Cells[7].Value.ToString();
            txtEdad.Text = tablap.CurrentRow.Cells[8].Value.ToString();
            txtMedidaEdad.Text = tablap.CurrentRow.Cells[9].Value.ToString();
            cbbSexo.Text = muestra.Sexo(tablap.CurrentRow.Cells[10].Value.ToString());
            cbbDepartamentos.Text = muestra.Departamentos(tablap.CurrentRow.Cells[11].Value.ToString());
            cbbCiudad.Text = muestra.Municipios(tablap.CurrentRow.Cells[12].Value.ToString());
            cbbZona.Text = muestra.Zona(tablap.CurrentRow.Cells[13].Value.ToString());
        }

        private void txtNumI_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtNumI);
            manejo.validarExtension(cbbTipos,e, txtNumI,btnInsertar);
            txtNumI.MaxLength = manejo.extensioncajadetexto(cbbTipos);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtEdad);
            txtEdad.MaxLength = 3;
        }

        private void txtxPnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.ValidarLetras(e, txtxPnombre);
            txtxPnombre.MaxLength=15;
        }

        private void txtxSnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.ValidarLetras(e, txtxSnombre);
            txtxSnombre.MaxLength = 15;
        }

        private void txtxPapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.ValidarLetras(e, txtxPapellido);
            txtxPapellido.MaxLength = 15;
        }

        private void txtxSapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.ValidarLetras(e, txtxSapellido);
            txtxSapellido.MaxLength = 15;
        }

        private void cbbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbCiudad.Text))
            {
                llenado.filtro(cbbCiudad, abstraccion.Departamentos(cbbDepartamentos.Text));
            }
            else
            {
                cbbCiudad.Items.Clear();
                cbbCiudad.Text = "";
                llenado.filtro(cbbCiudad, abstraccion.Departamentos(cbbDepartamentos.Text));
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            txtEdad.Text = edades.Edad(cbbTipos, int.Parse(txtEdad.Text));
            if (txtEdad.Text == "")
            {
                MessageBox.Show("Edad no permitida para este tipo de identificacion");
            }
        }

        private void txtMedidaEdad_Leave(object sender, EventArgs e)
        {
            txtMedidaEdad.Text = unidad.Unidad_Medida(cbbTipos, txtMedidaEdad.Text);
            if (txtMedidaEdad.Text=="")
            {
                MessageBox.Show("Unidad no permitida para este tipo de identificacion");
            }
        }
    }
}
