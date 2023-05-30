using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioFacturacion : Idatos<Facturacion>
    {
        List<Facturacion> ListFactura = new List<Facturacion>();
        ServicioConsultas consulta = new ServicioConsultas("");
        Datos.RFacturacion repositorio;
        public ServicioFacturacion(string conexion)
        {
            repositorio = new Datos.RFacturacion(conexion);
        }
        public string Actualizar(Facturacion Cliente)
        {
            if (!Existe(Cliente.NumeroFactura))
            {
                return "No se encuentra una factura asociada";
            }else if (!RetornarEstado(Cliente))
            {
                return "Factura Cerrada, No se le puede agregar mas movimientos";
            }
            else
            {
                return repositorio.Modificar(Cliente);
            }
        }

        public string Crear(Facturacion cliente)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(Facturacion cliente)
        {
            if (!Existe(cliente.NumeroFactura))
            {
                return "No se encuentra una factura asociada";
            }
            else
            {
                return repositorio.Eliminar(cliente);
            }
        }

        public List<Facturacion> ObtenerTodos()
        {
            return repositorio.GetAll();
        }
        public List<Facturacion> ObtenerNoPagados()
        {
            return repositorio.GetEstadoD();
        }
        public bool Existe(string numero)
        {
            if (ObtenerTodos() == null)
            {
                return false;
            }
            else
            {
                foreach (var item in repositorio.GetAll())
                {
                    if (item.NumeroFactura == numero)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public bool RetornarEstado(Facturacion Cliente) 
        {
            if (ObtenerTodos()==null)
            {
                return false;
            }
            foreach (var item in ObtenerTodos())
            {
                if (item.CodigoC=="D" || item.CodigoC == "d")
                {
                    return true;
                }
            }
            return false;
        }
        public int ValorTotal(int valor1, int valor2)
        {
            if (valor2>valor1)
            {
                return 0;
            }
            return valor1 - valor2;
        }
        public bool nulos(string factura,string contrato,string beneficio,string poliza,string comision,string descuento,string total)
        {
            if (string.IsNullOrEmpty(factura) || string.IsNullOrEmpty(poliza) ||
                string.IsNullOrEmpty(contrato) || string.IsNullOrEmpty(comision)
                || string.IsNullOrEmpty(beneficio) || string.IsNullOrEmpty(descuento)
                || string.IsNullOrEmpty(total))
            {
                return true;
            }
            return false;
        }
    }
}
