using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HOYSI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Continuar2_Clicked(object sender, EventArgs e)
        {
            var num2 = Convert.ToDouble(Num2.Text);
            var a = 365;
            int resta = Convert.ToInt32(num2) - Convert.ToInt32(a);

            if (resta >= 100 && resta <= 912)
            {
                string mystring = Convert.ToString(resta);
                string dia = mystring.Substring(0, 1);
                string mes = mystring.Substring(1, 2);

                Dia.Text = dia.ToString();
                Mes.Text = mes.ToString();
            }

            if (resta>= 1000 && resta <=9999)
            {
                string mystring = Convert.ToString(resta);
                string dia = mystring.Substring(0, 2);
                string mes = mystring.Substring(2, 2);

                Dia.Text = dia.ToString();
                Mes.Text = mes.ToString();
            }

        }
    }
}