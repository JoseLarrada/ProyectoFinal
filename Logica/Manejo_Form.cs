using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Logica
{
    public class Manejo_Form
    {
        ErrorProvider Validar = new ErrorProvider();
        public void modificartabla(DataGridView tabla,int posicion,ComboBox text0, TextBox text1, TextBox text2,
                                    TextBox text3, TextBox text4, ComboBox text5)
        {
            tabla[0, posicion].Value = text0.Text;
            tabla[1, posicion].Value = text1.Text;
            tabla[2, posicion].Value = text2.Text;
            tabla[3, posicion].Value = text3.Text;
            tabla[4, posicion].Value = text4.Text;
            tabla[5, posicion].Value = text5.Text;
        }
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
        public void extension(System.Windows.Forms.TextBox h, int valorMaximo, int valorMinimo,Button boton)
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
        public void guardartabla(DataGridView NomT,Pacientes table, ComboBox text0, TextBox text1, TextBox text2,
                                    TextBox text3, TextBox text4, ComboBox text5)
        {
            table.TipoId = text0.Text;
            table.NumeroId = text1.Text;
            table.PrimerNombre = text2.Text;
            table.PrimerApellido = text3.Text;
            table.Edad = text4.Text;
            table.Sexo = text5.Text;
            NomT.Rows.Add(table.TipoId, table.NumeroId, table.PrimerNombre, table.Edad, table.Sexo);
        }


    }
}
