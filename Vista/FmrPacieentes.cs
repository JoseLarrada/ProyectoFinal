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
    public partial class FmrPacieentes : Form
    {
        public FmrPacieentes()
        {
            InitializeComponent();
        }
        int posicion = 0;
        Configuraciones combob = new Configuraciones();
        Manejo_Form manejo = new Manejo_Form();
        ServicioPacientes pacientes = new ServicioPacientes();
        private void llenarcombo()
        {

            //Tipos de identificacion 
            foreach (var item in combob.ObtenerTodos())
            {
                cbbTipos.Items.Add(item);
            }
            //Departamentos
            foreach (var item in combob.Departamentos())
            {
                cbbDepartamentos.Items.Add(item);
            }
            //Ciudades
            foreach (var item in combob.Ciudades())
            {
                cbbCiudad.Items.Add(item);
            }
            //Sexo
            foreach (var item in combob.Sexo())
            {
                cbbSexo.Items.Add(item);
            }
            //Localidad
            cbbZona.Items.Add("Urbano");
            cbbZona.Items.Add("Rural");
            //Tipo Pacientes
            foreach (var item in combob.TipoU())
            {
                ccbTipoUsuario.Items.Add(item);
            }
        }
        private void prueba()
        {
            string ciudad = "";
            switch (cbbDepartamentos.Text)
            {
                case "Cesar":
                    ciudad = "C-";
                    break;
                case "La guajira":
                    ciudad = "G-";
                    break;
                case "Atlantico":
                    ciudad = "A-";
                    break;

                case "Bolivar":
                    ciudad = "B-";
                    break;
                case "Magdalena":
                    ciudad = "M-";
                    break;
                case "Santander":
                    ciudad = "S-";
                    break;
            }
            foreach (var item in combob.Departamentos())
            {
                if (cbbDepartamentos.Text == item)
                {
                    foreach (var item2 in combob.Ciudades())
                    {
                        if (item2.StartsWith(ciudad))
                        {
                            cbbCiudad.Items.Add(item2);
                        }
                    }
                }
            }
        }
        private void guardar()
        {
            var paciente = new Pacientes();
            paciente.TipoId = cbbTipos.Text;
            paciente.NumeroId = txtNumI.Text;
            paciente.CodigoConsultorio = "3052023";
            paciente.TipoUsuario = ccbTipoUsuario.Text;
            paciente.PrimerApellido = txtxPapellido.Text;
            paciente.SegundoApellido = txtxSapellido.Text;
            paciente.PrimerNombre = txtxPnombre.Text;
            paciente.SegundoNombre = txtxSnombre.Text;
            paciente.Edad = txtEdad.Text;
            paciente.UnidadMedidaEdad = txtMedidaEdad.Text;
            paciente.CodigoDepartamentosResidencia = cbbDepartamentos.Text;
            paciente.CodigoMunicipioResidencia = cbbCiudad.Text;
            paciente.ZonaResidencia = cbbZona.Text;
            paciente.Sexo =cbbSexo.Text;
            string msg = pacientes.Crear(paciente);
            MessageBox.Show(msg);
            manejo.guardartabla(tablap,paciente, cbbTipos, txtNumI, txtxPnombre, txtxPapellido, txtEdad, cbbSexo);
            limpiar();
            
        }
        private void guardartabla(Pacientes table)
        {
            table.TipoId = cbbTipos.Text;
            table.NumeroId = txtNumI.Text;
            table.PrimerNombre = txtxPnombre.Text;
            table.PrimerApellido = txtxPapellido.Text;
            table.Edad = txtEdad.Text;
            table.Sexo = cbbSexo.Text;
            tablap.Rows.Add(table.TipoId, table.NumeroId, table.PrimerNombre, table.Edad, table.Sexo);
        }
        private void modificar()
        {
            var pacientenuevo = new Pacientes();
            var paciente = pacientes.ObtenerPorId(txtNumI.Text);
            if (paciente == null)
            {
                MessageBox.Show("PACIENTE INEXISTENTE");
            }
            else
            {
                pacientenuevo.TipoId = cbbTipos.Text;
                pacientenuevo.NumeroId = txtNumI.Text;
                pacientenuevo.CodigoConsultorio = "3052023";
                pacientenuevo.TipoUsuario = ccbTipoUsuario.Text;
                pacientenuevo.PrimerApellido = txtxPapellido.Text;
                pacientenuevo.SegundoApellido = txtxSapellido.Text;
                pacientenuevo.PrimerNombre = txtxPnombre.Text;
                pacientenuevo.SegundoNombre = txtxSnombre.Text;
                pacientenuevo.Edad = txtEdad.Text;
                pacientenuevo.UnidadMedidaEdad = txtMedidaEdad.Text;
                pacientenuevo.CodigoDepartamentosResidencia = cbbDepartamentos.Text;
                pacientenuevo.CodigoMunicipioResidencia = cbbCiudad.Text;
                pacientenuevo.ZonaResidencia = cbbZona.Text;
                pacientenuevo.Sexo = cbbSexo.Text;
                string msg = pacientes.Actualizar(paciente, pacientenuevo);
                MessageBox.Show(msg);
                manejo.modificartabla(tablap, posicion, cbbTipos, txtNumI, txtxPnombre, txtxPapellido,
                                      txtEdad, cbbSexo);
                limpiar();
                
            }
        }
        private void eliminar()
        {
            var paciente = new Pacientes();
            paciente.NumeroId = txtNumI.Text;
            string msg = pacientes.Eliminar(paciente);
            MessageBox.Show(msg);
            tablap.Rows.RemoveAt(posicion);
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
            foreach (var item in pacientes.ObtenerTodos())
            {
                tablap.Rows.Add(item.TipoId, item.NumeroId, item.PrimerNombre, item.PrimerApellido, item.Edad, item.Sexo);
            }
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
        }

        private void tablap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tablap.CurrentRow.Index;
            cbbTipos.Text = tablap.CurrentRow.Cells[0].Value.ToString();
            txtNumI.Text = tablap.CurrentRow.Cells[1].Value.ToString();
            txtxPnombre.Text= tablap.CurrentRow.Cells[2].Value.ToString();
            txtxPapellido.Text= tablap.CurrentRow.Cells[3].Value.ToString();
            txtEdad.Text= tablap.CurrentRow.Cells[4].Value.ToString();
            cbbSexo.Text= tablap.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtNumI_KeyPress(object sender, KeyPressEventArgs e)
        {
            manejo.validarN(e, txtNumI);
            manejo.validarExtension(cbbTipos,e, txtNumI,btnInsertar);
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
    }
}
