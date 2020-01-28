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
    public class PutovanjaController : BaseCRUDController<Model.Putovanja, PutovanjaSearchRequest,PutovanjaInsertRequest,PutovanjaInsertRequest>
    {
        public PutovanjaController(ICRUDService<Putovanja, PutovanjaSearchRequest,PutovanjaInsertRequest,PutovanjaInsertRequest> service) : base(service)
        {
        }
    }
}