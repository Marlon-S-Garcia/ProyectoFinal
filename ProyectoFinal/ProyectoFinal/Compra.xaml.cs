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
    public partial class Compra : ContentPage
    {
        private SQLiteAsyncConnection con;
        private int valo, valto, resul;

        public Compra()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            valo = Convert.ToInt32( txtCantidad.Text);
            valto = Convert.ToInt32( txtValor.Text);

            resul = valo * valto;

            //falta la parte que que se guarde en txtValorTotal ya que se encuentra bloqueado
            
        }
        private void btnAgregar_Clicked(object sender, EventArgs e)
            
        {
            //lo que se quiere hacer aqui es que al momento de guardar se pase los datos a la parte de 
            try
            {
                var Registros = new Compra { };
                con.InsertAsync(Registros);
                DisplayAlert("Alerta", "Dato ingresado", "OK");
                
            }
            catch (Exception ex)
            {

            }

        }
    }
}