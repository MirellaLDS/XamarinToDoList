using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.models;
using Xamarin.Forms;

namespace ToDoList
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        [Obsolete]
        public MainPage()
        {
            InitializeComponent();
            OpenTask.GestureRecognizers.Add(new TapGestureRecognizer((view) => Start_cad_Clicked()));
            CarregarLista();
        }

        private void Start_cad_Clicked()
        {
            Navigation.PushAsync(new cadTask());
        }

        private void CarregarLista()
        {
            var tbTask = App.DB.Table<TaskModel>();
            List<TaskModel> listaResultado = (from task in tbTask
                                              orderby task.Title
                                              select task).ToList();
            listaContatos.ItemsSource = listaResultado;
        }

        private void ListaContatos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as TaskModel;
            Navigation.PushAsync(new ViewDetailTask(item));
        }

        protected void ListItems_Refreshing(object sender, EventArgs e)
        {
            CarregarLista();
            listaContatos.EndRefresh();
        }
    }

}
