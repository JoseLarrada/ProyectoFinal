using Datos;
using Datos.DatosPrederminados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CFinalidad : Iconfiguraciones<FConsulta>
    {
        List<FConsulta> lista= new List<FConsulta>();
        FinalidadConsulta final= new FinalidadConsulta();
        public CFinalidad()
        {
            Refresh();
        }

        public string Actualizar(FConsulta Cliente, FConsulta NuevoC)
        {
            try
            {
                Cliente.FinalidadC = NuevoC.FinalidadC;
                string msg = final.Guardar(Cliente);
                return msg + "  " + NuevoC.FinalidadC;
            }
            catch (Exception)
            {
                return "NO SE PUDO MODIFICAR";
            }
        }

        public string Crear(FConsulta cliente)
        {
            try
            {
                if (Existe(cliente))
                {
                    return "Tipo de Dato Existente";
                }
                else
                {
                    string msg = final.Guardar(cliente);
                    return msg;
                }
            }
            catch (Exception)
            {

                return "No se puede crear El tipo de dato";
            }
        }

        public string Eliminar(FConsulta cliente)
        {
            if (!Existe(cliente))
            {
                return "NO SE ENCONTRO EL TIPO DE DATO";
            }
            else
            {
                FConsulta Borrado = ObtenerPorId(cliente.FinalidadC);

                lista.Remove(Borrado);

                string resp = final.Modificar_Eliminar(lista);
                Refresh();

                return resp;
            }
        }

        public bool Existe(FConsulta Cliente)
        {
            if (lista == null)
            {
                return false;
            }
            else
            {
                foreach (var item in  lista)
                {
                    if (item.FinalidadC == Cliente.FinalidadC)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public FConsulta ObtenerPorId(string Nombre)
        {
            foreach (var item in lista)
            {
                if (item.FinalidadC == Nombre)
                {
                    return item;
                }
            }
            return null;
        }
        public List<FConsulta> ObtenerTodos()
        {
            return lista;
        }
        private void Refresh()
        {
            lista = final.ObtenerLista();
        }
    }
}
