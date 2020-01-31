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
    [Route("api/[controller]")]
    [ApiController]
    public class VrstaPutovanjaController : BaseCRUDController<Model.VrstaPutovanja, object, VrstaPutovanjaInsertRequest, VrstaPutovanjaInsertRequest>
    {
        public VrstaPutovanjaController(ICRUDService<VrstaPutovanja, object, VrstaPutovanjaInsertRequest, VrstaPutovanjaInsertRequest> service) : base(service)
        {
        }
    }
}

