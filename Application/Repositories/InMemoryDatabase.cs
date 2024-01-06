using Domain.Models.Auxiliary;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
    public class InMemoryDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "inMemoryDatabase");
        }

        public DbSet<CountryModel> CountriesDB { get; set; }
        public DbSet<TechnologyModel> TechnologiesDB { get; set;}
        public DbSet<OrganizationModel> OrganizationsDB { get; set; }
        public DbSet<PartnerTypeModel> PartnerTypesDB { get; set; }
        public DbSet<SectorModel> SectorsDB { get; set;}
    }
}
