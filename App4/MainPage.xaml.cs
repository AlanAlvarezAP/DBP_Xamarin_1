using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Func_Lenguaje(object sender, EventArgs e)
        {
            if (Op_Lenguaje.SelectedItem?.ToString() == "Otro")
            {
                Lenguaje_Lenguaje.IsVisible = true;
            }
            else
            {
                Lenguaje_Lenguaje.IsVisible = false;
            }
        }

        private void Func_Idiom(object sender, EventArgs e)
        {
            if (Op_Idioma.SelectedItem?.ToString() == "Otro")
            {
                Idiom_Idiom.IsVisible = true;
            }
            else
            {
                Idiom_Idiom.IsVisible = false;
            }
        }

        private void Enviar_Botton(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomNom.Text) || string.IsNullOrWhiteSpace(Edad.Text) || string.IsNullOrWhiteSpace(Ocupa.Text))
            {
                DisplayAlert("Campos Obligatorios", "Por favor complete todos los campos obligatorios.", "OK");
                return;
            }
            var nombre = NomNom.Text;
            var edad = Edad.Text;
            var ocupacion = Ocupa.Text;
            var fechaNacimiento = Nacimiento.Date.ToString("dd/MM/yyyy");
            var lenguajeProgramacion = Op_Lenguaje.SelectedItem?.ToString();
            var otroLenguaje = Lenguaje_Lenguaje.Text;
            var idioma = Op_Idioma.SelectedItem?.ToString();
            var otroIdioma = Idiom_Idiom.Text;


            var mensaje = $"Nombre: {nombre}\n" +
                          $"Edad: {edad}\n" +
                          $"Ocupación: {ocupacion}\n" +
                          $"Fecha de Nacimiento: {fechaNacimiento}\n" +
                          $"Lenguaje de Programación: {(lenguajeProgramacion == "Otro" ? otroLenguaje : lenguajeProgramacion)}\n" +
                          $"Idioma: {(idioma == "Otro" ? otroIdioma : idioma)}";
            MostrarDatos(mensaje);
        }

        private async void MostrarDatos(string mensaje)
        {
            await DisplayAlert("Datos Rellenados", mensaje, "OK");
        }

    }
}
