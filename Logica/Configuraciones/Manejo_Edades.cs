using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Configuraciones
{
    public class Manejo_Edades
    {
        public string Edad(ComboBox cmb,int valor)
        {
            switch (cmb.SelectedIndex)
            {
                case 0:
                    return MayoresEdad(18, valor);
                case 1:
                    return MayoresEdad(18, valor);
                case 2:
                    return valor.ToString();
                case 3:
                    return valor.ToString();
                case 4:
                    return RecienNacidos(17, valor);
                case 5:
                    return menores(5, valor);
                case 6:
                    return valor.ToString();
                case 7:
                    return valor.ToString();
                case 8:
                    return MenoresEdad(17, valor);
                case 9:
                    return valor.ToString();
                case 10:
                    return intermedios(17, 7, valor);
                default: return valor.ToString();
            }
        }
        private string MayoresEdad(int edad,int valor)
        {
            if (edad > valor)
            {
                return "";
            }
            else
            {
                return valor.ToString();
            }
            
        }
        private string MenoresEdad(int edad, int valor)
        {
            if (edad < valor)
            {
                return "";
            }
            return valor.ToString();
        }
        private string RecienNacidos(int edad, int valor)
        {
            if (edad > valor)
            {
                return "";
            }
            else
            {
                return valor.ToString();
            }
            
        }
        private string menores(int edad,int valor)
        {
            if (edad < valor)
            {
                return "";
            }
            return valor.ToString();
        }
        private string intermedios(int edad1,int edad2,int valor)
        {
            if (valor>edad1 || valor <edad2)
            {
                return "";
            }
            return valor.ToString();
        }

    }
}
