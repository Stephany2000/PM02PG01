using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM02PG01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Btnagregar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
         
            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 + num2)));
           
            //await DisplayAlert("SUMA",Convert.ToString(num1+num2),"OK");
        }

        private async void Btnresta_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);

            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 - num2)));

            //await DisplayAlert("SUMA",Convert.ToString(num1+num2),"OK");
        }

        private async void Btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);

            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 * num2)));

            //await DisplayAlert("SUMA",Convert.ToString(num1+num2),"OK");
        }

        private async void Btndivision_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);

            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 / num2)));

            //await DisplayAlert("SUMA",Convert.ToString(num1+num2),"OK");
        }
    }

}
