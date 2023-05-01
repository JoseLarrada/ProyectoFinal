﻿using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DatosPrederminados
{
    public class FinalidadConsulta
    {
        string ruta = "FinalidadConsulta.txt";
        public FinalidadConsulta(string ruta)
        {
            this.ruta = ruta;
        }
        public FinalidadConsulta()
        {

        }

        public string Guardar(TipoDatos Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Guardado Correctamente";
        }

        public List<TipoDatos> ObtenerLista()
        {
            StreamReader sr;
            var lista = new List<TipoDatos>();
            try
            {
                sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    lista.Add(mapear(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {
                //sr.Close();
                return null;
            }
            finally { sr = null; }
        }

        public string Modificar_Eliminar(List<TipoDatos> listaActualizada)
        {
            string rutaTmp = "tmp.txt";
            try
            {
                var sw = new StreamWriter(rutaTmp);

                foreach (var item in listaActualizada)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
                File.Delete(ruta);
                File.Move(rutaTmp, ruta);
                return "Se actualizo el Paciente";
            }

            catch (Exception)
            {
                return "Error al actualizar";

            }
        }

        public TipoDatos mapear(string linea)
        {
            var dato = new TipoDatos
            {
                NombreTipo = linea.Split(';')[0],
            };
            return dato;
        }
    }
}