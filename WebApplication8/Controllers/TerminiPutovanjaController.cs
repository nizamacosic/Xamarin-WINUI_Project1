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

    public class TerminiPutovanjaController : BaseCRUDController<Model.TerminiPutovanja, TerminiSearchRequest, TerminiPutovanjaInsertRequest, TerminiPutovanjaInsertRequest>
    {
        public TerminiPutovanjaController(ICRUDService<TerminiPutovanja, TerminiSearchRequest, TerminiPutovanjaInsertRequest, TerminiPutovanjaInsertRequest> service) : base(service)
        {
        }
    }
}