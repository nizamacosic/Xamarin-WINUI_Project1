using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Services
{
    public class OcjenePutovanjaService : BaseCRUDService<Model.OcjenePutovanja, OcjenePutovanjaSearchRequest, Database.OcjenePutovanja, OcjenePutovanjaInsertRequest, OcjenePutovanjaInsertRequest>
    {
        public OcjenePutovanjaService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.OcjenePutovanja> Get(OcjenePutovanjaSearchRequest search)
        {
            var query = _db.Set<OcjenePutovanja>().AsQueryable();
            if (search?.PutnikKorisnikId.HasValue == true)
            {
                query = query.Where(x => x.PutnikKorisnikId == search.PutnikKorisnikId);
            }
            if (search?.PutovanjeId.HasValue == true)
            {
                query = query.Where(x => x.PutovanjeId == search.PutovanjeId);
            }
            query = query.OrderBy(x => x.PutnikKorisnikId);
            var list = query.ToList();
            return _mapper.Map<List<Model.OcjenePutovanja>>(list);
        }
    }
}
