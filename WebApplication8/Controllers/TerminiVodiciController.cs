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

    public class TerminiVodiciController : BaseCRUDController<Model.TerminiVodici, TerminiVodiciSearchRequest, TerminiVodiciInsertRequest, TerminiVodiciInsertRequest>
    {
        public TerminiVodiciController(ICRUDService<TerminiVodici, TerminiVodiciSearchRequest, TerminiVodiciInsertRequest, TerminiVodiciInsertRequest> service) : base(service)
        {
        }
    }
}