using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btns
{
    public partial class Form1 : Form
    {
        double Valor1, Valor2, Resultado;
        string Operador;
        public Form1()
        {
            InitializeComponent();
        }

        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    lblNumero.Text += "1";
        //}

        //private void btn2_Click(object sender, EventArgs e)
        //{

        //}

        private void MiMetodo_Click(object sender, EventArgs e)
        {
            lblNumero.Text += ((Button)sender).Text;
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            Valor2 = double.Parse(lblNumero.Text);
            lblNumero.Text += ((Button)sender).Text;
          
            switch (Operador)
            {
             
                case "+":
                    if (lblNumero.Text == "")
                    {
                        break;
                    }
                    Resultado = Valor1 + Valor2;
                    lblNumero.Text = Resultado.ToString();
                    break;
                case "-":
                    if (lblNumero.Text == "")
                    {
                        break;
                    }
                    Resultado = Valor1 - Valor2;
                    lblNumero.Text = Resultado.ToString();
                    break;
                case "*":
                    if (lblNumero.Text == "")
                    {
                        break;
                    }
                    Resultado = Valor1 * Valor2;
                    lblNumero.Text = Resultado.ToString();
                    break;
                case "/":
                    if (lblNumero.Text == "")
                    {
                        break;
                    }
                    Resultado = Valor1 / Valor2;
                    lblNumero.Text = Resultado.ToString();
                    break;

            }
        }
       
        private void btnResta_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Valor1 = double.Parse(lblNumero.Text);
            lblNumero.Text = "";
        }

        private void btnMu_Click(object sender, EventArgs e)
        {
            Operador = "*";
            Valor1 = double.Parse(lblNumero.Text);
            lblNumero.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Valor1 = double.Parse(lblNumero.Text);
            lblNumero.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            if(lblNumero.Text.Length  > 1)
                {
                lblNumero.Text = lblNumero.Text.Remove(lblNumero.Text.Length - 1, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operador = "R";
            Valor1 = double.Parse(lblNumero.Text);
            Resultado = Valor1;
            lblNumero.Text = Math.Sqrt(Valor1).ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

           Operador ="+";
            Valor1 = double.Parse(lblNumero.Text);
            lblNumero.Text = "";
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblNumero.Text =null;
            
        }
    }
}
