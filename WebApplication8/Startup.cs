using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using TuristickaAgencija.WebAPI.Services;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.Swagger;
using AutoMapper;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using TuristickaAgencija.WebAPI.Database;
using Microsoft.AspNetCore.Authentication;
using TuristickaAgencija.WebAPI.Security;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace TuristickaAgencija
{
    public class BasicAuthDocumentFilter : IDocumentFilter

    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)

        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()

   {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using
                                            //OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };

        } }
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

         
            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });

                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });

                c.DocumentFilter<BasicAuthDocumentFilter>();
            });



                services.AddAuthentication("BasicAuthentication").AddScheme
                <AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IZaposleniciService, ZaposleniciService>();
            services.AddScoped<IPutniciKorisniciService, PutniciKorisniciService>();

            //services.AddScoped<ICRUDService<Model.PutniciKorisnici, PutniciKorisniciSearchRequest, PutniciKorisniciInsertRequest, PutniciKorisniciInsertRequest>, PutniciKorisniciService>();

            services.AddScoped<ILoginService, LoginService>();

            services.AddScoped<ICRUDService<Model.Gradovi, GradoviSearchRequest, GradoviInsertRequest, GradoviInsertRequest>, GradoviService>();
            
            services.AddScoped<ICRUDService<VrstaPutovanja, object,VrstaPutovanjaInsertRequest,VrstaPutovanjaInsertRequest>,
                BaseCRUDService<VrstaPutovanja, object, VrstePutovanja,VrstaPutovanjaInsertRequest,VrstaPutovanjaInsertRequest>>();

            
            services.AddScoped<ICRUDService<Model.Putovanja, PutovanjaSearchRequest, PutovanjaInsertRequest, PutovanjaInsertRequest>, PutovanjaService>();

            services.AddScoped<ICRUDService<Model.FakultativniIzleti, FakultativniIzletiSearchRequest, FakultativniIzletiInsertRequest, FakultativniIzletiInsertRequest>,
            FakultativniIzletiService>();

            services.AddScoped<ICRUDService<Model.Smjestaj, SmjestajSearchRequest, SmjestajInsertRequest, SmjestajInsertRequest>,
            SmjestajService>();

            services.AddScoped<ICRUDService<Model.Vodici, VodicSearchRequest, VodicInsertRequest, VodicInsertRequest>, VodiciService>();



            services.AddScoped<ICRUDService<Model.Komentari, KomentariSearchRequest, KomentariInsertRequest, KomentariInsertRequest>,
            KomentariService>();
            services.AddScoped<ICRUDService<Model.Novosti, NovostiSearchRequest, NovostiInsertRequest, NovostiInsertRequest>, NovostiService>();

            services.AddScoped<IService<Model.Ocjene, object>, BaseService<Model.Ocjene, object, WebAPI.Database.Ocjene>>();

            services.AddScoped<ICRUDService<Model.OcjenePutovanja, OcjenePutovanjaSearchRequest, OcjenePutovanjaInsertRequest, OcjenePutovanjaInsertRequest>,
            OcjenePutovanjaService>();
            services.AddScoped<ICRUDService<Model.TerminiPutovanja, TerminiSearchRequest, TerminiPutovanjaInsertRequest, TerminiPutovanjaInsertRequest>, TerminiPutovanjaService>();

          
            services.AddScoped<ICRUDService<Model.PutovanjaFakultativni, PutovanjaFakultativniSearchRequest, PutovanjaFakultativniInsertRequest, PutovanjaFakultativniInsertRequest>,
            PutovanjaFakultativniService>();

            services.AddScoped<ICRUDService<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeInsertRequest, RezervacijeInsertRequest>, RezervacijeService>();

            services.AddScoped<ICRUDService<Model.TerminiVodici, TerminiVodiciSearchRequest, TerminiVodiciInsertRequest, TerminiVodiciInsertRequest>,
            TerminiVodiciService>();
           
            services.AddScoped<ICRUDService<Model.Uplate, UplateSearchRequest, UplateInsertRequest, UplateInsertRequest>, UplateService>();
            services.AddScoped<ICRUDService<Model.Pretplate, PretplateSearchRequest, PretplateInsertRequest, PretplateInsertRequest>,
            PretplateService>();
            services.AddScoped<ICRUDService<Model.Obavijesti, ObavijestiSearchRequest, ObavijestiInsertRequest, ObavijestiInsertRequest>,
            ObavijestiService>();

            var connection = @"Server=.;Database=160082;Trusted_Connection=True;";
            services.AddDbContext<MyContext>(options => options.UseSqlServer(connection));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseAuthentication();


            app.UseMvc();
        }
    }
}
