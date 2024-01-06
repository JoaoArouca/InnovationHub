using Domain.Models.Auxiliary;

namespace Application.Repositories.Seeds
{
    public class OrganizationsSeed : ISeedInitializer
    {
        private static readonly List<string> _initialOrganizations = new()
        {
             "Big or Large",
             "All companies",
             "Medium or Intermediate",
             "Non-profitable organization",
             "Science and Technology Institution",
             "Small or SME",
             "Startup or Micro",
             "Researchers",
        };

        public override void Initialize(InMemoryDatabase database)
        {
            List<OrganizationModel> organizations = new();
            foreach (string orgName in _initialOrganizations)
            {
                OrganizationModel organization = new(Guid.NewGuid(), orgName);
                organizations.Add(organization);
            }

            database.OrganizationsDB.AddRange(organizations);
            database.SaveChanges();
        }
    }
}
