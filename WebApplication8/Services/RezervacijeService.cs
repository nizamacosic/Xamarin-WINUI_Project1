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
    public class RezervacijeService : BaseCRUDService<Model.Rezervacije, RezervacijeSearchRequest, Database.Rezervacije, RezervacijeInsertRequest, RezervacijeInsertRequest>
    {
        public RezervacijeService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Rezervacije> Get(RezervacijeSearchRequest search)
        {
            var query = _db.Set<Database.Rezervacije>().AsQueryable();
            if (search?.TerminId.HasValue == true)
            {
                query = query.Where(x => x.TerminPutovanjaId == search.TerminId);

            }
            if (search?.PutnikKorisnikId.HasValue == true)
            {
                query = query.Where(x => x.PutnikKorisnikId == search.PutnikKorisnikId);

            }
            query = query.OrderByDescending(x => x.Vrijeme);
            var list = query.ToList();
            return _mapper.Map<List<Model.Rezervacije>>(list);


        }
    }
}
