using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
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
                TerminPutovanja = t,
                Slika = t.Slika

            };

        }
        protected async override void OnAppearing()
        {
           base.OnAppearing();
           await  model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.Uredi();
            await Application.Current.MainPage.DisplayAlert("Vaš 'Bon Voyage'!", "Uspjesno ste uredili podatke!", "OK");
            await Navigation.PushAsync(new TerminiPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("", "Format slike nije podržan!", "OK");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
            {
                return;
            }
            Stream stream = file.GetStream();
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                model.Slika = ms.ToArray();
            }
        }
    }
    
}