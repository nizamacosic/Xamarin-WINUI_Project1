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

    public class VodiciController : BaseCRUDController<Model.Vodici, VodicSearchRequest, VodicInsertRequest, VodicInsertRequest>
    {
        public VodiciController(ICRUDService<Vodici, VodicSearchRequest, VodicInsertRequest, VodicInsertRequest> service) : base(service)
        {
        }
    }
}