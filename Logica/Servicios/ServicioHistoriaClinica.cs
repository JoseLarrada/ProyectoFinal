﻿using Entidades;
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
        Datos.Informes inHistoria;
        public ServicioHistoriaClinica(string conexion)
        {
            repositorio = new Datos.RHistorias(conexion);
            inHistoria = new Datos.Informes(conexion);
        }

        public string Actualizar(HistoriaClinica Cliente)
        {
            try
            {
                if (!existePersona(Cliente))
                {
                    return "No existe Una persona asociada";
                }
                else
                {
                    string msg = repositorio.Modificar(Cliente);
                    pdf.GuardarHistoria(Cliente);
                    return msg;

                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public string Crear(HistoriaClinica cliente)
        {
            try
            {
                if (!nulos(cliente.NumeroFactura,cliente.Tratamiento,cliente.Medicacion))
                {
                    return "Rellene todos los datos ";
                }
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
            try
            {
                if (!existePersona(cliente))
                {
                    return "No se encontro el usuario";
                }
                else
                {
                    string msg=repositorio.Eliminar(cliente);
                    return msg;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool nulos(string factura, string descripcion,string medicacion)
        {
            if (string.IsNullOrEmpty(factura) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(medicacion))
            {
                return true;
            }
            else
            {
                return false;
            }
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
        public bool existePersona(HistoriaClinica cliente)
        {
            if (ObtenerTodos()==null)
            {
                return false;
            }
            foreach (var item in ObtenerTodos())
            {
                if(item.NumeroIdentificacion==cliente.NumeroIdentificacion) { return true; }
            }
            return false;
        }
        public string GenerarPDF()
        {
            return inHistoria.InformesHistorias(ObtenerTodos());
        }
    }
}
