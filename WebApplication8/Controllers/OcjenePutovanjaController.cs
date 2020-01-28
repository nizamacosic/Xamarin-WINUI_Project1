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
    public class OcjenePutovanjaController : BaseCRUDController<Model.OcjenePutovanja, OcjenePutovanjaSearchRequest, OcjenePutovanjaInsertRequest, OcjenePutovanjaInsertRequest>
    {
        public OcjenePutovanjaController(ICRUDService<OcjenePutovanja, OcjenePutovanjaSearchRequest, OcjenePutovanjaInsertRequest, OcjenePutovanjaInsertRequest> service) : base(service)
        {
        }
    }
}