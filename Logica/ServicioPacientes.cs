using Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Logica
{
    public class ServicioPacientes : Idatos<Pacientes>
    {
        List<Pacientes> ListaPacientes= new List<Pacientes>();
        RPacientes paciente=new RPacientes("ReportePacientes.txt");
        public ServicioPacientes()
        {
            Refresh();
        }
        public string Actualizar(Pacientes Cliente, Pacientes NuevoC)
        {
            try
            {
                Cliente.TipoId = NuevoC.TipoId;
                Cliente.NumeroId = NuevoC.NumeroId;
                Cliente.CodigoConsultorio = NuevoC.CodigoConsultorio;
                Cliente.TipoUsuario = NuevoC.TipoUsuario;
                Cliente.PrimerApellido = NuevoC.PrimerApellido;
                Cliente.SegundoApellido = NuevoC.SegundoApellido;
                Cliente.PrimerNombre = NuevoC.PrimerNombre;
                Cliente.SegundoNombre = NuevoC.SegundoNombre;
                Cliente.Edad = NuevoC.Edad;
                Cliente.UnidadMedidaEdad = NuevoC.UnidadMedidaEdad;
                Cliente.Sexo = NuevoC.Sexo;
                Cliente.CodigoDepartamentosResidencia = NuevoC.CodigoDepartamentosResidencia;
                Cliente.CodigoMunicipioResidencia = NuevoC.CodigoMunicipioResidencia;
                Cliente.ZonaResidencia = NuevoC.ZonaResidencia;
                string msg= paciente.Modificar_Eliminar(ListaPacientes);
                return msg + "  " + NuevoC.PrimerNombre;
            }
            catch (Exception)
            {
                return "NO SE PUDO MODIFICAR";
            }
        }

        public string Crear(Pacientes cliente)
        {
            try
            {
                if (Existe(cliente))
                {
                    return "Ya existe el Paciente";
                }
                else
                {
                    string msg=paciente.Guardar(cliente);
                    return msg;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Eliminar(Pacientes cliente)
        {
            if (!Existe(cliente))
            {
                return "NO SE ENCONTRO EL CONTACTO";
            }
            else
            {
                Pacientes Borrado =  ObtenerPorId(cliente.NumeroId);

                ListaPacientes.Remove(Borrado);

                string resp = paciente.Modificar_Eliminar(ListaPacientes);
                Refresh();

                return resp;
            }
        }

        public bool Existe(Pacientes Cliente)
        {
            if (ListaPacientes == null)
            {
                return false;
            }
            else
            {
                foreach (var item in ListaPacientes)
                {
                    if (item.NumeroId == Cliente.NumeroId)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public Pacientes ObtenerPorId(string identificacion)
        {
            foreach(var item in ListaPacientes)
            {
                if (item.NumeroId==identificacion)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Pacientes> ObtenerTodos()
        {
            return ListaPacientes;
        }

        public double ValidarDouble(string numero)
        {
            try
            {
                double op = 0.0;
                op = double.Parse(numero);
                return op;
            }
            catch (Exception)
            {
                return 0.0;
            }
        }

        public int ValidarEnteros(string numero)
        {
            try
            {
                int op = 0;
                op = int.Parse(numero);
                return op;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool VExtension(string Cliente, int longitud)
        {
            for (int i = 0; i < Cliente.Length; i++)
            {
                if (Cliente.Length > longitud)
                {
                    return true;
                }
            }
            return false;
        }
        private void Refresh()
        {
            ListaPacientes = paciente.ObtenerLista();
        }
    }
}
