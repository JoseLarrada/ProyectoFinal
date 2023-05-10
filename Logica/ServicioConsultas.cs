using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioConsultas : Idatos<Consultas>
    {
        List<Consultas> Listconsulta =new List<Consultas>();
        ServicioPacientes pacientes= new ServicioPacientes();
        RConsultas consultaR = new RConsultas("ReporteConsulta.txt");
        public ServicioConsultas()
        {
            Refresh();
        }
        public string Actualizar(Consultas Cliente, Consultas NuevoC)
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
                        Cliente.FechaConsulta = NuevoC.FechaConsulta;
                        Cliente.NumeroAutorizacion = NuevoC.NumeroAutorizacion;
                        Cliente.CodigoC = NuevoC.CodigoC;
                        Cliente.FinalidadConsulta = NuevoC.FinalidadConsulta;
                        Cliente.CausaExterna = NuevoC.CausaExterna;
                        Cliente.CodDiagPpal = NuevoC.CodDiagPpal;
                        Cliente.CodDiaRel1 = NuevoC.CodDiaRel1;
                        Cliente.CodDiaRel2 = NuevoC.CodDiaRel2;
                        Cliente.CodDiaRel3 = NuevoC.CodDiaRel3;
                        Cliente.TipoDiagPpal = NuevoC.TipoDiagPpal;
                        Cliente.ValorConsulta = NuevoC.ValorConsulta;
                        Cliente.ValorCuoMod = NuevoC.ValorCuoMod;
                        Cliente.ValorNetoPagar = NuevoC.ValorNetoPagar;
                        string msg = consultaR.Modificar_Eliminar(Listconsulta);
                        return msg + "  " + NuevoC.NumeroAutorizacion;
                    }
            }
            catch (Exception)
            {
                return "NO SE PUDO MODIFICAR";
            }
        }

        public string Crear(Consultas cliente)
        {
            try
            {
                if(nulos(cliente))
                {
                    return "RELLENE LOS DATOS";
                }
                if (!Existe(cliente))
                {
                    return "No Existe el paciente";
                }
                if (ExisteConsulta(cliente))
                {
                    return "Ya hay un codigo de consulta con este numero";
                }
                else
                {
                    string msg = consultaR.Guardar(cliente);
                    return msg;
                }
                
            }
            catch (Exception)
            {

                return "No se puede crear la consulta";
            }
        }

        public string Eliminar(Consultas cliente)
        {
            if (!Existe(cliente))
            {
                return "NO SE ENCONTRO LA CONSULTA";
            }
            else
            {
                Consultas Borrado = ObtenerPorId(cliente.NumeroIdentificacion);

                Listconsulta.Remove(Borrado);

                string resp = consultaR.Modificar_Eliminar(Listconsulta);
                Refresh();

                return resp;
            }
        }

        public bool ExisteConsulta(Consultas cliente)
        {
            try
            {
                if (Listconsulta == null)
                {
                    return false;
                }
                else
                {
                    foreach (var item in Listconsulta)
                    {
                        if (item.NumeroAutorizacion == cliente.NumeroAutorizacion)
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
        public bool Existe(Consultas Cliente)
        {
            if (Listconsulta == null)
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

        public Consultas ObtenerPorId(string identificacion)
        {
            foreach (var item in Listconsulta)
            {
                if (item.NumeroIdentificacion == identificacion)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Consultas> ObtenerTodos()
        {
            return Listconsulta;
        }
        private void Refresh()
        {
            Listconsulta = consultaR.ObtenerLista();
        }

        public bool nulos(Consultas cliente)
        {
            if (string.IsNullOrEmpty(cliente.NumeroFactura) || string.IsNullOrEmpty(cliente.TipoId) || string.IsNullOrEmpty(cliente.NumeroIdentificacion) || string.IsNullOrEmpty(cliente.FechaConsulta.ToString()) ||
                string.IsNullOrEmpty(cliente.NumeroAutorizacion) || string.IsNullOrEmpty(cliente.CodigoC) || string.IsNullOrEmpty(cliente.FinalidadConsulta) || string.IsNullOrEmpty(cliente.CausaExterna) ||
                string.IsNullOrEmpty(cliente.CodDiagPpal) || string.IsNullOrEmpty(cliente.TipoDiagPpal) || string.IsNullOrEmpty(cliente.ValorConsulta.ToString()) || string.IsNullOrEmpty(cliente.ValorCuoMod.ToString()) 
                || string.IsNullOrEmpty(cliente.ValorNetoPagar.ToString()))
            {
                return true;
            }
            return false;
        }
    }
}
