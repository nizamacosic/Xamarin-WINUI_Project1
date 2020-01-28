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
    public class PutovanjaFakultativniController : BaseCRUDController<Model.PutovanjaFakultativni, PutovanjaFakultativniSearchRequest, PutovanjaFakultativniInsertRequest, PutovanjaFakultativniInsertRequest>
    {
        public PutovanjaFakultativniController(ICRUDService<PutovanjaFakultativni, PutovanjaFakultativniSearchRequest, PutovanjaFakultativniInsertRequest, PutovanjaFakultativniInsertRequest> service) : base(service)
        {
        }
    }
}