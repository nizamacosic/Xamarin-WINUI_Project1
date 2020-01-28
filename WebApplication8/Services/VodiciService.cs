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
    public class VodiciService : BaseCRUDService<Model.Vodici, VodicSearchRequest, Database.Vodici, VodicInsertRequest, VodicInsertRequest>
    {
        public VodiciService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Vodici> Get(VodicSearchRequest search)
        {
            var query = _db.Set<Database.Vodici>().AsQueryable();
            if (search?.Zauzet.HasValue == true)
            {
                query = query.Where(x => x.Zauzet == search.Zauzet);

            }
            query = query.OrderBy(x => x.Ime);
            var list = query.ToList();
            return _mapper.Map<List<Model.Vodici>>(list);

        }


    }
}
