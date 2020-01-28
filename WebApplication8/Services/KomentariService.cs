using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Services
{
    public class KomentariService : BaseCRUDService<Model.Komentari, KomentariSearchRequest, Database.Komentari, KomentariInsertRequest, KomentariInsertRequest>
    {
        public KomentariService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Komentari> Get(KomentariSearchRequest search)
        {
            var query = _db.Set<Komentari>().AsQueryable();
            if (search?.PutnikKorisikId.HasValue == true)
            {
                query = query.Where(x => x.PutnikKorisnikId == search.PutnikKorisikId);

            }
            if (search?.PutovanjeId.HasValue == true)
            {
                query = query.Where(x => x.PutovanjeId == search.PutovanjeId);

            }
            query = query.OrderBy(x => x.PutnikKorisnikId);
            var list = query.ToList();
            return _mapper.Map<List<Model.Komentari>>(list);
        }
    }
}
