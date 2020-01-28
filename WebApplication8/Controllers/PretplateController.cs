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
    public class PretplateController : BaseCRUDController<Pretplate, PretplateSearchRequest, PretplateInsertRequest, PretplateInsertRequest>
    {
        public PretplateController(ICRUDService<Pretplate, PretplateSearchRequest, PretplateInsertRequest, PretplateInsertRequest> service) : base(service)
        {
        }
    }
}