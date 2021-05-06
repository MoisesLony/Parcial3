using App1.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
            private async void Login_Clicked(object sender, EventArgs e)
            {
                if (RegexUtilities.IsValidEmail(Email.Text))
                {
                    Error.Text = "Email valido";
                await Navigation.PushAsync(new Home());

            }
                else

                {
                    Error.Text = "Email invalido";
                }

            
                 

            
            }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;
            var entry = sender as Entry;
        if (RegexUtilities.IsValidEmail(email))
            {
                Error.Text = "Email valido";
                entry.BackgroundColor = Color.Aquamarine;
                entry.TextColor = Color.Black;

                
            }
        else
            {
                Error.Text = "Email invalido";
                entry.BackgroundColor = Color.LightCoral;
                entry.TextColor = Color.White;

            }
        }

        private void Contraseña_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }