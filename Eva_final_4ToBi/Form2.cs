using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eva_final_4ToBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int producto = Num1 * Num2;
            MessageBox.Show("el resultado del producto es"+ producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int suma = Num1 + Num2;
            MessageBox.Show("el resultado de la suma es:" + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int resultado = 1;
            for (int i = 1; i < Num2; i++)
            {
                resultado *= Num1;
            }
            MessageBox.Show("El resultado es:" + resultado);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextVar1.Text);
            float Num2 = float.Parse(TextVar2.Text);
            if (Num2 < 0)
            {
                float division = Num1 / Num2;
                MessageBox.Show("el resultado es" + division);
            }
            else
            {
                MessageBox.Show("La definicion es indefinida");
            }
        }
    }
}   