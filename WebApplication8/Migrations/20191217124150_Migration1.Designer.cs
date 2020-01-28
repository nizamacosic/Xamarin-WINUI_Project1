﻿//// <auto-generated />
//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
////using TuristickaAgencija.WebAPI.Database;

//namespace TuristickaAgencija.WebAPI.Migrations
//{
//    [DbContext(typeof(MyContext))]
//    [Migration("20191217124150_Migration1")]
//    partial class Migration1
//    {
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128)
//                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.FakultativniIzleti", b =>
//                {
//                    b.Property<int>("FakultativniIzletiId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("FakultativniIzletiID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<string>("NazivIzleta")
//                        .IsRequired();

//                    b.Property<string>("OpisIzleta")
//                        .IsRequired();

//                    b.HasKey("FakultativniIzletiId");

//                    b.ToTable("FakultativniIzleti");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.FakultativniIzletiPutnici", b =>
//                {
//                    b.Property<int>("FakultativniIzletiPutniciId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("FakultativniIzletiPutniciID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int>("FakultativniId")
//                        .HasColumnName("FakultativniID");

//                    b.Property<int>("PutnikKorisnikId")
//                        .HasColumnName("PutnikKorisnikID");

//                    b.HasKey("FakultativniIzletiPutniciId");

//                    b.HasIndex("FakultativniId");

//                    b.HasIndex("PutnikKorisnikId");

//                    b.ToTable("FakultativniIzletiPutnici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Gradovi", b =>
//                {
//                    b.Property<int>("GradId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("GradID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<string>("NazivGrada")
//                        .IsRequired();

//                    b.Property<string>("PostanskiBroj")
//                        .HasMaxLength(10);

//                    b.HasKey("GradId");

//                    b.ToTable("Gradovi");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Komentari", b =>
//                {
//                    b.Property<int>("KomentarId")
//                        .HasColumnName("KomentarID");

//                    b.Property<string>("Naslov")
//                        .HasMaxLength(50);

//                    b.Property<int?>("PutnikKorisnikId")
//                        .HasColumnName("PutnikKorisnikID");

//                    b.Property<int?>("PutovanjeId")
//                        .HasColumnName("PutovanjeID");

//                    b.Property<string>("Sadrzaj")
//                        .HasMaxLength(250);

//                    b.Property<DateTime?>("Vrijeme")
//                        .HasColumnType("date");

//                    b.HasKey("KomentarId");

//                    b.HasIndex("PutnikKorisnikId");

//                    b.HasIndex("PutovanjeId");

//                    b.ToTable("Komentari");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Korisnici", b =>
//                {
//                    b.Property<int>("KorisnikId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("KorisnikID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<DateTime>("DatumRodjenja");

//                    b.Property<string>("Email")
//                        .HasMaxLength(50);

//                    b.Property<int>("GradId")
//                        .HasColumnName("GradID");

//                    b.Property<string>("Ime");

//                    b.Property<string>("Jmbg")
//                        .HasColumnName("JMBG");

//                    b.Property<string>("Kontakt");

//                    b.Property<string>("Prezime");

//                    b.HasKey("KorisnikId");

//                    b.HasIndex("GradId");

//                    b.ToTable("Korisnici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.KorisnickiNalozi", b =>
//                {
//                    b.Property<int>("KorisnickiNalogId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("KorisnickiNalogID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<string>("KorisnickoIme");

//                    b.Property<string>("Lozinka");

//                    b.HasKey("KorisnickiNalogId");

//                    b.ToTable("KorisnickiNalozi");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Novosti", b =>
//                {
//                    b.Property<int>("NovostId")
//                        .HasColumnName("NovostID");

//                    b.Property<DateTime>("DatumVrijeme")
//                        .HasColumnType("date");

//                    b.Property<string>("Naslov")
//                        .IsRequired()
//                        .HasMaxLength(50);

//                    b.Property<int?>("PutovanjeId")
//                        .HasColumnName("PutovanjeID");

//                    b.Property<string>("Sadrzaj")
//                        .IsRequired();

//                    b.Property<int?>("ZaposlenikId")
//                        .HasColumnName("ZaposlenikID");

//                    b.HasKey("NovostId");

//                    b.HasIndex("ZaposlenikId");

