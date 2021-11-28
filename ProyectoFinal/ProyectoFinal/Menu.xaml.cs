using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void btnCarrito_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carrito());
        }

        private async void btnCompra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Compra());
        }

        private async void btnAnteriores_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComprasAnteriores());
        }
    }
}