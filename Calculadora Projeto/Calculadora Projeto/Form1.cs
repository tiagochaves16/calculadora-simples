using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1;
        double valor2;
        string operador;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (mostra.Text == "")
            {
                mostra.Text = "1";
            }
            else
            {
                mostra.Text = mostra.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "2";
            }
            else
            {
                mostra.Text = mostra.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "3";
            }
            else
            {
                mostra.Text = mostra.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "4";
            }
            else
            {
                mostra.Text = mostra.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "5";
            }
            else
            {
                mostra.Text = mostra.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "6";
            }
            else
            {
                mostra.Text = mostra.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "7";
            }
            else
            {
                mostra.Text = mostra.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "8";
            }
            else
            {
                mostra.Text = mostra.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "9";
            }
            else
            {
                mostra.Text = mostra.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (mostra.Text == "")
            {
                mostra.Text = "0";
            }
            else
            {
                mostra.Text = mostra.Text + "0";
            }
        }

        private void btnlimpa_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            this.mostra.Text = "";
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(this.mostra.Text);
            operador = "/";
            this.mostra.Clear();
            this.mostra.Focus();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {

            valor1 = Convert.ToDouble(this.mostra.Text);
            operador = "*";
            this.mostra.Clear();
            this.mostra.Focus();
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {

            valor1 = Convert.ToDouble(this.mostra.Text);
            operador = "-";
            this.mostra.Clear();
            this.mostra.Focus();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {

            valor1 = Convert.ToDouble(this.mostra.Text);
            operador = "+";
            this.mostra.Clear();
            this.mostra.Focus();
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            this.mostra.Text = this.mostra.Text = ".";
        }

        private void btnresul_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(this.mostra.Text);
            switch (operador)
            {
                case "+":
                    this.mostra.Text = Convert.ToString(valor1 + valor2);
                    break;

                case "-":
                    this.mostra.Text = Convert.ToString(valor1 - valor2);
                    break;

                case "*":
                    this.mostra.Text = Convert.ToString(valor1 * valor2);
                    break;

                case "/":
                    this.mostra.Text = Convert.ToString(valor1 / valor2);
                    break;

            }
        }

        private void mostra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar!='.')
            {
                e.Handled = true;
            }
            if (e.KeyChar =='.' && mostra.Text.IndexOf('.')>-1)
            {
                e.Handled = true;
            }

        }

    }
}
