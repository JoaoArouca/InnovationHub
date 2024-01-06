using Application.DependencyInjection;
using Application.Repositories;
using Application.Repositories.Seeds;

namespace WebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddInMemoryDatabase();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, InMemoryDatabase database)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();
            SeedGen(database);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void SeedGen(InMemoryDatabase database)
        {
            new CountriesSeed().Initialize(database);
            new TechnologiesSeed().Initialize(database);
            new PartnerTypesSeed().Initialize(database);
        }
    }
}