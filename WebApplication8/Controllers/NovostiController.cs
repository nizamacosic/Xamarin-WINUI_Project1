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

    public class NovostiController : BaseCRUDController<Model.Novosti, NovostiSearchRequest, NovostiInsertRequest, NovostiInsertRequest>
    {
        public NovostiController(ICRUDService<Novosti, NovostiSearchRequest, NovostiInsertRequest, NovostiInsertRequest> service) : base(service)
        {
        }
    }
}