using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Services;

namespace TuristickaAgencija.WebAPI.Controllers
{

    public class KomentariController : BaseCRUDController<Model.Komentari, KomentariSearchRequest, KomentariInsertRequest, KomentariInsertRequest>
    {
        public KomentariController(ICRUDService<Komentari, KomentariSearchRequest, KomentariInsertRequest, KomentariInsertRequest> service) : base(service)
        {
        }
    }
}