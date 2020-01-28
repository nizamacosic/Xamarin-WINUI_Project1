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
    public partial class TerminiPage : ContentPage
    {
        TerminiViewModel model = null;
        
        public TerminiPage()
        {
            InitializeComponent();
            BindingContext = model=new TerminiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            
            await model.Init();

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as TerminiPutovanja;

            //provjeri da li je zaposlenik 
            bool z = false;
            APIService _service = new APIService("Zaposlenici");
            List<Zaposlenici> zaposlenici = await _service.Get<List<Zaposlenici>>(null);
            foreach (var i in zaposlenici)
            {
                if (i.KorisnickoIme == APIService.KorisnickoIme)
                {
                    z = true;
                }
            }
            if (z == true)
            { 
                await Navigation.PushAsync(new TerminiUrediPage(item)); 
            }
            else
            {
                await Navigation.PushAsync(new TerminiDetailPage(item));

            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            await model.Init();
        }
    }
}