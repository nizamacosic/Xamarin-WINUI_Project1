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
    public class TerminiVodiciService : BaseCRUDService<Model.TerminiVodici, TerminiVodiciSearchRequest, Database.TerminiVodici, TerminiVodiciInsertRequest, TerminiVodiciInsertRequest>
    {
        public TerminiVodiciService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.TerminiVodici> Get(TerminiVodiciSearchRequest search)
        {
            var query = _db.Set<Database.TerminiVodici>().AsQueryable();
            if (search?.TerminPutovanjaId.HasValue == true)
            {
                query = query.Where(x => x.TerminPutovanjaId == search.TerminPutovanjaId);

            }
            query = query.OrderBy(x => x.TerminPutovanjaId);
            var list = query.ToList();
            return _mapper.Map<List<Model.TerminiVodici>>(list);
        }
    }
}
