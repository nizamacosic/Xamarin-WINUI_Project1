using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.WebAPI.Services
{
    public interface ILoginService
    {
        Model.KorisnikLogin AutentificirajPutnika(string username, string pass);
        Model.KorisnikLogin Autentificiraj(string username, string pass);
    }
}
