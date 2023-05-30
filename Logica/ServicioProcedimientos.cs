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
        Datos.RProcedimientos repositorio;
        public ServicioProcedimientos(string conexion)
        {
            repositorio = new Datos.RProcedimientos(conexion);
        }
        public string Actualizar(Procedimiento Cliente)
        {
            if (!ExisteProcedimiento(Cliente))
            {
                return "Procedimiento no encontrado";
            }
            else
            {
                string msg=repositorio.Modificar(Cliente);
                return msg;
            }
        }

        public string Crear(Procedimiento proced)
        {
            try
            {
                if (nulos(proced))
                {
                    return "Rellene los Datos Correctamente";
                }
                if (ExisteProcedimiento(proced))
                {
                    return "Ya existe un procedimiento asociado a este codigo";
                }
                else
                {
                    string msg = repositorio.Guardar(proced);
                    return msg;
                }
            }
            catch (Exception e)
            {

                return "No se puede crear el procedimiento"+e.Message;
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
                string resp=repositorio.Eliminar(cliente);
                return resp;
            }
        }
        public bool ExisteProcedimiento(Procedimiento cliente)
        {
            try
            {
                if (repositorio.GetAll() == null)
                {
                    return false;
                }
                else
                {
                    foreach (var item in repositorio.GetAll())
                    {
                        if (item.CodigoC == cliente.CodigoC)
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
        public List<Procedimiento> ObtenerTodos()
        {
            return repositorio.GetAll();
        }

        public bool nulos(Procedimiento cliente)
        {
            if (string.IsNullOrEmpty(cliente.NumeroFactura) || string.IsNullOrEmpty(cliente.NumeroAutorizacion) || string.IsNullOrEmpty(cliente.NumeroIdentificacion) ||
                string.IsNullOrEmpty(cliente.FinalidadProce) || string.IsNullOrEmpty(cliente.AmbitoRealProce) || string.IsNullOrEmpty(cliente.CodigoC) || string.IsNullOrEmpty(cliente.CodigoConsultorio)
                || string.IsNullOrEmpty(cliente.DiagnosticoPpal) || string.IsNullOrEmpty(cliente.FinalidadProce) || string.IsNullOrEmpty(cliente.FormaRealiActo) || cliente.VrlProcedimiento == 0)
            {
                return true;
            }
            return false;
        }
    }
}
