using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class MyContext : DbContext
    {
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FakultativniIzleti> FakultativniIzleti { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Komentari> Komentari { get; set; }
        public virtual DbSet<Novosti> Novosti { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<OcjenePutovanja> OcjenePutovanja { get; set; }
        public virtual DbSet<Pretplate> Pretplate { get; set; }
        public virtual DbSet<PutniciKorisnici> PutniciKorisnici { get; set; }
        public virtual DbSet<Putovanja> Putovanja { get; set; }
        public virtual DbSet<PutovanjaFakultativni> PutovanjaFakultativni { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<Smjestaj> Smjestaj { get; set; }
        public virtual DbSet<TerminiPutovanja> TerminiPutovanja { get; set; }
        public virtual DbSet<TerminiVodici> TerminiVodici { get; set; }
        public virtual DbSet<Uplate> Uplate { get; set; }
        public virtual DbSet<Vodici> Vodici { get; set; }
        public virtual DbSet<VrstePutovanja> VrstePutovanja { get; set; }
        public virtual DbSet<Zaposlenici> Zaposlenici { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=IB160082;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FakultativniIzleti>(entity =>
            {
                entity.Property(e => e.FakultativniIzletiId)
                    .HasColumnName("FakultativniIzletiID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NazivIzleta).IsRequired();

                entity.Property(e => e.OpisIzleta).IsRequired();

                entity.HasOne(d => d.FakultativniIzletiNavigation)
                    .WithOne(p => p.InverseFakultativniIzletiNavigation)
                    .HasForeignKey<FakultativniIzleti>(d => d.FakultativniIzletiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FakultativniIzleti_FakultativniIzleti");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.FakultativniIzleti)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK_FakultativniIzleti_Gradovi");
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.NazivGrada).IsRequired();

                entity.Property(e => e.PostanskiBroj).HasMaxLength(10);
            });

            modelBuilder.Entity<Komentari>(entity =>
            {
                entity.HasKey(e => e.KomentarId);

                entity.Property(e => e.KomentarId).HasColumnName("KomentarID");

                entity.Property(e => e.PutnikKorisnikId).HasColumnName("PutnikKorisnikID");

                entity.Property(e => e.PutovanjeId).HasColumnName("PutovanjeID");

                entity.Property(e => e.Sadrzaj).HasMaxLength(250);

                entity.Property(e => e.Vrijeme).HasColumnType("date");

                entity.HasOne(d => d.PutnikKorisnik)
                    .WithMany(p => p.Komentari)
                    .HasForeignKey(d => d.PutnikKorisnikId)
                    .HasConstraintName("FK_Komentari_PutniciKorisnici");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.Komentari)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK_Komentari_Putovanja");
            });

            modelBuilder.Entity<Novosti>(entity =>
            {
                entity.HasKey(e => e.NovostId);

                entity.Property(e => e.NovostId).HasColumnName("NovostID");

                entity.Property(e => e.DatumVrijeme).HasColumnType("date");

                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PutovanjeId).HasColumnName("PutovanjeID");

                entity.Property(e => e.Sadrzaj).IsRequired();

                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.Novosti)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK_Novosti_Putovanja");

                entity.HasOne(d => d.VrstaPutovanja)
                    .WithMany(p => p.Novosti)
                    .HasForeignKey(d => d.VrstaPutovanjaId)
                    .HasConstraintName("FK_Novosti_VrstePutovanja");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.Novosti)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .HasConstraintName("FK_Novosti_Zaposlenici");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Vrijednost).HasMaxLength(10);
            });

            modelBuilder.Entity<OcjenePutovanja>(entity =>
            {
                entity.HasKey(e => e.OcjenaPutovanjeId);

                entity.Property(e => e.OcjenaPutovanjeId)
                    .HasColumnName("OcjenaPutovanjeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.PutnikKorisnikId).HasColumnName("PutnikKorisnikID");

                entity.Property(e => e.PutovanjeId).HasColumnName("PutovanjeID");

                entity.HasOne(d => d.Ocjena)
                    .WithMany(p => p.OcjenePutovanja)
                    .HasForeignKey(d => d.OcjenaId)
                    .HasConstraintName("FK_OcjenePutovanja_Ocjene");

                entity.HasOne(d => d.OcjenaPutovanje)
                    .WithOne(p => p.InverseOcjenaPutovanje)
                    .HasForeignKey<OcjenePutovanja>(d => d.OcjenaPutovanjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OcjenePutovanja_OcjenePutovanja");

                entity.HasOne(d => d.PutnikKorisnik)
                    .WithMany(p => p.OcjenePutovanja)
                    .HasForeignKey(d => d.PutnikKorisnikId)
                    .HasConstraintName("FK_OcjenePutovanja_PutniciKorisnici");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.OcjenePutovanja)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK_OcjenePutovanja_Putovanja");
            });

            modelBuilder.Entity<Pretplate>(entity =>
            {
                entity.HasKey(e => e.PretplataId);

                entity.Property(e => e.PretplataId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Pretplata)
                    .WithOne(p => p.InversePretplata)
                    .HasForeignKey<Pretplate>(d => d.PretplataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pretplate_Pretplate");

                entity.HasOne(d => d.PutnikKorisnik)
                    .WithMany(p => p.Pretplate)
                    .HasForeignKey(d => d.PutnikKorisnikId)
                    .HasConstraintName("FK_Pretplate_PutniciKorisnici");

                entity.HasOne(d => d.VrstaPutovanja)
                    .WithMany(p => p.Pretplate)
                    .HasForeignKey(d => d.VrstaPutovanjaId)
                    .HasConstraintName("FK_Pretplate_VrstePutovanja");
            });

            modelBuilder.Entity<PutniciKorisnici>(entity =>
            {
                entity.HasKey(e => e.PutnikKorisnikId);

                entity.Property(e => e.PutnikKorisnikId)
                    .HasColumnName("PutnikKorisnikID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Kontakt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.PutnikKorisnik)
                    .WithOne(p => p.InversePutnikKorisnik)
                    .HasForeignKey<PutniciKorisnici>(d => d.PutnikKorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PutniciKorisnici_PutniciKorisnici");
            });

            modelBuilder.Entity<Putovanja>(entity =>
            {
                entity.Property(e => e.PutovanjaId)
                    .HasColumnName("PutovanjaID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.VrstaPutovanjaId).HasColumnName("VrstaPutovanjaID");

                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Putovanja)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK_Putovanja_Gradovi");

                entity.HasOne(d => d.PutovanjaNavigation)
                    .WithOne(p => p.InversePutovanjaNavigation)
                    .HasForeignKey<Putovanja>(d => d.PutovanjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Putovanja_Putovanja");

                entity.HasOne(d => d.VrstaPutovanja)
                    .WithMany(p => p.Putovanja)
                    .HasForeignKey(d => d.VrstaPutovanjaId)
                    .HasConstraintName("FK_Putovanja_VrstePutovanja");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.Putovanja)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .HasConstraintName("FK_Putovanja_Zaposlenici");
            });

            modelBuilder.Entity<PutovanjaFakultativni>(entity =>
            {
                entity.Property(e => e.PutovanjaFakultativniId).HasColumnName("PutovanjaFakultativniID");

                entity.Property(e => e.FakultativniIzletId).HasColumnName("FakultativniIzletID");

                entity.Property(e => e.PutovanjeId).HasColumnName("PutovanjeID");

                entity.HasOne(d => d.FakultativniIzlet)
                    .WithMany(p => p.PutovanjaFakultativni)
                    .HasForeignKey(d => d.FakultativniIzletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PutovanjaFakultativni_FakultativniIzleti");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.PutovanjaFakultativni)
                    .HasForeignKey(d => d.PutovanjeId);
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId);

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.PutnikKorisnikId).HasColumnName("PutnikKorisnikID");

                entity.Property(e => e.TerminPutovanjaId).HasColumnName("TerminPutovanjaID");

                entity.Property(e => e.Vrijeme).HasColumnType("date");

                entity.HasOne(d => d.PutnikKorisnik)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.PutnikKorisnikId)
                    .HasConstraintName("FK_PutniciKorisniciPutovanja_PutniciKorisnici_PutnikKorisnikID");

                entity.HasOne(d => d.TerminPutovanja)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.TerminPutovanjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_TerminiPutovanja");
            });

            modelBuilder.Entity<Smjestaj>(entity =>
            {
                entity.Property(e => e.SmjestajId).HasColumnName("SmjestajID");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Smjestaj)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Smjestaj_Gradovi");
            });

            modelBuilder.Entity<TerminiPutovanja>(entity =>
            {
                entity.HasKey(e => e.TerminPutovanjaId);

                entity.Property(e => e.TerminPutovanjaId)
                    .HasColumnName("TerminPutovanjaID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatumPolaska).HasColumnType("datetime");

                entity.Property(e => e.DatumPovratka).HasColumnType("datetime");

                entity.Property(e => e.PutovanjeId).HasColumnName("PutovanjeID");

                entity.Property(e => e.SmjestajId).HasColumnName("SmjestajID");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.TerminiPutovanja)
                    .HasForeignKey(d => d.PutovanjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminiPutovanja_Putovanja");

                entity.HasOne(d => d.Smjestaj)
                    .WithMany(p => p.TerminiPutovanja)
                    .HasForeignKey(d => d.SmjestajId)
                    .HasConstraintName("FK_TerminiPutovanja_Smjestaj");

                entity.HasOne(d => d.TerminPutovanja)
                    .WithOne(p => p.InverseTerminPutovanja)
                    .HasForeignKey<TerminiPutovanja>(d => d.TerminPutovanjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminiPutovanja_TerminiPutovanja");
            });

            modelBuilder.Entity<TerminiVodici>(entity =>
            {
                entity.HasKey(e => e.TerminVodiciId);

                entity.Property(e => e.TerminVodiciId).HasColumnName("TerminVodiciID");

                entity.Property(e => e.TerminPutovanjaId).HasColumnName("TerminPutovanjaID");

                entity.Property(e => e.VodicId).HasColumnName("VodicID");

                entity.HasOne(d => d.TerminPutovanja)
                    .WithMany(p => p.TerminiVodici)
                    .HasForeignKey(d => d.TerminPutovanjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminiVodici_TerminiVodici2");

                entity.HasOne(d => d.Vodic)
                    .WithMany(p => p.TerminiVodici)
                    .HasForeignKey(d => d.VodicId)
                    .HasConstraintName("FK_TerminiVodici_Vodici");
            });

            modelBuilder.Entity<Uplate>(entity =>
            {
                entity.HasKey(e => e.UplataId);

                entity.Property(e => e.UplataId)
                    .HasColumnName("UplataID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Uplate)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uplate_Rezervacije");

                entity.HasOne(d => d.Uplata)
                    .WithOne(p => p.InverseUplata)
                    .HasForeignKey<Uplate>(d => d.UplataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uplate_Uplate");
            });

            modelBuilder.Entity<Vodici>(entity =>
            {
                entity.HasKey(e => e.VodicId);

                entity.Property(e => e.VodicId).HasColumnName("VodicID");

                entity.Property(e => e.Jmbg).HasColumnName("JMBG");
            });

            modelBuilder.Entity<VrstePutovanja>(entity =>
            {
                entity.HasKey(e => e.VrstaPutovanjaId);

                entity.Property(e => e.VrstaPutovanjaId).HasColumnName("VrstaPutovanjaID");

                entity.Property(e => e.Oznaka).HasMaxLength(10);
            });

            modelBuilder.Entity<Zaposlenici>(entity =>
            {
                entity.HasKey(e => e.ZaposlenikId);

                entity.Property(e => e.ZaposlenikId)
                    .HasColumnName("ZaposlenikID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Kontakt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Zaposlenik)
                    .WithOne(p => p.InverseZaposlenik)
                    .HasForeignKey<Zaposlenici>(d => d.ZaposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zaposlenici_Zaposlenici");
            });
        }
    }
}
