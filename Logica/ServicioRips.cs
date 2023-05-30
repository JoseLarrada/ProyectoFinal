using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioRips
    {
        Datos.ArchivoTexto.RipsConsultas repositorioConsulta;
        Datos.ArchivoTexto.RipsProcedimientos repositorioProcedimiento;
        Datos.ArchivoTexto.RipsFacturas repositorioFactura;
        public ServicioRips(string conexion)
        {
            repositorioConsulta = new Datos.ArchivoTexto.RipsConsultas(conexion);
            repositorioProcedimiento = new Datos.ArchivoTexto.RipsProcedimientos(conexion);
            repositorioFactura = new Datos.ArchivoTexto.RipsFacturas(conexion);
        }
        public string GenerarConsultas(DateTime fecha)
        {
            try
            {
                foreach (var item in repositorioConsulta.GetRips(fecha))
                {
                    repositorioConsulta.Generar(item);
                }
                return "Generado con exito";
            }
            catch (Exception e)
            {

                return "No generado"+e.Message;
            }
        }
        public string GenerarProcedimiento(DateTime fecha)
        {
            try
            {
                foreach (var item in repositorioProcedimiento.GetRips(fecha))
                {
                    repositorioProcedimiento.Generar(item);
                }
                return "Generado con exito";
            }
            catch (Exception e)
            {

                return "No generado"+e.Message;
            }
        } 
        public string GenerarFactura(DateTime fecha)
        {
            try
            {
                foreach (var item in repositorioFactura.GetRips(fecha))
                {
                    repositorioFactura.Generar(item);
                }
                return "Generado con exito";
            }
            catch (Exception e)
            {

                return "No generado"+e.Message;
            }
        }
    }
}
