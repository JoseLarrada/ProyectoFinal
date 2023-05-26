using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Conversiones
{
    public class ConversionesFactura
    {
        Datos.Obtencion_de_Id.Obtenciones par;
        public ConversionesFactura(string conexion)
        {
            par = new Datos.Obtencion_de_Id.Obtenciones(conexion);
        }
        public string ExtraerNombre(string codigo)
        {
            string nombre = par.LlamadoGlobal(codigo, "ConsultasFacturacion.ExtraerNombre");
            return nombre;
        }
        public string ExtraerId(string codigo)
        {
            string identificacion = par.LlamadoGlobal(codigo, "ConsultasFacturacion.ExtraerId");
            return identificacion;
        }
        public string ExtraerNumAutorizacion(string codigo)
        {
            string Autorizacion = par.LlamadoGlobal(codigo, "ConsultasFacturacion.ExtraerNumAutorizacion");
            return Autorizacion;
        }
        public string ExtraerFinalidad(string codigo)
        {
            string Finalidad = par.LlamadoGlobal(codigo, "ConsultasFacturacion.ExtraerFinalidad");
            return Finalidad;
        }
    }
}
