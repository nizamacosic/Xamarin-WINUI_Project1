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
    public partial class AktuelneRezervacijePage : ContentPage
    {
        AktuelneRezervacijeViewModel model = null;
        public AktuelneRezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new AktuelneRezervacijeViewModel();
        }
        protected async  override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var entity = e.SelectedItem as Rezervacije;
            model.rezervacijaOtkazi = entity;
            await model.Otkazi();
            await Navigation.PushAsync(new AktuelneRezervacijePage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
           
            await Navigation.PushAsync(new RezervacijePage());
        }

    }
}