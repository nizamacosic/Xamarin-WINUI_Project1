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

    public class UplateController : BaseCRUDController<Model.Uplate, UplateSearchRequest, UplateInsertRequest, UplateInsertRequest>
    {
        public UplateController(ICRUDService<Uplate, UplateSearchRequest, UplateInsertRequest, UplateInsertRequest> service) : base(service)
        {
        }
    }
}