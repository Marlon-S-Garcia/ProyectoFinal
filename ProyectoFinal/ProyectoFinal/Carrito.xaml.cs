using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrito : ContentPage
    {

        private const string Url = "http://192.168.0.102/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<ProyectoFinal.Models.Datos> _post;
        private int codigo = 0;
        private int cantidad = 0;
        private string nombreProducto = null;
        private int valor = 0;
        private int valorToatl = 0;

        public Carrito()
        {
            InitializeComponent();
            get();
        }

        public async void get()
        {
            try
            {
                var content = await client.GetStringAsync(Url);
                List<ProyectoFinal.Models.Datos> posts = JsonConvert.DeserializeObject<List<ProyectoFinal.Models.Datos>>(content);
                _post = new ObservableCollection<ProyectoFinal.Models.Datos>(posts);

                MyListView.ItemsSource = _post;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "ERROR" + ex.Message, "OK");
            }
        }

        private async void bntComprar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Compra()); 
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}