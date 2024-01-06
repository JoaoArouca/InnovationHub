using Domain.Models.Auxiliary;

namespace Application.Repositories.Seeds
{
    public class PartnerTypesSeed : ISeedInitializer
    {
        private static readonly List<string> _initialPartnerTypes = new()
        {
            "Company",
            "Science and Technology Institution",
            "Startup",
            "Not applicable",
            "Not specified",
        };

        public override void Initialize(InMemoryDatabase database)
        {
            List<PartnerTypeModel> partners = new();
            foreach (string partnerTypeName in _initialPartnerTypes)
            {
                PartnerTypeModel partner = new(Guid.NewGuid(), partnerTypeName);
                partners.Add(partner);
            }
            database.PartnerTypesDB.AddRange(partners);
            database.SaveChanges();
        }
    }
}
