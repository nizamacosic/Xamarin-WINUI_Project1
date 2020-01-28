using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Services;
//using TuristickaAgencija.Database;

namespace TuristickaAgencija.WebAPI.Controllers
{


    public class GradoviController:BaseCRUDController<Model.Gradovi,GradoviSearchRequest,GradoviInsertRequest,GradoviInsertRequest>
    {
     public GradoviController(ICRUDService<Model.Gradovi,GradoviSearchRequest,GradoviInsertRequest,GradoviInsertRequest>service):base(service)
     {

     }

      
    }
}
