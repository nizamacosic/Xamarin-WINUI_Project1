using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Mobile.Models
{
    public enum MenuItemType
    {
        Termini,
        Novosti,
        Rezervacije,
        Uplate,
        MojProfil,
        About,
      
        Odjava

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
