using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Configuraciones
{
    public class ManejoUnidad
    {
        public string Filtrado(string palabra,string palabra2,string texto)
        {
            if (texto.Contains(palabra) || texto.Contains(palabra2))
            {
                return "";
            }
            else
            {
                return texto;
            }
        }
        public string meses(string palabra, string texto)
        {
            if (texto.Contains("18"))
            {
                return "";
            }
            else
            {
                return texto;
            }
        }
        public string Unidad_Medida(ComboBox cmb, string texto)
        {
            switch (cmb.SelectedIndex)
            {
                case 0:
                    return Filtrado("meses","dias",texto);
                case 1:
                    return Filtrado("meses", "dias", texto);
                case 2:
                    return texto.ToString();
                case 3:
                    return texto.ToString();
                case 4:
                    return texto.ToString();
                case 5:
                    return texto.ToString();
                case 6:
                    return texto.ToString();
                case 7:
                    return texto.ToString();
                case 8:
                    return texto.ToString();
                case 9:
                    return texto.ToString();
                case 10:
                    return texto.ToString();
                default: return texto.ToString();
            }
        }
    }
}
