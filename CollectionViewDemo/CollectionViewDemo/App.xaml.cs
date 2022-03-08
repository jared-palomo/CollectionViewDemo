using CollectionViewDemo.Models;
using CollectionViewDemo.ViewModels;
using CollectionViewDemo.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDemo
{
    public partial class App : Application
    {
        public ObservableCollection<Product> Products { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