//                    b.ToTable("Novosti");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Ocjene", b =>
//                {
//                    b.Property<int>("OcjenaId")
//                        .HasColumnName("OcjenaID");

//                    b.Property<string>("Vrijednost")
//                        .HasMaxLength(10);

//                    b.Property<int>("VrijednostBrojcano");

//                    b.HasKey("OcjenaId");

//                    b.ToTable("Ocjene");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.OcjenePutovanja", b =>
//                {
//                    b.Property<int>("OcjenaPutovanjeId")
//                        .HasColumnName("OcjenaPutovanjeID");

//                    b.Property<int?>("OcjenaId")
//                        .HasColumnName("OcjenaID");

//                    b.Property<int?>("PutnikKorisnikId")
//                        .HasColumnName("PutnikKorisnikID");

//                    b.Property<int?>("PutovanjeId")
//                        .HasColumnName("PutovanjeID");

//                    b.HasKey("OcjenaPutovanjeId");

//                    b.HasIndex("OcjenaId");

//                    b.HasIndex("PutnikKorisnikId");

//                    b.HasIndex("PutovanjeId");

//                    b.ToTable("OcjenePutovanja");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Prevoz", b =>
//                {
//                    b.Property<int>("PrevozId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("PrevozID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<string>("NazivPrevoza");

//                    b.HasKey("PrevozId");

//                    b.ToTable("Prevoz");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.PutniciKorisnici", b =>
//                {
//                    b.Property<int>("PutnikKorisnikId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("PutnikKorisnikID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int?>("KorisnickiNalogId")
//                        .HasColumnName("KorisnickiNalogID");

//                    b.Property<int>("KorisnikId")
//                        .HasColumnName("KorisnikID");

//                    b.HasKey("PutnikKorisnikId");

//                    b.HasIndex("KorisnickiNalogId");

//                    b.HasIndex("KorisnikId");

//                    b.ToTable("PutniciKorisnici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Putovanja", b =>
//                {
//                    b.Property<int>("PutovanjaId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("PutovanjaID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<float>("Cijena");

//                    b.Property<string>("Naziv");

//                    b.Property<string>("Opis");

//                    b.Property<int?>("SmjestajId")
//                        .HasColumnName("SmjestajID");

//                    b.Property<int?>("VrstaPutovanjaId")
//                        .HasColumnName("VrstaPutovanjaID");

//                    b.Property<int?>("ZaposlenikId")
//                        .HasColumnName("ZaposlenikID");

//                    b.HasKey("PutovanjaId");

//                    b.HasIndex("SmjestajId");

//                    b.HasIndex("VrstaPutovanjaId");

//                    b.HasIndex("ZaposlenikId");

//                    b.ToTable("Putovanja");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.PutovanjaFakultativni", b =>
//                {
//                    b.Property<int>("PutovanjaFakultativniId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("PutovanjaFakultativniID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int>("FakultativniIzletId")
//                        .HasColumnName("FakultativniIzletID");

//                    b.Property<int>("PutovanjeId")
//                        .HasColumnName("PutovanjeID");

//                    b.HasKey("PutovanjaFakultativniId");

//                    b.HasIndex("FakultativniIzletId");

//                    b.HasIndex("PutovanjeId");

//                    b.ToTable("PutovanjaFakultativni");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.PutovanjaGradovi", b =>
//                {
//                    b.Property<int>("PutovanjaGradoviId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("PutovanjaGradoviID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int>("GradId")
//                        .HasColumnName("GradID");

//                    b.Property<int>("PutovanjeId")
//                        .HasColumnName("PutovanjeID");

//                    b.HasKey("PutovanjaGradoviId");

//                    b.HasIndex("GradId");

//                    b.HasIndex("PutovanjeId");

//                    b.ToTable("PutovanjaGradovi");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Rezervacije", b =>
//                {
//                    b.Property<int>("RezervacijaId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("RezervacijaID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int>("PutnikKorisnikId")
//                        .HasColumnName("PutnikKorisnikID");

//                    b.Property<int>("TerminPutovanjaId")
//                        .HasColumnName("TerminPutovanjaID");

//                    b.Property<DateTime>("Vrijeme")
//                        .HasColumnType("date");

