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
    public class ObavijestiService : BaseCRUDService<Model.Obavijesti, ObavijestiSearchRequest, Database.Obavijesti, ObavijestiInsertRequest, ObavijestiInsertRequest>
    {
        public ObavijestiService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Obavijesti> Get(ObavijestiSearchRequest search)
        {
            var query = _db.Set<Database.Obavijesti>().AsQueryable();
            if (search.PutnikKorisnikId.HasValue)
            {
                query = query.Where(x => x.IsProcitano == false && x.PutnikKorisnikId==search.PutnikKorisnikId);
            }
            query = query.OrderByDescending(x => x.Vrijeme);
            var list = query.ToList();
            return _mapper.Map<List<Model.Obavijesti>>(list);


        }
    }
}
