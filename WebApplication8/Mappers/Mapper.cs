using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;

namespace TuristickaAgencija.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Gradovi, GradoviInsertRequest>().ReverseMap();
            CreateMap<Gradovi, Model.Gradovi>().ReverseMap();

            CreateMap<Putovanja, PutovanjaInsertRequest>().ReverseMap();
            CreateMap<Putovanja, Model.Putovanja>().ReverseMap();
            CreateMap<Putovanja, Model.Putovanja>()
                     .ForMember(s => s.Grad, a =>
                     a.MapFrom(b => new MyContext().Gradovi.Find(b.GradId).NazivGrada)).ForMember
                     (s=>s.VrstaPutovanja,a=> a.MapFrom(y=> new MyContext().VrstePutovanja.
                     Find(y.VrstaPutovanjaId).Oznaka)).ReverseMap();

      

            CreateMap<FakultativniIzleti, Model.Requests.FakultativniIzletiInsertRequest>().ReverseMap();
            CreateMap<FakultativniIzleti, Model.FakultativniIzleti>().ReverseMap();
            CreateMap<FakultativniIzleti, Model.FakultativniIzleti>().ForMember(x => x.Grad,
               a => a.MapFrom(
               y => new MyContext().Gradovi.Find(y.GradId).NazivGrada)).ReverseMap();



            CreateMap<Smjestaj, Model.Smjestaj>().ReverseMap();
            CreateMap<Smjestaj, Model.Requests.SmjestajInsertRequest>().ReverseMap();
            CreateMap<Smjestaj, Model.Smjestaj>().ForMember(x => x.Grad,
              a => a.MapFrom(
              y => new MyContext().Gradovi.Find(y.GradId).NazivGrada)).ReverseMap();


            CreateMap<Vodici, Model.Requests.VodicInsertRequest>().ReverseMap();
            CreateMap<Vodici, Model.Vodici>().ReverseMap();

            CreateMap<TerminiVodici, Model.Requests.TerminiVodiciInsertRequest>().ReverseMap();
            CreateMap<TerminiVodici, Model.TerminiVodici>().ReverseMap();


            CreateMap<Novosti, Model.Novosti>().ReverseMap();
            CreateMap<Novosti,NovostiInsertRequest>().ReverseMap();
            CreateMap<Novosti, Model.Novosti>().ForMember(x => x.Putovanje
              , a => a.MapFrom(
             y => new MyContext().Putovanja.Find(y.PutovanjeId).Naziv)).ForMember(x=>x.Zaposlenik,
             a=>a.MapFrom(y=>new MyContext().Zaposlenici.Find(y.ZaposlenikId).KorisnickoIme))
            .ReverseMap();

            CreateMap<Zaposlenici, Model.Zaposlenici>().ReverseMap();
            CreateMap<Zaposlenici, ZaposleniciInsertRequest>().ReverseMap();

            CreateMap<TerminiPutovanja,TerminiPutovanjaInsertRequest>().ReverseMap();
            CreateMap<TerminiPutovanja,Model.TerminiPutovanja>().ReverseMap();
            CreateMap<TerminiPutovanja, Model.TerminiPutovanja>().ForMember(x => x.TerminPutovanjaPodaci
            , a => a.MapFrom(
            y => new MyContext().Putovanja.Find(y.PutovanjeId).Naziv + " | " + y.DatumPolaska.ToString())
            ).ForMember(x => x.Smjestaj, a => a.MapFrom(y => new MyContext().Smjestaj.Find(y.SmjestajId).Naziv)).ReverseMap();
          




            CreateMap<PutovanjaFakultativni, PutovanjaFakultativniInsertRequest>().ReverseMap();
            CreateMap<PutovanjaFakultativni, Model.PutovanjaFakultativni>().ReverseMap();


            
            CreateMap<Rezervacije,Model.Rezervacije>().ReverseMap();
            CreateMap<Rezervacije,RezervacijeInsertRequest>().ReverseMap();
            CreateMap<Rezervacije, Model.Rezervacije>().ForMember(x => x.PutnikKorisnikPodaci
                 , a => a.MapFrom(
                 y => new MyContext().PutniciKorisnici.
                 Find(y.PutnikKorisnikId).KorisnickoIme)).
                 ForMember(x=>x.TerminPutovanjaPodaci,a=>a.MapFrom(k=>new MyContext().
                 TerminiPutovanja.Where(x=>x.TerminPutovanjaId==k.TerminPutovanjaId).
                 FirstOrDefault().
                 DatumPolaska.ToString()
                 )).ForMember(x=>x.PutovanjePodaci,a=>a.MapFrom(k=> new MyContext().
                 TerminiPutovanja.
                 Where(x=>x.TerminPutovanjaId==k.TerminPutovanjaId).Include(x=>x.Putovanje).FirstOrDefault().
                 TerminPutovanja.Putovanje.Naziv)).ReverseMap();



            CreateMap<PutniciKorisnici, PutniciKorisniciInsertRequest>().ReverseMap();
            CreateMap<PutniciKorisnici, Model.PutniciKorisnici>().ReverseMap();
         


            CreateMap<Uplate, UplateInsertRequest>().ReverseMap();
            CreateMap<Uplate, Model.Uplate>().ReverseMap();
            CreateMap<Uplate, Model.Uplate>().
            ForMember(x => x.PutnikKorisnikPodaci,
            a => a.MapFrom(y => new MyContext().Rezervacije.
            Where(x => x.RezervacijaId == y.RezervacijaId).
            Include(x => x.PutnikKorisnik).FirstOrDefault().
            PutnikKorisnik.KorisnickoIme)).
            ForMember(x=>x.TerminPutovanjaPodaci,
            a=>a.MapFrom(y=>new MyContext().Rezervacije.
            Where(x=>x.RezervacijaId==y.RezervacijaId).Include(x=>x.TerminPutovanja).
            FirstOrDefault().TerminPutovanja.DatumPolaska.ToString())).
            ForMember(x=>x.PutovanjePodaci,a=>a.MapFrom(
                y=> new MyContext().Rezervacije.
                Where(x=>x.RezervacijaId==y.RezervacijaId).
                Include(x=>x.TerminPutovanja).Include(x=>x.TerminPutovanja.Putovanje).
                FirstOrDefault().TerminPutovanja.Putovanje.Naziv
                )).ReverseMap();



            CreateMap<Database.Zaposlenici, Model.KorisnikLogin>().ReverseMap();
            CreateMap<Database.PutniciKorisnici, Model.KorisnikLogin>().ReverseMap();


            CreateMap<OcjenePutovanja, OcjenePutovanjaInsertRequest>().ReverseMap();
            CreateMap<OcjenePutovanja, Model.OcjenePutovanja>().ReverseMap();
            CreateMap<OcjenePutovanja, Model.OcjenePutovanja>().ForMember
             (x => x.PutnikKorisnik, a => a.MapFrom(y => new MyContext().PutniciKorisnici.Find(y.PutnikKorisnikId).KorisnickoIme)).
             ForMember(x => x.Putovanje, a => a.MapFrom(y => new MyContext().Putovanja.Find(y.PutovanjeId).Naziv)
             ).ForMember(x=>x.OcjenaVrijednost,a=>a.MapFrom(y=>new MyContext().Ocjene.Find(y.OcjenaId).Vrijednost
             ))
            .ReverseMap();


            CreateMap<Komentari, KomentariInsertRequest>().ReverseMap();
            CreateMap<Komentari, Model.Komentari>().ReverseMap();
            CreateMap<Komentari, Model.Komentari>().
                ForMember(x=>x.Putovanje,a=>a.MapFrom(y=> new MyContext().Putovanja.Find(y.PutovanjeId).Naziv)
                ).ForMember(x=>x.PutnikKorisnik,a=>a.MapFrom(y=> new MyContext().PutniciKorisnici.Find(y.PutnikKorisnikId).KorisnickoIme))
                .ReverseMap();


            CreateMap<Pretplate, Model.Pretplate>().ReverseMap();
            CreateMap<Pretplate, PretplateInsertRequest>().ReverseMap();
            CreateMap<Pretplate, Model.Pretplate>().ForMember(x => x.PutnikKorisnik,
                a => a.MapFrom(y => new MyContext().PutniciKorisnici.Find(y.PutnikKorisnikId).KorisnickoIme)).ForMember
                (x => x.VrstaPutovanja, a => a.MapFrom(y => new MyContext().VrstePutovanja.Find(y.VrstaPutovanjaId).Oznaka)).ReverseMap();

            CreateMap<Obavijesti, Model.Obavijesti>().ReverseMap();
            CreateMap<Obavijesti,ObavijestiInsertRequest>().ReverseMap();

            CreateMap<VrstePutovanja, Model.VrstaPutovanja>().ReverseMap();
            CreateMap<VrstePutovanja, VrstaPutovanjaInsertRequest>().ReverseMap();


        }
    }
}
