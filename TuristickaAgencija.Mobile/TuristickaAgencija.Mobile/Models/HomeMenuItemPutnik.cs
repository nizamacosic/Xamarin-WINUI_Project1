using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Mobile.Models
{
    public enum MenuItemTypeP
    {
        Pocetna,
        Termini,
        Novosti,
        Rezervacije,
        Uplate,
        OcjeneKomentari,
        Preplate,
        MojProfil,
        Obavijesti,
        About,

    }
    public class HomeMenuItemPutnik
    {
        public MenuItemTypeP Id { get; set; }

        public string Title { get; set; }
    }
}
