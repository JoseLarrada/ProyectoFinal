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
        ServicioPacientes pacientes = new ServicioPacientes("");
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
                if (!Existe(proced))
                {
                    return "No Existe el paciente";
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
        public bool Existe(Procedimiento Cliente)
        {
            if (repositorio.GetAll() == null)
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

        public List<Procedimiento> ObtenerTodos()
        {
            return repositorio.GetAll();
        }

        public bool nulos(Procedimiento cliente)
        {
            throw new NotImplementedException();
        }
    }
}
