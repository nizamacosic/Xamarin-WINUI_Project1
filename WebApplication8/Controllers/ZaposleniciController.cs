using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;
using TuristickaAgencija.WebAPI.Services;

namespace TuristickaAgencija.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class ZaposleniciController : ControllerBase
    {

        private readonly IZaposleniciService _service;

        public ZaposleniciController(IZaposleniciService service)

        {
            _service = service;
        }


        [HttpGet]

        public List<Model.Zaposlenici> Get([FromQuery]ZaposleniciSearchRequest request)

        {
            return _service.Get(request);
        }

        [HttpPost]

        public Model.Zaposlenici Insert(ZaposleniciInsertRequest request)

        {
            return _service.Insert(request);
        }



        [HttpPut("{id}")]

        public Model.Zaposlenici Update(int id, [FromBody]ZaposleniciInsertRequest request)

        {
            return _service.Update(id, request);
        }


        [HttpGet("{id}")]

        public Model.Zaposlenici GetById(int id)

        {
            return _service.GetById(id);
        }
    }
}


