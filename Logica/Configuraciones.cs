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
    public class Configuraciones: Iconfiguraciones<TipoDatos>
    {
        List<TipoDatos> List = new List<TipoDatos>();
        TiposDeDatos consultaR = new TiposDeDatos("TiposdeDatos.txt");
        List<string> diagnostico = new List<string>();
        List<string> CausaEx = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> sexo = new List<string>();
        List<string> Departamento = new List<string>();
        List<string> Ciudad = new List<string>();
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
        public List<string> DiagnosticoPPal()
        {
            diagnostico.Add("Fiebre Tifoidea");
            diagnostico.Add("Fiebre Paratifoidea A");
            diagnostico.Add("Fiebres Recurrentes");
            diagnostico.Add("Fiebre Amarilla");
            diagnostico.Add("Infeccion De Genitales Y Trayecto Urogenital[Herpes Simple]");
            diagnostico.Add("Eczema Herpetico");
            diagnostico.Add("Herpes Zoster Ocular");
            diagnostico.Add("Varicela Con Otras Complicaciones");
            diagnostico.Add("Varicela Sin Complicaciones");
            diagnostico.Add("Viruela");
            diagnostico.Add("Viruela De Los Monos");
            diagnostico.Add("Sarampion Complicado Con Meningitis");
            diagnostico.Add("Sarampion Complicado Con Neumonia");
            diagnostico.Add("Rubeola Con Complicaciones Neurologicas");
            diagnostico.Add("Hepatitis Aguda Tipo A");
            diagnostico.Add("Hepatitis Aguda Tipo C");
            diagnostico.Add("Conjuntivitis Debida A Adenovirus");
            diagnostico.Add("Faringoconjuntivitis Viral");
            diagnostico.Add("Otras Conjuntivitis Virales");
            diagnostico.Add("Enfermedad Cardiaca Hipertensiva Con Insuficiencia Cardiaca");
            diagnostico.Add("Hipertension Esencial (Primaria)");
            diagnostico.Add("Hipertension Renovascular");
            diagnostico.Add("Hipertension Pulmonar Primaria");
            diagnostico.Add("Enfermedad Cardiovascular");
            diagnostico.Add("Dientes Impactados");
            diagnostico.Add("Caries Dentaria Detenida");
            diagnostico.Add("otro");
            return diagnostico;
        }
        public List <string> CausaE() 
        {
            CausaEx.Add("Accidente de trabajo");
            CausaEx.Add("Accidente de tránsito");
            CausaEx.Add("Accidente rábico");
            CausaEx.Add("Accidente de ofidico");
            CausaEx.Add("Accidente de ofidico");
            CausaEx.Add("Evento catastrófico");
            CausaEx.Add("Lesión auto infligida");
            CausaEx.Add("Enfermedad general");
            CausaEx.Add("Enfermedad profesional");
            CausaEx.Add("Otro");
            return CausaEx;
        }
        public List <string> TipoU() 
        {
            tipoUsuario.Add("Contributivo");
            tipoUsuario.Add("Subsidiado");
            tipoUsuario.Add("Vinculado");
            tipoUsuario.Add("Particular");
            tipoUsuario.Add("Desplazado");
            tipoUsuario.Add("Otro");
            return tipoUsuario;
        }
        public List <string> Sexo() 
        {
            sexo.Add("Masculino");
            sexo.Add("Femenino");
            sexo.Add("No Binario");
            sexo.Add("Prefiero no decirlo");
            sexo.Add("Otro");
            return sexo;
        }
        public List<string> Departamentos()
        {
            Departamento.Add("Cesar");
            Departamento.Add("La guajira");
            Departamento.Add("Atlantico");
            Departamento.Add("Bolivar");
            Departamento.Add("Magdalena");
            Departamento.Add("Santander");
            return Departamento;
        }
        public List<string> Ciudades()
        {
            Ciudad.Add("C-Valledupar");
            Ciudad.Add("C-La paz");
            Ciudad.Add("C-Becerril");
            Ciudad.Add("C-Bosconia");
            Ciudad.Add("C-Curumani");
            Ciudad.Add("C-Aguachica");
            Ciudad.Add("C-Guacoche");
            Ciudad.Add("C-La jagua del ibirico");
            Ciudad.Add("G-HatoNuevo");
            Ciudad.Add("G-Maicao");
            Ciudad.Add("G-Riohacha");
            Ciudad.Add("G-San Juan ");
            Ciudad.Add("G-Villanueva");
            Ciudad.Add("G-El molino");
            Ciudad.Add("G-Urumita");
            Ciudad.Add("M-Santa Marta");
            Ciudad.Add("M-Aracataca");
            Ciudad.Add("M-El dificil");
            Ciudad.Add("M-El banco");
            Ciudad.Add("A-Barranquilla");
            Ciudad.Add("B-Magangue");
            Ciudad.Add("B-Cartagena");
            Ciudad.Add("B-Tamalameque");
            Ciudad.Add("S-Bucaramanga");
            Ciudad.Add("S-Pie de cuesta");
            return Ciudad;
        }
        

    }
}
