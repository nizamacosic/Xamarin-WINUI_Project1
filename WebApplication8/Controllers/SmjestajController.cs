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

    public class SmjestajController : BaseCRUDController<Model.Smjestaj, SmjestajSearchRequest, SmjestajInsertRequest, SmjestajInsertRequest>
    {
        public SmjestajController(ICRUDService<Smjestaj, SmjestajSearchRequest, SmjestajInsertRequest, SmjestajInsertRequest> service) : base(service)
        {
        }
    }
}