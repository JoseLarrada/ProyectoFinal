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
    public class Configuraciones
    {
        List<TipoDatos> List = new List<TipoDatos>();
        TiposDeDatos consultaR = new TiposDeDatos("TiposdeDatos.txt");
       

        public Configuraciones()
        {
            Refresh();
        }
        public string Actualizar(TipoDatos Cliente, TipoDatos NuevoC)
        {
            try
            {
                Cliente.NombreTipo = NuevoC.NombreTipo;
                string msg = consultaR.Guardar(Cliente);
                return msg + "  " + NuevoC.NombreTipo;
            }
            catch (Exception)
            {
                return "NO SE PUDO MODIFICAR";
            }
        }
        private void Refresh()
        {
            List = consultaR.ObtenerLista();
        }
        public bool Existe(TipoDatos Cliente)
        {
            if (List == null)
            {
                return false;
            }
            else
            {
                foreach (var item in List)
                {
                    if (item.NombreTipo == Cliente.NombreTipo)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public string Crear(TipoDatos cliente)
        {
            try
            {
                if (Existe(cliente))
                {
                    return "Tipo de Dato Existente";
                }
                else
                {
                    string msg = consultaR.Guardar(cliente);
                    return msg;
                }
            }
            catch (Exception)
            {

                return "No se puede crear El tipo de dato";
            }
        }
        public List<TipoDatos> ObtenerTodos()
        {
            return List;
        }
        public string Eliminar(TipoDatos cliente)
        {
            if (!Existe(cliente))
            {
                return "NO SE ENCONTRO EL TIPO DE DATO";
            }
            else
            {
                TipoDatos Borrado = ObtenerPorId(cliente.NombreTipo);

                List.Remove(Borrado);

                string resp = consultaR.Modificar_Eliminar(List);
                Refresh();

                return resp;
            }
        }
        public TipoDatos ObtenerPorId(string Nombre)
        {
            foreach (var item in List)
            {
                if (item.NombreTipo == Nombre)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
