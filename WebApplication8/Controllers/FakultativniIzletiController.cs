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

    public class FakultativniIzletiController : BaseCRUDController<Model.FakultativniIzleti, FakultativniIzletiSearchRequest, FakultativniIzletiInsertRequest, FakultativniIzletiInsertRequest>
    {
        public FakultativniIzletiController(ICRUDService<FakultativniIzleti, FakultativniIzletiSearchRequest, FakultativniIzletiInsertRequest, FakultativniIzletiInsertRequest> service) : base(service)
        {
        }
    }
}