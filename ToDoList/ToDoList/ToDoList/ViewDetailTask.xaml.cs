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
    public partial class ViewDetailTask : ContentPage
    {
        public ViewDetailTask(TaskModel task)
        {
            InitializeComponent();
            Title.Text = task.Title;
            Description.Text = task.Description;
            Date.Text = task.EndDate;
        }
    }
}