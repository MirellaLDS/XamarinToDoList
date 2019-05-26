using SQLite;
using System;
using System.IO;
using ToDoList.models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList
{
    public partial class App : Application
    {
        private static SQLiteConnection database;

        public static SQLiteConnection DB
        {
            get
            {
                if (database == null)
                {
                    string dbName = "toDoList.db3";
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    database = new SQLiteConnection(Path.Combine(path, dbName));
                    database.CreateTable<TaskModel>();
                }
                return database;
            }
        }

        [Obsolete]
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
