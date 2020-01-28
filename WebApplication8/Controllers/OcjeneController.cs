using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TuristickaAgencija.Model;
using TuristickaAgencija.WebAPI.Services;

namespace TuristickaAgencija.WebAPI.Controllers
{
    public class OcjeneController : BaseController<Model.Ocjene, object>
    {
        public OcjeneController(IService<Ocjene, object> service) : base(service)
        {
        }
    }
}