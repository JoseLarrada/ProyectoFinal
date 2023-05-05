using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioProcedimientos : Idatos<Procedimiento>
    {
        List<Procedimiento> ListProcedimiento = new List<Procedimiento>();
        ServicioPacientes pacientes = new ServicioPacientes();
        RProcedimientos Proceso = new RProcedimientos("ReporteProcedimiento.txt");
        public ServicioProcedimientos()
        {
            Refresh();
        }
        public string Actualizar(Procedimiento Cliente, Procedimiento NuevoC)
        {
            try
            {
                if (!Existe(Cliente))
                {
                    return "No Existe el paciente";
                }
                else
                {
                    Cliente.NumeroFactura = NuevoC.NumeroFactura;
                    Cliente.CodigoConsultorio = NuevoC.CodigoConsultorio;
                    Cliente.TipoId = NuevoC.TipoId;
                    Cliente.NumeroIdentificacion = NuevoC.NumeroIdentificacion;
                    Cliente.FechaProcedimiento = NuevoC.FechaProcedimiento;
                    Cliente.NumeroAutorizacion = NuevoC.NumeroAutorizacion;
                    Cliente.AmbitoRealProce = NuevoC.AmbitoRealProce;
                    Cliente.FinalidadProce = NuevoC.FinalidadProce;
                    Cliente.DiagnosticoPpal = NuevoC.DiagnosticoPpal;
                    Cliente.CodigoDiagPpal = NuevoC.CodigoDiagPpal;
                    Cliente.FormaRealiActo = NuevoC.FormaRealiActo;
                    Cliente.VrlProcedimiento = NuevoC.VrlProcedimiento;
                    string msg = Proceso.Modificar_Eliminar(ListProcedimiento);
                    return msg + "  " + NuevoC.NumeroAutorizacion;
                }
            }
            catch (Exception)
            {

                return "NO SE PUDO ACTUALIZAR";
            }
        }

        public string Crear(Procedimiento cliente)
        {
            try
            {
                //if (!Existe(cliente))
                //{
                //    return "No Existe el paciente";
                //}
                if (ExisteProcedimiento(cliente))
                {
                    return "Ya existe un procedimiento asociado a este codigo";
                }
                else
                {
                    string msg = Proceso.Guardar(cliente);
                    return msg;
                }

            }
            catch (Exception)
            {

                return "No se puede crear la consulta";
            }
        }

        public string Eliminar(Procedimiento cliente)
        {
            if (!ExisteProcedimiento(cliente))
            {
                return "NO SE ENCONTRO LA CONSULTA";
            }
            else
            {
                Procedimiento Borrado = ObtenerPorId(cliente.NumeroIdentificacion);

                ListProcedimiento.Remove(Borrado);

                string resp = Proceso.Modificar_Eliminar(ListProcedimiento);
                Refresh();

                return resp;
            }
        }
        public bool ExisteProcedimiento(Procedimiento cliente)
        {
            try
            {
                if (ListProcedimiento == null)
                {
                    return false;
                }
                else
                {
                    foreach (var item in ListProcedimiento)
                    {
                        if (item.NumeroIdentificacion == cliente.NumeroIdentificacion)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Existe(Procedimiento Cliente)
        {
            if (ListProcedimiento == null)
            {
                return false;
            }
            else
            {
                foreach (var item in pacientes.ObtenerTodos())
                {
                    if (item.NumeroId == Cliente.NumeroIdentificacion)
                    {
                        return true;
                    }
                }
                return false;
            }

        }

        public Procedimiento ObtenerPorId(string identificacion)
        {
            foreach (var item in ListProcedimiento)
            {
                if (item.NumeroIdentificacion == identificacion)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Procedimiento> ObtenerTodos()
        {
            return ListProcedimiento;
        }
        private void Refresh()
        {
            ListProcedimiento = Proceso.ObtenerLista();
        }
    }
}
