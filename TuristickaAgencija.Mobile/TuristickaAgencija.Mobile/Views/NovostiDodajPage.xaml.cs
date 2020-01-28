using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencija.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristickaAgencija.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovostiDodajPage : ContentPage
    {
        NovostiDodajViewModel model = null;
        public NovostiDodajPage()
        {
            InitializeComponent();
            BindingContext = model = new NovostiDodajViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.Dodaj();
            await Navigation.PushAsync(new NovostiPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if(!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("","Format slike nije podrzan!", "OK");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();
            if(file==null)
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