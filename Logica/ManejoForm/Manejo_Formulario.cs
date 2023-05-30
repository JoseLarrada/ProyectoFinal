using Entidades;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Logica
{
    public class Manejo_Formulario
    {
        ErrorProvider Validar = new ErrorProvider();
        public void ValidarLetras(KeyPressEventArgs e, System.Windows.Forms.TextBox h)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                Validar.Clear();

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false; Validar.Clear();
            }
            else
            {
                e.Handled = true;
                Validar.SetError(h, "Solo numeros");
            }
        }
        public ErrorProvider validarN(KeyPressEventArgs e, System.Windows.Forms.TextBox h)
        {
            bool error = SoloNumeros(e);
            if (!error)
            {
                Validar.SetError(h, "Solo numeros");
                return null;
            }
            else
            {
                Validar.Clear();
                return null;
            }
        }
        public bool SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false; return true;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false; return true;
            }
            else
            {
                e.Handled = true; return false;
            }
        }
        private void extension(System.Windows.Forms.TextBox h, int valorMaximo, int valorMinimo,Button boton)
        {
            if (h.Text.Length > valorMaximo || h.Text.Length < valorMinimo)
            {
                Validar.SetError(h, "Numero de caracteres superado"); boton.Enabled = false;
            }
            else
            {
                boton.Enabled = true;
            }
        }
        public ErrorProvider validarExtension(ComboBox tipos,KeyPressEventArgs e, System.Windows.Forms.TextBox h,Button Insertar)
        {
            switch (tipos.SelectedIndex)
            {
                case 0:
                    extension(h, 10, 6,Insertar);
                    break;
                case 1:
                    extension(h, 11, 6,Insertar);
                    break;
                case 2:
                    extension(h, 6, 3, Insertar);
                    break;
                case 3:
                    extension(h, 16, 10, Insertar);
                    break;
                case 4:
                    extension(h, 16, 10, Insertar);
                    break;
                case 5:
                    extension(h, 16, 10, Insertar);
                    break;
                case 6:
                    extension(h, 15, 10, Insertar);
                    break;
                case 7:
                    extension(h, 11, 10, Insertar);
                    break;
                case 8:
                    extension(h, 9, 5, Insertar);
                    break;
            }
            return null;
        }
        public int extensioncajadetexto(ComboBox Típos)
        {
            switch (Típos.SelectedIndex)
            {
                case 0:
                    return 10;
                case 1:
                    return 10;
                case 2:
                    return 16;
                case 3:
                    return 6;
                case 4:
                    return 9;
                case 5:
                    return 12;
                case 6:
                    return 16;
                case 7:
                    return 15;
                case 8:
                    return 11;
                case 9:
                    return 16;
                case 10:
                    return 11;
            }
            return 0;
        }
        public string extension(string extension,int final)
        {
            if (extension.Length> final)
            {
                return "";
            }
            return extension;
        }
    }
}
