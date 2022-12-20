using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace calculardora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Operaciones obj = new Operaciones();

        private void text_num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(text_num1.Text) || !obj.IsNumeric(text_num2.Text))
            {
                text_resultados.Text = "Valor Valido";
            }
            else
            {
                int suma = obj.Suma(Convert.ToInt32(text_num1.Text), Convert.ToInt32(text_num2.Text));
                text_resultados.Text = Convert.ToString(suma);
            }
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(text_num1.Text) || !obj.IsNumeric(text_num2.Text))
            {
                text_resultados.Text = "Valor Valido";
            }
            else
            {
                int restar = obj.Restar(Convert.ToInt32(text_num1.Text), Convert.ToInt32(text_num2.Text));
                text_resultados.Text = Convert.ToString(restar);
            }
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(text_num1.Text) || !obj.IsNumeric(text_num2.Text))
            {
                text_resultados.Text = "Valor Valido";
            }
            else
            {
                int multiplicar = obj.Multiplicar(Convert.ToInt32(text_num1.Text), Convert.ToInt32(text_num2.Text));
                text_resultados.Text = Convert.ToString(multiplicar);
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(text_num1.Text) || !obj.IsNumeric(text_num2.Text))
            {
                text_resultados.Text = "Valor Valido";
            }
            else
            {
                int division = obj.Division(Convert.ToInt32(text_num1.Text), Convert.ToInt32(text_num2.Text));
                text_resultados.Text = Convert.ToString(division);
            }
        }

      


        
            
    }
}
