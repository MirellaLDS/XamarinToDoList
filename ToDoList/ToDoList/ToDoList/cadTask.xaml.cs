using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cadTask : ContentPage
    {
        private string data = "";
        public cadTask()
        {
            InitializeComponent();
        }

        private void Cadtask_Clicked(object sender, EventArgs e)
        {
            TaskModel newTask = new TaskModel
            {
                Title = title.Text,
                Description = description.Text,
                EndDate = data
            };

            App.DB.Insert(newTask);
            DisplayAlert("Cadastrar", "Cadastrado com sucesso!", "OK");
            Navigation.PopAsync();
        }

        private void DatePiker_DateSelected(object sender, DateChangedEventArgs e)
        {
            data = e.NewDate.Day + "/" + e.NewDate.Month + "/" + e.NewDate.Year;
            saveInstantState();
        }

        void changeTextoTitle(object sender, TextChangedEventArgs e)
        {
            saveInstantState();

        }

        void changeTextoDescription(object sender, TextChangedEventArgs e)
        {
            saveInstantState();

        }

        void saveInstantState()
        {           
            Application.Current.Properties["Title"] = title.Text;
            Application.Current.Properties["Description"] = description.Text;
            Application.Current.Properties["EndDate"] = data;

            Application.Current.SavePropertiesAsync();

        }

        void limparDados()
        {
            Application.Current.Properties["Title"] = null;
            Application.Current.Properties["Description"] = null;
            Application.Current.Properties["EndDate"] = null;
        }

    }
}