using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija.Mobile.Views
{

    public class MainPagePutnikMasterMenuItem
    {
        public MainPagePutnikMasterMenuItem()
        {
            TargetType = typeof(MainPagePutnikMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}