using System;
using System.Collections.Generic;
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
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;

        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var Registros = new Usuarios {Nombre = txtNombre.Text, Correo = txtCorreo.Text, Telefono = txtTelefono.Text, Direccion = txtDirección.Text, Usuario = txtUsuario.Text, Contrasenia = txtContrasenia.Text};
                con.InsertAsync(Registros);
                DisplayAlert("Alerta", "Dato ingresado", "OK");
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                txtDirección.Text = "";
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
            }
            catch (Exception ex)
            {

            }
        }
    }
}