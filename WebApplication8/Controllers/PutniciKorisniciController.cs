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
    public class PutniciKorisniciController : ControllerBase
    {
        private readonly IPutniciKorisniciService _service;

        public PutniciKorisniciController(IPutniciKorisniciService service)
        {
            _service = service;
        }


        [HttpGet]

        public List<Model.PutniciKorisnici> Get([FromQuery]PutniciKorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.PutniciKorisnici Insert(PutniciKorisniciInsertRequest request)

        {
            return _service.Insert(request);
        }



        [HttpPut("{id}")]
        public Model.PutniciKorisnici Update(int id, [FromBody]PutniciKorisniciInsertRequest request)

        {
            return _service.Update(id, request);
        }


        [HttpGet("{id}")]
        public Model.PutniciKorisnici GetById(int id)

        {
            return _service.GetById(id);
        }
    }
}
