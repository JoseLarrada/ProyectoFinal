using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RPacientes : IReportes<Pacientes>
    {
        string ruta = "ReportePacientes.txt";
        public RPacientes(string ruta)
        {
            this.ruta = ruta;
        }
        public RPacientes()
        {
            
        }
        public string GuardarContactos(Pacientes Tipo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Tipo.ToString());
            sw.Close();
            return "Guardado Correctamente";
        }

        public Pacientes mapear(string linea)
        {
            var Cliente = new Pacientes
            {
                TipoId = linea.Split(';')[0],
                NumeroId = linea.Split(';')[1],
                CodigoConsultorio = linea.Split(';')[2],
                TipoUsuario = linea.Split(';')[3],
                PrimerApellido = linea.Split(';')[4],
                SegundoApellido = linea.Split(';')[5],
                PrimerNombre = linea.Split(';')[6],
                SegundoNombre = linea.Split(';')[7],
                Edad = linea.Split(';')[8],
                UnidadMedidaEdad = linea.Split(';')[9],
                Sexo = linea.Split(';')[10],
                CodigoDepartamentosResidencia = linea.Split(';')[11],
                CodigoMunicipioResidencia = linea.Split(';')[12],
                ZonaResidencia = linea.Split(';')[13]
            };
            return Cliente;
        }

        public string Modificar_Eliminar(List<Pacientes> listaActualizada)
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

        public List<Pacientes> ObtenerLista()
        {
            StreamReader sr;
            var lista = new List<Pacientes>();
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
    }
}
