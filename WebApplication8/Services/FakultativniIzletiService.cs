using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Services
{
    public class FakultativniIzletiService:BaseCRUDService<Model.FakultativniIzleti,FakultativniIzletiSearchRequest,FakultativniIzleti,FakultativniIzletiInsertRequest,FakultativniIzletiInsertRequest>
    {
        public FakultativniIzletiService(MyContext db, IMapper mapper) : base(db, mapper)
        {

        }
        public override List<Model.FakultativniIzleti> Get(FakultativniIzletiSearchRequest search)
        {
            var query = _db.Set<FakultativniIzleti>().AsQueryable();
            if (search.NazivIzleta == null && search.GradId == null)
            {
                return _mapper.Map<List<Model.FakultativniIzleti>>(query.ToList());

            }
            else if (search.GradId.HasValue)
            {
                var izleti = _db.Set<FakultativniIzleti>().AsQueryable();
                if (search?.GradId.HasValue == true)
                {
                    query = query.Where(x => x.GradId == search.GradId);

                }
                query = query.OrderBy(x => x.NazivIzleta);
                var list = query.ToList();
                return _mapper.Map<List<Model.FakultativniIzleti>>(list);
            }
            else
            {

                query = query.Where(x => x.NazivIzleta.ToLower().Contains(search.NazivIzleta.ToLower()));


                query = query.OrderBy(x => x.NazivIzleta);
                var list = query.ToList();
                return _mapper.Map<List<Model.FakultativniIzleti>>(list);
            }
          
        }
    }
}