//                    b.HasKey("RezervacijaId");

//                    b.HasIndex("PutnikKorisnikId");

//                    b.HasIndex("TerminPutovanjaId");

//                    b.ToTable("Rezervacije");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Smjestaj", b =>
//                {
//                    b.Property<int>("SmjestajId")
//                        .HasColumnName("SmjestajID");

//                    b.Property<double?>("CijenaNoc");

//                    b.Property<int>("GradId")
//                        .HasColumnName("GradID");

//                    b.Property<string>("Naziv")
//                        .IsRequired()
//                        .HasMaxLength(50);

//                    b.HasKey("SmjestajId");

//                    b.HasIndex("GradId");

//                    b.ToTable("Smjestaj");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.TerminiPutovanja", b =>
//                {
//                    b.Property<int>("TerminPutovanjaId")
//                        .HasColumnName("TerminPutovanjaID");

//                    b.Property<bool?>("Aktivno");

//                    b.Property<int?>("BrojMjesta");

//                    b.Property<DateTime?>("DatumPolaska")
//                        .HasColumnType("datetime");

//                    b.Property<DateTime?>("DatumPovratka")
//                        .HasColumnType("datetime");

//                    b.Property<int>("PutovanjeId")
//                        .HasColumnName("PutovanjeID");

//                    b.HasKey("TerminPutovanjaId");

//                    b.HasIndex("PutovanjeId");

//                    b.ToTable("TerminiPutovanja");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.TerminiVodici", b =>
//                {
//                    b.Property<int>("TerminVodiciId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("TerminVodiciID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int>("PutovanjeId")
//                        .HasColumnName("PutovanjeID");

//                    b.Property<int>("TerminPutovanjaId")
//                        .HasColumnName("TerminPutovanjaID");

//                    b.HasKey("TerminVodiciId");

//                    b.HasIndex("PutovanjeId");

//                    b.HasIndex("TerminPutovanjaId");

//                    b.ToTable("TerminiVodici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Uplate", b =>
//                {
//                    b.Property<int>("UplataId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("UplataID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<DateTime>("DatumUplate");

//                    b.Property<float>("Iznos");

//                    b.Property<int?>("PutnikKorisnikId")
//                        .HasColumnName("PutnikKorisnikID");

//                    b.Property<int>("RezervacijaId")
//                        .HasColumnName("RezervacijaID");

//                    b.HasKey("UplataId");

//                    b.HasIndex("PutnikKorisnikId");

//                    b.HasIndex("RezervacijaId");

//                    b.ToTable("Uplate");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Vodici", b =>
//                {
//                    b.Property<int>("VodicId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("VodicID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<string>("Ime");

//                    b.Property<string>("Jmbg")
//                        .HasColumnName("JMBG");

//                    b.Property<string>("Kontakt");

//                    b.Property<string>("Prezime");

//                    b.Property<bool?>("Zauzet");

//                    b.HasKey("VodicId");

//                    b.ToTable("Vodici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.VrstePutovanja", b =>
//                {
//                    b.Property<int>("VrstaPutovanjaId")
//                        .HasColumnName("VrstaPutovanjaID");

//                    b.Property<string>("Oznaka")
//                        .HasMaxLength(10);

//                    b.Property<int?>("Vrijednost");

//                    b.HasKey("VrstaPutovanjaId");

//                    b.ToTable("VrstePutovanja");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Zaposlenici", b =>
//                {
//                    b.Property<int>("ZaposlenikId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("ZaposlenikID")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int?>("KorisnickiNalogId")
//                        .HasColumnName("KorisnickiNalogID");

//                    b.Property<int>("KorisnikId")
//                        .HasColumnName("KorisnikID");

//                    b.Property<string>("StrucnaSprema");

//                    b.HasKey("ZaposlenikId");

//                    b.HasIndex("KorisnickiNalogId");

//                    b.HasIndex("KorisnikId");

