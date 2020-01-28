using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Services
{
    public class SmjestajService:BaseCRUDService<Model.Smjestaj,SmjestajSearchRequest,Smjestaj,SmjestajInsertRequest,SmjestajInsertRequest>
    {
        public SmjestajService(MyContext db, IMapper mapper) : base(db, mapper)
        {

        }
        public override List<Model.Smjestaj> Get(SmjestajSearchRequest search)
        {
            var query = _db.Set<Smjestaj>().AsQueryable();
            if (search?.GradId.HasValue == true)
            {
                query = query.Where(x => x.GradId == search.GradId);

            }
            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();
            return _mapper.Map<List<Model.Smjestaj>>(list);
        }
    }
}
