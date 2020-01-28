using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.WebAPI.Services
{
    public interface IZaposleniciService
    {
        List<Model.Zaposlenici> Get(ZaposleniciSearchRequest request);


        Model.Zaposlenici GetById(int id);


        Model.Zaposlenici Insert(ZaposleniciInsertRequest request);


        Model.Zaposlenici Update(int id, ZaposleniciInsertRequest request);


        Model.Zaposlenici Authenticiraj(string username, string pass);

    }
}
