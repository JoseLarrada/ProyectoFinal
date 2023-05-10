using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Manejo_Form_Consulta
    {
        public void guardartabla(DataGridView NomT, Consultas table, TextBox text0, TextBox text1, TextBox text2,
                                    TextBox text3, TextBox text4, TextBox text5)
        {
            table.NumeroAutorizacion = text0.Text;
            table.NumeroIdentificacion = text1.Text;
            table.NumeroFactura = text2.Text;
            table.ValorConsulta = double.Parse(text3.Text);
            table.ValorCuoMod = double.Parse(text4.Text);
            table.ValorNetoPagar = double.Parse(text5.Text);
            NomT.Rows.Add(table.NumeroAutorizacion, table.NumeroIdentificacion, table.NumeroFactura, table.ValorConsulta, table.ValorCuoMod, table.ValorNetoPagar);
        }
        public void modificartabla(DataGridView tabla, int posicion, TextBox text0, TextBox text1, TextBox text2,
                                    TextBox text3, TextBox text4, TextBox text5)
        {
            tabla[0, posicion].Value = text0.Text;
            tabla[1, posicion].Value = text1.Text;
            tabla[2, posicion].Value = text2.Text;
            tabla[3, posicion].Value = text3.Text;
            tabla[4, posicion].Value = text4.Text;
            tabla[5, posicion].Value = text5.Text;
        }

    }
}
