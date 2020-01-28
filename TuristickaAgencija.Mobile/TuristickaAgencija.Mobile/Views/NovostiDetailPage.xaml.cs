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
    public partial class NovostiDetailPage : ContentPage
    {
        NovostiDetailViewModel model;
        public NovostiDetailPage(Novosti n)
        {
            InitializeComponent();
            BindingContext = model = new NovostiDetailViewModel()
            {
                Novost=n
            };
        }
    }
}