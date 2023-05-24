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
        ServicioPacientes pacientes= new ServicioPacientes("");
        Datos.RConsultas repositorio;
        public ServicioConsultas(string conexion)
        {
            repositorio = new Datos.RConsultas(conexion);
        }
        public string Actualizar(Consultas Consulta)
        {
            try
            {
                    if (!Existe(Consulta))
                    {
                        return "No Existe el paciente";
                    }
                    else
                    {
                        return repositorio.Modificar(Consulta) + "  " + Consulta.NumeroAutorizacion;
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
                else
                {
                    return repositorio.Guardar(cliente);
                }
                
            }
            catch (Exception e)
            {

                return "No se puede crear la consulta  "+e.Message;
            }
        }

        public string Eliminar(Consultas cliente)
        {
            if (!ExisteConsulta(cliente))
            {
                return "NO SE ENCONTRO LA CONSULTA";
            }
            else
            {
                string resp = repositorio.Eliminar(cliente);
                return resp;
            }
        }

        public bool ExisteConsulta(Consultas cliente)
        {
            try
            {
                if (repositorio.GetAll() == null)
                {
                    return false;
                }
                else
                {
                    foreach (var item in ObtenerTodos())
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
            return repositorio.GetAll();
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
