﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristickaAgencija.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminRezervacijePage : ContentPage
    {
        AdminRezervacijeViewModel model = null;
        public AdminRezervacijePage()
        {
            InitializeComponent();

            BindingContext = model = new AdminRezervacijeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (model.TerminSelected != null)
            {
                await model.Init();
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
           await model.Init();
        }
    }
}