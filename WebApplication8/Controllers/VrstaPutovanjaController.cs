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
    [Route("api/[controller]")]
    [ApiController]
    public class VrstaPutovanjaController : BaseController<VrstaPutovanja,object>
    {

        public VrstaPutovanjaController(IService<VrstaPutovanja,object> service):base(service)
        {

        }
    }
}