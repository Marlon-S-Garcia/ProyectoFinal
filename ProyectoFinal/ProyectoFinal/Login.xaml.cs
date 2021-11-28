using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private SQLiteAsyncConnection con;
        public Login()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        public static IEnumerable<Usuarios> SELECT_WHERE(SQLiteConnection db, string usuario, string contrasenia)
        {
            return db.Query<Usuarios>("SELECT * FROM USUARIOS WHERE Usuario = ? and Contrasenia = ?", usuario, contrasenia);
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var documenthPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "proyecto_viv");
                var db = new SQLiteConnection(documenthPath);
                db.CreateTable<Usuarios>();
                IEnumerable<Usuarios> resultado = SELECT_WHERE(db, txtUsuario.Text, txtConstrasenia.Text);
                if (resultado.Count() > 0)
                {
                    await Navigation.PushAsync(new Menu());
                    txtUsuario.Text = "";
                    txtConstrasenia.Text = "";
                }
                else
                {
                    await DisplayAlert("Alerta", "El usuario no existe, debe registrarse", "OK");
                }

            }
            catch (Exception ex)
            {

            }
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}