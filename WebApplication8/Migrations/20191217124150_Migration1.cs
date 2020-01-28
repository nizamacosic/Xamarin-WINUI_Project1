using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuristickaAgencija.WebAPI.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FakultativniIzleti",
                columns: table => new
                {
                    FakultativniIzletiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivIzleta = table.Column<string>(nullable: false),
                    OpisIzleta = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FakultativniIzleti", x => x.FakultativniIzletiID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivGrada = table.Column<string>(nullable: false),
                    PostanskiBroj = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickiNalozi",
                columns: table => new
                {
                    KorisnickiNalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Lozinka = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalozi", x => x.KorisnickiNalogID);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false),
                    VrijednostBrojcano = table.Column<int>(nullable: false),
                    Vrijednost = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaID);
                });

            migrationBuilder.CreateTable(
                name: "Prevoz",
                columns: table => new
                {
                    PrevozID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivPrevoza = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prevoz", x => x.PrevozID);
                });

            migrationBuilder.CreateTable(
                name: "Vodici",
                columns: table => new
                {
                    VodicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Kontakt = table.Column<string>(nullable: true),
                    JMBG = table.Column<string>(nullable: true),
                    Zauzet = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vodici", x => x.VodicID);
                });

            migrationBuilder.CreateTable(
                name: "VrstePutovanja",
                columns: table => new
                {
                    VrstaPutovanjaID = table.Column<int>(nullable: false),
                    Oznaka = table.Column<string>(maxLength: 10, nullable: true),
                    Vrijednost = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstePutovanja", x => x.VrstaPutovanjaID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Kontakt = table.Column<string>(nullable: true),
                    JMBG = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnici_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Smjestaj",
                columns: table => new
                {
                    SmjestajID = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    CijenaNoc = table.Column<double>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smjestaj", x => x.SmjestajID);
                    table.ForeignKey(
                        name: "FK_Smjestaj_Gradovi",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PutniciKorisnici",
                columns: table => new
                {
                    PutnikKorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: false),
                    KorisnickiNalogID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PutniciKorisnici", x => x.PutnikKorisnikID);
                    table.ForeignKey(
                        name: "FK_PutniciKorisnici_KorisnickiNalozi",
                        column: x => x.KorisnickiNalogID,
                        principalTable: "KorisnickiNalozi",
                        principalColumn: "KorisnickiNalogID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PutniciKorisnici_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenici",
                columns: table => new
                {
                    ZaposlenikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StrucnaSprema = table.Column<string>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: false),
                    KorisnickiNalogID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenici", x => x.ZaposlenikID);
                    table.ForeignKey(
                        name: "FK_Zaposlenici_KorisnickiNalozi",
                        column: x => x.KorisnickiNalogID,
                        principalTable: "KorisnickiNalozi",
                        principalColumn: "KorisnickiNalogID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zaposlenici_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FakultativniIzletiPutnici",
                columns: table => new
                {
                    FakultativniIzletiPutniciID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FakultativniID = table.Column<int>(nullable: false),
                    PutnikKorisnikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FakultativniIzletiPutnici", x => x.FakultativniIzletiPutniciID);
                    table.ForeignKey(
                        name: "FK_FakultativniIzletiPutnici_FakultativniIzleti_FakultativniID",
                        column: x => x.FakultativniID,
                        principalTable: "FakultativniIzleti",
                        principalColumn: "FakultativniIzletiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FakultativniIzletiPutnici_PutniciKorisnici_PutnikKorisnikID",
                        column: x => x.PutnikKorisnikID,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Novosti",
                columns: table => new
                {
                    NovostID = table.Column<int>(nullable: false),
                    Naslov = table.Column<string>(maxLength: 50, nullable: false),
                    DatumVrijeme = table.Column<DateTime>(type: "date", nullable: false),
                    Sadrzaj = table.Column<string>(nullable: false),
                    PutovanjeID = table.Column<int>(nullable: true),
                    ZaposlenikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novosti", x => x.NovostID);
                    table.ForeignKey(
                        name: "FK_Novosti_Zaposlenici",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenici",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Putovanja",
                columns: table => new
                {
                    PutovanjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Cijena = table.Column<float>(nullable: false),
                    SmjestajID = table.Column<int>(nullable: true),
                    VrstaPutovanjaID = table.Column<int>(nullable: true),
                    ZaposlenikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Putovanja", x => x.PutovanjaID);
                    table.ForeignKey(
                        name: "FK_Putovanja_Smjestaj",
                        column: x => x.SmjestajID,
                        principalTable: "Smjestaj",
                        principalColumn: "SmjestajID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Putovanja_VrstePutovanja",
                        column: x => x.VrstaPutovanjaID,
                        principalTable: "VrstePutovanja",
                        principalColumn: "VrstaPutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Putovanja_Zaposlenici",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenici",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentari",
                columns: table => new
                {
                    KomentarID = table.Column<int>(nullable: false),
                    Naslov = table.Column<string>(maxLength: 50, nullable: true),
                    Vrijeme = table.Column<DateTime>(type: "date", nullable: true),
                    Sadrzaj = table.Column<string>(maxLength: 250, nullable: true),
                    PutnikKorisnikID = table.Column<int>(nullable: true),
                    PutovanjeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.KomentarID);
                    table.ForeignKey(
                        name: "FK_Komentari_PutniciKorisnici",
                        column: x => x.PutnikKorisnikID,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komentari_Putovanja",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OcjenePutovanja",
                columns: table => new
                {
                    OcjenaPutovanjeID = table.Column<int>(nullable: false),
                    PutovanjeID = table.Column<int>(nullable: true),
                    OcjenaID = table.Column<int>(nullable: true),
                    PutnikKorisnikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcjenePutovanja", x => x.OcjenaPutovanjeID);
                    table.ForeignKey(
                        name: "FK_OcjenePutovanja_Ocjene",
                        column: x => x.OcjenaID,
                        principalTable: "Ocjene",
                        principalColumn: "OcjenaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OcjenePutovanja_PutniciKorisnici",
                        column: x => x.PutnikKorisnikID,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OcjenePutovanja_Putovanja",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PutovanjaFakultativni",
                columns: table => new
                {
                    PutovanjaFakultativniID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PutovanjeID = table.Column<int>(nullable: false),
                    FakultativniIzletID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PutovanjaFakultativni", x => x.PutovanjaFakultativniID);
                    table.ForeignKey(
                        name: "FK_PutovanjaFakultativni_FakultativniIzleti",
                        column: x => x.FakultativniIzletID,
                        principalTable: "FakultativniIzleti",
                        principalColumn: "FakultativniIzletiID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PutovanjaFakultativni_Putovanja_PutovanjeID",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PutovanjaGradovi",
                columns: table => new
                {
                    PutovanjaGradoviID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PutovanjeID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PutovanjaGradovi", x => x.PutovanjaGradoviID);
                    table.ForeignKey(
                        name: "FK_PutovanjaGradovi_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PutovanjaGradovi_Putovanja_PutovanjeID",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TerminiPutovanja",
                columns: table => new
                {
                    TerminPutovanjaID = table.Column<int>(nullable: false),
                    DatumPolaska = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumPovratka = table.Column<DateTime>(type: "datetime", nullable: true),
                    BrojMjesta = table.Column<int>(nullable: true),
                    Aktivno = table.Column<bool>(nullable: true),
                    PutovanjeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminiPutovanja", x => x.TerminPutovanjaID);
                    table.ForeignKey(
                        name: "FK_TerminiPutovanja_Putovanja",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PutnikKorisnikID = table.Column<int>(nullable: false),
                    Vrijeme = table.Column<DateTime>(type: "date", nullable: false),
                    TerminPutovanjaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK_PutniciKorisniciPutovanja_PutniciKorisnici_PutnikKorisnikID",
                        column: x => x.PutnikKorisnikID,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_TerminiPutovanja",
                        column: x => x.TerminPutovanjaID,
                        principalTable: "TerminiPutovanja",
                        principalColumn: "TerminPutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TerminiVodici",
                columns: table => new
                {
                    TerminVodiciID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PutovanjeID = table.Column<int>(nullable: false),
                    TerminPutovanjaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminiVodici", x => x.TerminVodiciID);
                    table.ForeignKey(
                        name: "FK_PutovanjaVodici_Putovanja_PutovanjeID",
                        column: x => x.PutovanjeID,
                        principalTable: "Putovanja",
                        principalColumn: "PutovanjaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TerminiVodici_TerminiPutovanja",
                        column: x => x.TerminPutovanjaID,
                        principalTable: "TerminiPutovanja",
                        principalColumn: "TerminPutovanjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    UplataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Iznos = table.Column<float>(nullable: false),
                    DatumUplate = table.Column<DateTime>(nullable: false),
                    RezervacijaID = table.Column<int>(nullable: false),
                    PutnikKorisnikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.UplataID);
                    table.ForeignKey(
                        name: "FK_Uplate_PutniciKorisnici",
                        column: x => x.PutnikKorisnikID,
                        principalTable: "PutniciKorisnici",
                        principalColumn: "PutnikKorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uplate_Rezervacije",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FakultativniIzletiPutnici_FakultativniID",
                table: "FakultativniIzletiPutnici",
                column: "FakultativniID");

            migrationBuilder.CreateIndex(
                name: "IX_FakultativniIzletiPutnici_PutnikKorisnikID",
                table: "FakultativniIzletiPutnici",
                column: "PutnikKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_PutnikKorisnikID",
                table: "Komentari",
                column: "PutnikKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_PutovanjeID",
                table: "Komentari",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_GradID",
                table: "Korisnici",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_ZaposlenikID",
                table: "Novosti",
                column: "ZaposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenePutovanja_OcjenaID",
                table: "OcjenePutovanja",
                column: "OcjenaID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenePutovanja_PutnikKorisnikID",
                table: "OcjenePutovanja",
                column: "PutnikKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenePutovanja_PutovanjeID",
                table: "OcjenePutovanja",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_PutniciKorisnici_KorisnickiNalogID",
                table: "PutniciKorisnici",
                column: "KorisnickiNalogID");

            migrationBuilder.CreateIndex(
                name: "IX_PutniciKorisnici_KorisnikID",
                table: "PutniciKorisnici",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanja_SmjestajID",
                table: "Putovanja",
                column: "SmjestajID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanja_VrstaPutovanjaID",
                table: "Putovanja",
                column: "VrstaPutovanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanja_ZaposlenikID",
                table: "Putovanja",
                column: "ZaposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_PutovanjaFakultativni_FakultativniIzletID",
                table: "PutovanjaFakultativni",
                column: "FakultativniIzletID");

            migrationBuilder.CreateIndex(
                name: "IX_PutovanjaFakultativni_PutovanjeID",
                table: "PutovanjaFakultativni",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_PutovanjaGradovi_GradID",
                table: "PutovanjaGradovi",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_PutovanjaGradovi_PutovanjeID",
                table: "PutovanjaGradovi",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_PutnikKorisnikID",
                table: "Rezervacije",
                column: "PutnikKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_TerminPutovanjaID",
                table: "Rezervacije",
                column: "TerminPutovanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Smjestaj_GradID",
                table: "Smjestaj",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_TerminiPutovanja_PutovanjeID",
                table: "TerminiPutovanja",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_TerminiVodici_PutovanjeID",
                table: "TerminiVodici",
                column: "PutovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_TerminiVodici_TerminPutovanjaID",
                table: "TerminiVodici",
                column: "TerminPutovanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_PutnikKorisnikID",
                table: "Uplate",
                column: "PutnikKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_RezervacijaID",
                table: "Uplate",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenici_KorisnickiNalogID",
                table: "Zaposlenici",
                column: "KorisnickiNalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenici_KorisnikID",
                table: "Zaposlenici",
                column: "KorisnikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FakultativniIzletiPutnici");

            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.DropTable(
                name: "Novosti");

            migrationBuilder.DropTable(
                name: "OcjenePutovanja");

            migrationBuilder.DropTable(
                name: "Prevoz");

            migrationBuilder.DropTable(
                name: "PutovanjaFakultativni");

            migrationBuilder.DropTable(
                name: "PutovanjaGradovi");

            migrationBuilder.DropTable(
                name: "TerminiVodici");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.DropTable(
                name: "Vodici");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "FakultativniIzleti");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "PutniciKorisnici");

            migrationBuilder.DropTable(
                name: "TerminiPutovanja");

            migrationBuilder.DropTable(
                name: "Putovanja");

            migrationBuilder.DropTable(
                name: "Smjestaj");

            migrationBuilder.DropTable(
                name: "VrstePutovanja");

            migrationBuilder.DropTable(
                name: "Zaposlenici");

            migrationBuilder.DropTable(
                name: "KorisnickiNalozi");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Gradovi");
        }
    }
}
