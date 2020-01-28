using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Services
{
    public class GradoviService : BaseCRUDService<Model.Gradovi, GradoviSearchRequest, Database.Gradovi, GradoviInsertRequest, GradoviInsertRequest>
    {
        public GradoviService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Model.Gradovi> Get(GradoviSearchRequest search)
        {
            var query = _db.Gradovi.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.NazivGrada))
            {
                query = query.Where(x => x.NazivGrada.ToLower().Contains(search.NazivGrada.ToLower()));
            }
           
            var list = query.ToList();
            return _mapper.Map<List<Model.Gradovi>>(list);
        }
    }
}
