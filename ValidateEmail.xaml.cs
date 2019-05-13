using Behaviors.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Behaviors
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ValidateEmail : ContentPage
	{
		public ValidateEmail ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (EmailBehavior.OK == true)
            {
                this.texto.Text = "El email es válido";
            }
            else
            {
                this.texto.Text = "El email no es válido";
            }
        }
    }
}