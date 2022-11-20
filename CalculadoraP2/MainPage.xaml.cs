using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace CalculadoraP2
{

    public partial class MainPage : ContentPage
    {
        //<!--OBi Medina -->

        private double Numero1;
        private double Numero2;
        private string Operador;

        public MainPage()
        {
            InitializeComponent();
        }

        private void clicNumero(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = tmp.Text;
            }
            else
            {
                txtResultado.Text += tmp.Text;
            }


        }


        private void clicSuma(object sender, EventArgs e)
        {
            Operador = "+";
            Numero1 = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }
       private void clicIgual(object sender, EventArgs e)
        {

            Numero2 = double.Parse(txtResultado.Text);

            double operacionFinal = 0;

            Numero2 = double.Parse(txtResultado.Text);

            if (Operador == "-")
            {
                operacionFinal = Numero1 - Numero2;

            }

            if (Operador == "+")
            {
                operacionFinal = Numero1 + Numero2;

            }

            if (Operador == "X")
            {
                operacionFinal = Numero1 * Numero2;

            }

            if (Operador == "%")
            {
                operacionFinal = Numero1 *0.5 % Numero2;

            }

            if (Operador == "÷")
            {
                operacionFinal = Numero1 / Numero2;

            }

            txtResultado.Text = operacionFinal.ToString();
        }

        private void clicClearError(object sender, EventArgs e)
        {
            Operador = "CE";
            Numero1 = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicDELETE(object sender, EventArgs e)
        {
            Operador = "DELETE";
            Numero1 = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }


        private void ClicResta(object sender, EventArgs e)
        {
            Operador = "-";
            Numero1 = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicPor(object sender, EventArgs e)
        {
            Operador = "X";
            Numero1 = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clicPct(object sender, EventArgs e)
        {
            Operador = "%";
            Numero1 = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }
        private void clicDividir(object sender, EventArgs e)
        {
            Operador = "÷";
            Numero1 = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }
    }
}
//<!--OBi Medina -->



