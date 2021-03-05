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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void  Continuar_Clicked(object sender, EventArgs e)
        {
            var num = Convert.ToDouble(Num.Text);
            var n = 4;
            if (num > 0 && num <= 99)
            {
                string mystring = Convert.ToString(num);
                string parte = mystring.Substring(0, 1);
                int resul = Convert.ToInt32(parte) - Convert.ToInt32(n);
                Resultado.Text = resul.ToString();
            }

            if (num >= 100 && num <= 999)
            {
                string mystring = Convert.ToString(num);
                string parte = mystring.Substring(0, 2);
                int resul = Convert.ToInt32(parte) - Convert.ToInt32(n);
                Resultado.Text = resul.ToString();
            }

        }
    }
}