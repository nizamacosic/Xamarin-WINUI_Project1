using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.WebAPI.Services
{
    public interface IPutniciKorisniciService
    {
        List<Model.PutniciKorisnici> Get(PutniciKorisniciSearchRequest request);


        Model.PutniciKorisnici GetById(int id);


        Model.PutniciKorisnici Insert(PutniciKorisniciInsertRequest request);


        Model.PutniciKorisnici Update(int id, PutniciKorisniciInsertRequest request);


        Model.PutniciKorisnici AutentificirajPutnika(string username, string pass);
    }
}
