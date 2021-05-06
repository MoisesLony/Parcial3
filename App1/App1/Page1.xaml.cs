using App1.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }


      

        private void Edad_TextChanged(object sender, TextChangedEventArgs e)
        {
           
           
        }

        private void txtsexo_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            
        }

        private async void F1_Clicked(object sender, EventArgs e)
        {
            String sSexo = txtSexo.Text;

            if ((sSexo == null))
            {
               
                lbl.Text = "Informacion faltante";
            }
            else
            {
                await Navigation.PushAsync(new Formulario2());
                await DisplayAlert("Mensaje", "Datos validos", "OK");
            }
        }
    }
}

