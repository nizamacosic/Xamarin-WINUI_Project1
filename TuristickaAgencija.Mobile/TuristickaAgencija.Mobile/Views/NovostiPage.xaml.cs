﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Mobile.ViewModels;
using TuristickaAgencija.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristickaAgencija.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovostiPage : ContentPage
    {
        NovostiViewModel model = null;
        public NovostiPage()
        {
            InitializeComponent();
            BindingContext = model=new NovostiViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Novosti;

                await Navigation.PushAsync(new NovostiUrediPage(item));
          
       
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovostiDodajPage());
        }
    }
}