using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristickaAgencija.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPagePutnikMaster : ContentPage
    {
        public ListView ListView;

        public MainPagePutnikMaster()
        {
            InitializeComponent();

            BindingContext = new MainPagePutnikMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainPagePutnikMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPagePutnikMasterMenuItem> MenuItems { get; set; }

            public MainPagePutnikMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainPagePutnikMasterMenuItem>(new[]
                {
                    new MainPagePutnikMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MainPagePutnikMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MainPagePutnikMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MainPagePutnikMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MainPagePutnikMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}