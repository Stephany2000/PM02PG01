using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02PG01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingPage : ContentPage
    {
        public BindingPage()
        {
            InitializeComponent();
        }

        private async void btnbinding_Clicked(object sender, EventArgs e)
        {
            var personas = new Models.Personas
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Edad= Convert.ToInt32(txtedad.Text),
                Correo= txtcorreo.Text
            };

            var secondpage = new Views.ResultPage();
            secondpage.BindingContext = personas;
            await Navigation.PushAsync(secondpage);
        }
    }
}