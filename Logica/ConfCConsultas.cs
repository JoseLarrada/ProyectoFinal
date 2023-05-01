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
    public class ConfCConsultas
    {
        List<CodConsulta> List = new List<CodConsulta>();
        CodigoConsulta codi = new CodigoConsulta("CodigoConsulta.txt");

        public ConfCConsultas()
        {
            Refresh();
        }

        public CodConsulta ObtenerPorId(string Nombre)
        {
            foreach (var item in List)
            {
                if (item.CConsulta == Nombre)
                {
                    return item;
                }
            }
            return null;
        }
        public string Crear(CodConsulta cliente)
        {
            try
            {
                if (Existe(cliente))
                {
                    return "Tipo de Dato Existente";
                }
                else
                {
                    string msg = codi.Guardar(cliente);
                    return msg;
                }
            }
            catch (Exception)
            {

                return "No se puede crear El tipo de dato";
            }
        }
        public string Actualizar(CodConsulta Cliente, CodConsulta NuevoC)
        {
            try
            {
                Cliente.CConsulta = NuevoC.CConsulta;
                string msg = codi.Guardar(Cliente);
                return msg + "  " + NuevoC.CConsulta;
            }
            catch (Exception)
            {
                return "NO SE PUDO MODIFICAR";
            }
        }
        public string Eliminar(CodConsulta cliente)
        {
            if (!Existe(cliente))
            {
                return "NO SE ENCONTRO EL TIPO DE DATO";
            }
            else
            {
                CodConsulta Borrado = ObtenerPorId(cliente.CConsulta);

                List.Remove(Borrado);

                string resp = codi.Modificar_Eliminar(List);
                Refresh();

                return resp;
            }
        }
        private void Refresh()
        {
            List = codi.ObtenerLista();
        }
        public bool Existe(CodConsulta Cliente)
        {
            if (List == null)
            {
                return false;
            }
            else
            {
                foreach (var item in List)
                {
                    if (item.CConsulta == Cliente.CConsulta)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public List<CodConsulta> ObtenerTodos()
        {
            return List;
        }
    }
}
