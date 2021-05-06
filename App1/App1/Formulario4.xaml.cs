using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario_4 : ContentPage
    {
        public Formulario_4()
        {
            InitializeComponent();
        }

        private async void Home_Clicked(object sender, EventArgs e)
        {
            String Shome = txtnombre.Text;

            if ((Shome == null))
            {
                lbl.Text = "Informacion faltante";

            }
            else
            {
                await Navigation.PushAsync(new Home());
                await DisplayAlert("Mensaje", "Formulario completado", "OK");
            }
        }
    }
    }
