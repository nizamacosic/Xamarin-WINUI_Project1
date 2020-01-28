using System;
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
    public partial class TerminiUrediPage : ContentPage
    {
        TerminDetailViewModel model = null;
        public TerminiUrediPage(TerminiPutovanja t)
        {
            InitializeComponent();
            BindingContext = model = new TerminDetailViewModel()
            {
                TerminPutovanja = t
            };

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
           await  model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await model.Uredi();
            await Application.Current.MainPage.DisplayAlert("Vaš 'Bon Voyage'!", "Uspjesno ste uredili podatke!", "OK");
            await Navigation.PushAsync(new TerminiPage());
        }
    }
    
}