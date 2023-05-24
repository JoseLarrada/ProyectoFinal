﻿using Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using System.Data;

namespace Logica
{
    public class ServicioPacientes : Idatos<Pacientes>
    {
        List<Pacientes> ListaPacientes= new List<Pacientes>();
        Datos.RPacientes repositorio;
        public ServicioPacientes(string conexion)
        {
            repositorio = new Datos.RPacientes(conexion);
        }
        public string Actualizar(Pacientes Cliente)
        {
            return repositorio.Modificar(Cliente);
        }

        public string Crear(Pacientes cliente)
        {
            try
            {
                if (Existe(cliente))
                {
                     return "Ya existe el Paciente";
                }
                if (nulos(cliente))
                {
                    return "No puden haber datos sin rellenar";
                }
                else
                {
                     string msg = repositorio.Guardar(cliente);
                     return msg;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Eliminar(Pacientes cliente)
        {
            if (!Existe(cliente))
            {
                return "No se encontro el paciente";
            }
            else
            {
                return repositorio.Eliminar(cliente);
            }
        }

        public bool Existe(Pacientes Cliente)
        {
            if (ObtenerTodos() == null)
            {
                return false;
            }
            else
            {
                foreach (var item in ObtenerTodos())
                {
                    if (item.NumeroId == Cliente.NumeroId)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public Pacientes ObtenerPorId(string identificacion)
        {
            foreach(var item in ListaPacientes)
            {
                if (item.NumeroId==identificacion)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Pacientes> ObtenerTodos()
        {
            return repositorio.GetAll();
        }
        public bool nulos(Pacientes cliente)
        {
            if (string.IsNullOrEmpty(cliente.TipoId) || string.IsNullOrEmpty(cliente.NumeroId) || string.IsNullOrEmpty(cliente.TipoUsuario)|| string.IsNullOrEmpty(cliente.PrimerApellido)||
              string.IsNullOrEmpty(cliente.PrimerNombre)|| string.IsNullOrEmpty(cliente.Edad) || string.IsNullOrEmpty(cliente.UnidadMedidaEdad) || string.IsNullOrEmpty(cliente.CodigoDepartamentosResidencia) ||
              string.IsNullOrEmpty(cliente.CodigoMunicipioResidencia) || string.IsNullOrEmpty(cliente.ZonaResidencia))
            {
                return true;
            }
            return false;
        }
    }
}
