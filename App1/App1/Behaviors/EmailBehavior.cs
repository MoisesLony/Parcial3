using App1.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.Behaviors
{
    public class EmailBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += Bindable_TextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;
            var entry = sender as Entry;
            if (RegexUtilities.IsValidEmail(email))
            {
                
                entry.BackgroundColor = Color.Aquamarine;
                entry.TextColor = Color.Black;


            }
            else
            {
               
                entry.BackgroundColor = Color.LightCoral;
                entry.TextColor = Color.White;

            }
        }
    }
}
