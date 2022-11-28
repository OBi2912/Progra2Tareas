using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Unit_Converter
{
    //OBi Medina//
    public partial class MainPage : ContentPage
    {
        Calculo calculo = new Calculo();
        public MainPage()
        {
            InitializeComponent();
            string[] arrCombo = new string[11] {"Kilómetro","Metro","Centímetro","Milímetro","Micrómetro","Nanómetro",
                                               "Milla","Yarda","Pie","Pulgada","Milla náutica"};
            foreach (var item in arrCombo)
            {
                PIC_ComboDe.Items.Add(item);
                PIC_ComboA.Items.Add(item);
            }
            PIC_ComboDe.SelectedIndex = 0;
            PIC_ComboA.SelectedIndex = 2;
        }

        private void EDT_De_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EDT_De.Text == "")
            {
                EDT_A.Text = "0";
            }
            else
            {
                EDT_A.Text = calculo.calculoMedida(PIC_ComboDe.SelectedIndex, PIC_ComboA.SelectedIndex, double.Parse(EDT_De.Text));
            }
        }

        private void PIC_Combos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EDT_De.Text == "")
            {
                EDT_A.Text = "0";
            }
            else
            {
                EDT_A.Text = calculo.calculoMedida(PIC_ComboDe.SelectedIndex, PIC_ComboA.SelectedIndex, double.Parse(EDT_De.Text));
            }
        }
    }
}
