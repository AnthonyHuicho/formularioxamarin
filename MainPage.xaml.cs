using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string age = AgeEntry.Text;
            string address = AddressEntry.Text;
            string phone = PhoneEntry.Text;
            string career = CareerEntry.Text;
            string educationLevel = EducationLevelPicker.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name)  ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(age) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(career) || string.IsNullOrWhiteSpace(educationLevel))
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            ResultLabel.Text = $"Nombre: {name} \n" +
                               $"Correo: {email}\n" +
                               $"Edad: {age}\n" +
                               $"Dirección: {address}\n" +
                               $"Teléfono: {phone}\n" +
                               $"Carrera: {career}\n" +
                               $"Nivel de Estudios: {educationLevel}";
        }
    }
}

