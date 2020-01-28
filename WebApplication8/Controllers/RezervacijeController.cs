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

    public class RezervacijeController : BaseCRUDController<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeInsertRequest, RezervacijeInsertRequest>
    {
        public RezervacijeController(ICRUDService<Rezervacije, RezervacijeSearchRequest, RezervacijeInsertRequest, RezervacijeInsertRequest> service) : base(service)
        {
        }
    }
}