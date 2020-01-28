using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Services
{
    public class PutovanjaFakultativniService : BaseCRUDService<Model.PutovanjaFakultativni, PutovanjaFakultativniSearchRequest,Database.PutovanjaFakultativni, PutovanjaFakultativniInsertRequest, PutovanjaFakultativniInsertRequest>
    {
        public PutovanjaFakultativniService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.PutovanjaFakultativni> Get(PutovanjaFakultativniSearchRequest search)
        {
            var query = _db.Set<PutovanjaFakultativni>().AsQueryable();
            if (search?.PutovanjeId.HasValue == true)
            {
                query = query.Where(x => x.PutovanjeId == search.PutovanjeId);

            }
            query = query.OrderBy(x => x.PutovanjeId);
            var list = query.ToList();
            return _mapper.Map<List<Model.PutovanjaFakultativni>>(list);
        }
    }
}
