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
    public partial class Formulario3 : ContentPage
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private async void F3_Clicked(object sender, EventArgs e)
        {
            String sF3 = txtsangre.Text;

            if ((sF3 == null))
            {
                lbl.Text = "Informacion faltante";

            }
            else
            {
                await Navigation.PushAsync(new Formulario_4());
                await DisplayAlert("Mensaje", "Datos validos", "OK");
            }
        }
    }
    }