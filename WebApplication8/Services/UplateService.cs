using TuristickaAgencija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TuristickaAgencija.WebAPI.Database;
using TuristickaAgencija.Model;

namespace TuristickaAgencija.WebAPI.Services
{
    public class UplateService : BaseCRUDService<Model.Uplate, UplateSearchRequest, Database.Uplate, UplateInsertRequest, UplateInsertRequest>
    {
        public UplateService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Uplate> Get(UplateSearchRequest search)
        {
            var query = _db.Set<Database.Uplate>().AsQueryable();
          
            if (search?.RezervacijaId.HasValue == true)
            {
                query = query.Where(x => x.RezervacijaId== search.RezervacijaId);
            }
            query = query.OrderBy(x => x.UplataId);
            var list = query.ToList();
            return _mapper.Map<List<Model.Uplate>>(list);
        }
    }
}
