using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Services
{
    public class NovostiService : BaseCRUDService<Model.Novosti, NovostiSearchRequest, Database.Novosti, NovostiInsertRequest, NovostiInsertRequest>
    {
        public NovostiService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Model.Novosti> Get(NovostiSearchRequest search)
        {
            var query = _db.Set<Database.Novosti>().AsQueryable();

            if (search?.PutovanjeId.HasValue == true)
            {
                query = query.Where(x => x.PutovanjeId== search.PutovanjeId);

            }
            query = query.OrderByDescending(x => x.NovostId);
            var list = query.ToList();
            return _mapper.Map<List<Model.Novosti>>(list);
        }
    }
}
