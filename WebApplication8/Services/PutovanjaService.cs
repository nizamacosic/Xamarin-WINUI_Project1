using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Services
{
    public class PutovanjaService:BaseCRUDService<Model.Putovanja,PutovanjaSearchRequest,Putovanja,PutovanjaInsertRequest,PutovanjaInsertRequest>,ICRUDService<Model.Putovanja,PutovanjaSearchRequest,PutovanjaInsertRequest, PutovanjaInsertRequest>
    {

        public PutovanjaService(MyContext db, IMapper mapper):base(db,mapper)
        {
          
        }
        public override List<Model.Putovanja> Get(PutovanjaSearchRequest search)
        {
            var query = _db.Set<Putovanja>().AsQueryable();
            if (search?.VrstaPutovanjaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaPutovanjaId == search.VrstaPutovanjaId);

            }
            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();
            return _mapper.Map<List<Model.Putovanja>>(list);
        }

    }
}
