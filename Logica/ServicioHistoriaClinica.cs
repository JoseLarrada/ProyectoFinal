using Entidades;
using Logica.ManejoForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioHistoriaClinica: Idatos<HistoriaClinica>
    {
        Datos.RHistorias repositorio;
        Manejo_Pdf pdf=new Manejo_Pdf();
        public ServicioHistoriaClinica(string conexion)
        {
            repositorio = new Datos.RHistorias(conexion);
        }

        public string Actualizar(HistoriaClinica Cliente)
        {
            throw new NotImplementedException();
        }

        public string Crear(HistoriaClinica cliente)
        {
            try
            {
                if (existe(cliente))
                {
                    return "Ya existe esta factura";
                }
                else
                {
                    string msg = repositorio.Guardar(cliente);
                    pdf.GuardarHistoria(cliente);
                    return msg;
                    
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
            
        }

        public string Eliminar(HistoriaClinica cliente)
        {
            throw new NotImplementedException();
        }

        public List<HistoriaClinica> ObtenerTodos()
        {
            return repositorio.GetAll();
        }
        public bool existe(HistoriaClinica cliente)
        {
            if (ObtenerTodos()==null)
            {
                return false;
            }
            foreach (var item in ObtenerTodos())
            {
                if (item.CodigoConsultorio==cliente.CodigoConsultorio)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
