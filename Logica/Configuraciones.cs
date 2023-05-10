using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Configuraciones
    {
        List<string> TiposId = new List<string>();
        List<string> diagnostico = new List<string>();
        List<string> CausaEx = new List<string>();
        List<string> tipoUsuario = new List<string>();
        List<string> sexo = new List<string>();
        List<string> Departamento = new List<string>();
        List<string> Ciudad = new List<string>();
        List<string> FConsultas = new List<string>();
        List<string> CConsulta = new List<string>();
        public List<string> CodigoConsulta()
        {
            CConsulta.Add("Medicina General");
            CConsulta.Add("Medicina Especializada");
            CConsulta.Add("Odontologia General");
            CConsulta.Add("Enfermeria");
            CConsulta.Add("Nutricion y Dietetica");
            CConsulta.Add("Psicologia");
            CConsulta.Add("Fonoaudiologia");
            CConsulta.Add("Terapias Respiratorias");
            CConsulta.Add("Terapias Alternativas");
            return CConsulta;
        }
        public List<string> FinalidadConsultas()
        {
            FConsultas.Add("Atencion post parto");
            FConsultas.Add("Atencion Recien Nacido");
            FConsultas.Add("Atencion Planificacion Familiar");
            FConsultas.Add("Deteccion de alteraciones");
            FConsultas.Add("Deteccion de enfermedad");
            FConsultas.Add("Deteccion de enfermedad Profesional");
            FConsultas.Add("Otro");
            return FConsultas;
        }
        public List<string> TipoIdentificacion()
        {
            TiposId.Add("CC");
            TiposId.Add("TI");
            TiposId.Add("CE");
            TiposId.Add("CD");
            TiposId.Add("PA");
            TiposId.Add("SC");
            TiposId.Add("PE");
            TiposId.Add("RC");
            TiposId.Add("CN");
            TiposId.Add("AS");
            TiposId.Add("MS");
            return TiposId;
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
