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
    public class PretplateService : BaseCRUDService<Model.Pretplate, PretplateSearchRequest, Database.Pretplate, PretplateInsertRequest, PretplateInsertRequest>
    {
        public PretplateService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Model.Pretplate> Get(PretplateSearchRequest search)
        {

            var query = _db.Set<Database.Pretplate>().AsQueryable();
            if (search?.PutnikKorisnikId.HasValue == true)
            {
                query = query.Where(x => x.PutnikKorisnikId == search.PutnikKorisnikId);

            }
            if (search?.VrstaPutovanjaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaPutovanjaId == search.VrstaPutovanjaId);

            }
            query = query.OrderBy(x => x.PretplataId);
            var list = query.ToList();
            return _mapper.Map<List<Model.Pretplate>>(list);
         
        }
    }
}
