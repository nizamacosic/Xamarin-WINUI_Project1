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
    public class TerminiPutovanjaService : BaseCRUDService<Model.TerminiPutovanja, TerminiSearchRequest, Database.TerminiPutovanja, TerminiPutovanjaInsertRequest, TerminiPutovanjaInsertRequest>
    {
        public TerminiPutovanjaService(MyContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Model.TerminiPutovanja> Get(TerminiSearchRequest search)
        {
            var query = _db.Set<Database.TerminiPutovanja>().AsQueryable();



            if (search?.PutovanjeId.HasValue == true && search?.Godina.HasValue == true)
            {
                query = query.Where(x => x.PutovanjeId == search.PutovanjeId).
                         Where(x => x.DatumPolaska.Year == search.Godina);
            }
            else
            {

                if (search?.PutovanjeId.HasValue == true)
                {
                    query = query.Where(x => x.PutovanjeId == search.PutovanjeId);
                }

                if (search?.Godina.HasValue == true)
                {
                    query = query.Where(x => x.DatumPolaska.Year == search.Godina);
                }
                if (search?.Aktivno.HasValue==true)
                { 
                    query = query.Where(x => x.Aktivno == search.Aktivno);
                }

            }
            query = query.OrderBy(x => x.TerminPutovanjaId);
            var list = query.ToList();
            return _mapper.Map<List<Model.TerminiPutovanja>>(list);

        }
    }
}
