using Domain.Models.Auxiliary;

namespace Application.Repositories.Seeds
{
    public class SectorsSeed : ISeedInitializer
    {
        private static readonly List<string> _initialSectors = new()
        {

            "Aeronautics",
            "Agriculture",
            "All",
            "Arts",
            "Automotive",
            "Biotechnology",
            "Chemistry and Petrochemicals",
            "Construction and Civil Engineering",
            "Consumer Goods",
            "Cyber Security",
            "Decarbonation",
            "Digital",
            "Ecology / Environment",
            "Education",
            "Electronic",
            "Energy",
            "Financial",
            "Food and Beverage",
            "Health",
            "Industry",
            "Informatics / Cloud / Data / AI",
            "Logistics",
            "Manufacturing",
            "Materials",
            "Media",
            "Mobility",
            "Other",
            "Paper and Cellulose",
            "Pharmaceutical",
            "Sanitation and Waste",
            "Social",
            "Space, Defense",
            "Steel, Metallurgy and Mining",
            "Telecommunications",
            "Tourism",
            "Video Game / Entertainment",
            "Not specified",
        };

        public override void Initialize(InMemoryDatabase database)
        {
            List<SectorModel> sectors = new List<SectorModel>();

            foreach (string sectorName in _initialSectors)
            {
                SectorModel sector = new(sectorName, Guid.NewGuid());
                sectors.Add(sector);
            }

            database.SectorsDB.AddRange(sectors);
            database.SaveChanges();
        }
    }
}
