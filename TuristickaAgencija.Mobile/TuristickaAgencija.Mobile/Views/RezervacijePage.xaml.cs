using System;
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
    public partial class RezervacijePage : ContentPage
    {
        RezervacijeViewModel model = null;
        public RezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //model.SveRezervacijePutnik = true;
            await model.Init();
            //model.SveRezervacijePutnik = false;
        }
    }
}