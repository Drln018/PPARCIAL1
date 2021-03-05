using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HOYSI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Anum_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void Afecha_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        void Exit_Clicked(object sender, EventArgs e)
        {
            
        }

    }
}
