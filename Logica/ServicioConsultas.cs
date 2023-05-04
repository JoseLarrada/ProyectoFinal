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
        RConsultas consultaR = new RConsultas("ReporteConsulta.txt");
        public ServicioConsultas()
        {
            Refresh();
        }
        public string Actualizar(Consultas Cliente, Consultas NuevoC)
        {
            try
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
                string msg=consultaR.Guardar(Cliente);
                return msg + "  " + NuevoC.NumeroAutorizacion;
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
                if (Existe(cliente))
                {
                    return "No Existe el paciente";
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

        public bool Existe(Consultas Cliente)
        {
            if (Listconsulta == null)
            {
                return false;
            }
            else
            {
                foreach (var item in Listconsulta)
                {
                    if (item.NumeroIdentificacion == Cliente.NumeroIdentificacion)
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
            Listconsulta = consultaR.ObtenerLista();
        }
    }
}