//                    b.ToTable("Zaposlenici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.FakultativniIzletiPutnici", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.FakultativniIzleti", "Fakultativni")
//                        .WithMany("FakultativniIzletiPutnici")
//                        .HasForeignKey("FakultativniId")
//                        .OnDelete(DeleteBehavior.Cascade);

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.PutniciKorisnici", "PutnikKorisnik")
//                        .WithMany("FakultativniIzletiPutnici")
//                        .HasForeignKey("PutnikKorisnikId")
//                        .OnDelete(DeleteBehavior.Cascade);
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Komentari", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.PutniciKorisnici", "PutnikKorisnik")
//                        .WithMany("Komentari")
//                        .HasForeignKey("PutnikKorisnikId")
//                        .HasConstraintName("FK_Komentari_PutniciKorisnici");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Putovanja", "Putovanje")
//                        .WithMany("Komentari")
//                        .HasForeignKey("PutovanjeId")
//                        .HasConstraintName("FK_Komentari_Putovanja");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Korisnici", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Gradovi", "Grad")
//                        .WithMany("Korisnici")
//                        .HasForeignKey("GradId")
//                        .OnDelete(DeleteBehavior.Cascade);
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Novosti", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Zaposlenici", "Zaposlenik")
//                        .WithMany("Novosti")
//                        .HasForeignKey("ZaposlenikId")
//                        .HasConstraintName("FK_Novosti_Zaposlenici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.OcjenePutovanja", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Ocjene", "Ocjena")
//                        .WithMany("OcjenePutovanja")
//                        .HasForeignKey("OcjenaId")
//                        .HasConstraintName("FK_OcjenePutovanja_Ocjene");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.OcjenePutovanja", "OcjenaPutovanje")
//                        .WithOne("InverseOcjenaPutovanje")
//                        .HasForeignKey("TuristickaAgencija.WebAPI.Database.OcjenePutovanja", "OcjenaPutovanjeId")
//                        .HasConstraintName("FK_OcjenePutovanja_OcjenePutovanja");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.PutniciKorisnici", "PutnikKorisnik")
//                        .WithMany("OcjenePutovanja")
//                        .HasForeignKey("PutnikKorisnikId")
//                        .HasConstraintName("FK_OcjenePutovanja_PutniciKorisnici");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Putovanja", "Putovanje")
//                        .WithMany("OcjenePutovanja")
//                        .HasForeignKey("PutovanjeId")
//                        .HasConstraintName("FK_OcjenePutovanja_Putovanja");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.PutniciKorisnici", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.KorisnickiNalozi", "KorisnickiNalog")
//                        .WithMany("PutniciKorisnici")
//                        .HasForeignKey("KorisnickiNalogId")
//                        .HasConstraintName("FK_PutniciKorisnici_KorisnickiNalozi");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Korisnici", "Korisnik")
//                        .WithMany("PutniciKorisnici")
//                        .HasForeignKey("KorisnikId")
//                        .OnDelete(DeleteBehavior.Cascade);
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Putovanja", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Smjestaj", "Smjestaj")
//                        .WithMany("Putovanja")
//                        .HasForeignKey("SmjestajId")
//                        .HasConstraintName("FK_Putovanja_Smjestaj");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.VrstePutovanja", "VrstaPutovanja")
//                        .WithMany("Putovanja")
//                        .HasForeignKey("VrstaPutovanjaId")
//                        .HasConstraintName("FK_Putovanja_VrstePutovanja");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Zaposlenici", "Zaposlenik")
//                        .WithMany("Putovanja")
//                        .HasForeignKey("ZaposlenikId")
//                        .HasConstraintName("FK_Putovanja_Zaposlenici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.PutovanjaFakultativni", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.FakultativniIzleti", "FakultativniIzlet")
//                        .WithMany("PutovanjaFakultativni")
//                        .HasForeignKey("FakultativniIzletId")
//                        .HasConstraintName("FK_PutovanjaFakultativni_FakultativniIzleti");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Putovanja", "Putovanje")
//                        .WithMany("PutovanjaFakultativni")
//                        .HasForeignKey("PutovanjeId")
//                        .OnDelete(DeleteBehavior.Cascade);
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.PutovanjaGradovi", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Gradovi", "Grad")
//                        .WithMany("PutovanjaGradovi")
//                        .HasForeignKey("GradId");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Putovanja", "Putovanje")
//                        .WithMany("PutovanjaGradovi")
//                        .HasForeignKey("PutovanjeId");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Rezervacije", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.PutniciKorisnici", "PutnikKorisnik")
//                        .WithMany("Rezervacije")
//                        .HasForeignKey("PutnikKorisnikId")
//                        .HasConstraintName("FK_PutniciKorisniciPutovanja_PutniciKorisnici_PutnikKorisnikID")
//                        .OnDelete(DeleteBehavior.Cascade);

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Rezervacije", "Rezervacija")
//                        .WithOne("InverseRezervacija")
//                        .HasForeignKey("TuristickaAgencija.WebAPI.Database.Rezervacije", "RezervacijaId")
//                        .HasConstraintName("FK_Rezervacije_Rezervacije");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.TerminiPutovanja", "TerminPutovanja")
//                        .WithMany("Rezervacije")
//                        .HasForeignKey("TerminPutovanjaId")
//                        .HasConstraintName("FK_Rezervacije_TerminiPutovanja");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Smjestaj", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Gradovi", "Grad")
//                        .WithMany("Smjestaj")
//                        .HasForeignKey("GradId")
//                        .HasConstraintName("FK_Smjestaj_Gradovi");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.TerminiPutovanja", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Putovanja", "Putovanje")
//                        .WithMany("TerminiPutovanja")
//                        .HasForeignKey("PutovanjeId")
//                        .HasConstraintName("FK_TerminiPutovanja_Putovanja");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.TerminiPutovanja", "TerminPutovanja")
//                        .WithOne("InverseTerminPutovanja")
//                        .HasForeignKey("TuristickaAgencija.WebAPI.Database.TerminiPutovanja", "TerminPutovanjaId")
//                        .HasConstraintName("FK_TerminiPutovanja_TerminiPutovanja");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.TerminiVodici", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Putovanja", "Putovanje")
//                        .WithMany("TerminiVodici")
//                        .HasForeignKey("PutovanjeId")
//                        .HasConstraintName("FK_PutovanjaVodici_Putovanja_PutovanjeID")
//                        .OnDelete(DeleteBehavior.Cascade);

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.TerminiPutovanja", "TerminPutovanja")
//                        .WithMany("TerminiVodici")
//                        .HasForeignKey("TerminPutovanjaId")
//                        .HasConstraintName("FK_TerminiVodici_TerminiPutovanja");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.TerminiVodici", "TerminVodici")
//                        .WithOne("InverseTerminVodici")
//                        .HasForeignKey("TuristickaAgencija.WebAPI.Database.TerminiVodici", "TerminVodiciId")
//                        .HasConstraintName("FK_TerminiVodici_TerminiVodici");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Uplate", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.PutniciKorisnici", "PutnikKorisnik")
//                        .WithMany("Uplate")
//                        .HasForeignKey("PutnikKorisnikId")
//                        .HasConstraintName("FK_Uplate_PutniciKorisnici");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Rezervacije", "Rezervacija")
//                        .WithMany("Uplate")
//                        .HasForeignKey("RezervacijaId")
//                        .HasConstraintName("FK_Uplate_Rezervacije");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Uplate", "Uplata")
//                        .WithOne("InverseUplata")
//                        .HasForeignKey("TuristickaAgencija.WebAPI.Database.Uplate", "UplataId")
//                        .HasConstraintName("FK_Uplate_Uplate");
//                });

//            modelBuilder.Entity("TuristickaAgencija.WebAPI.Database.Zaposlenici", b =>
//                {
//                    b.HasOne("TuristickaAgencija.WebAPI.Database.KorisnickiNalozi", "KorisnickiNalog")
//                        .WithMany("Zaposlenici")
//                        .HasForeignKey("KorisnickiNalogId")
//                        .HasConstraintName("FK_Zaposlenici_KorisnickiNalozi");

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Korisnici", "Korisnik")
//                        .WithMany("Zaposlenici")
//                        .HasForeignKey("KorisnikId")
//                        .OnDelete(DeleteBehavior.Cascade);

//                    b.HasOne("TuristickaAgencija.WebAPI.Database.Zaposlenici", "Zaposlenik")
//                        .WithOne("InverseZaposlenik")
//                        .HasForeignKey("TuristickaAgencija.WebAPI.Database.Zaposlenici", "ZaposlenikId")
//                        .HasConstraintName("FK_Zaposlenici_Zaposlenici");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}
