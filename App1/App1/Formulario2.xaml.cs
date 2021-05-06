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
    public partial class Formulario2 : ContentPage
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private async void F2_Clicked(object sender, EventArgs e)
        {
            String sF2 = txtName.Text;
            String sF3 = txtDUI.Text;


            if ((sF2 == null) && (sF3 ==null))
            {
                lbl.Text = "Informacion faltante";

            }
            else
            {
                await Navigation.PushAsync(new Formulario3());
                await DisplayAlert("Mensaje", "Datos validos", "OK");
            }
        }
    }
}