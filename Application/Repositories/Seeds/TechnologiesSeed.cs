using Domain.Models.Auxiliary;

namespace Application.Repositories.Seeds
{
    public class TechnologiesSeed : ISeedInitializer
    {
        private static readonly List<string> _initialTechnologies = new()
        {
            "Biotechnology",
            "ADAS - Advanced Driver Assistance Systems",
            "Biofuels",
            "Cybersecurity",
            "Smart Cities",
            "Data Science",
            "Cloud",
            "Connectivity",
            "Culture",
            "Deep Learning",
            "Decarbonization",
            "Sustainable Development",
            "Design",
            "Digital Twins",
            "Vehicle Dynamics",
            "Agricultural Devices",
            "Circular Economy",
            "Education",
            "Energy Efficiency",
            "Clean Energy",
            "Management and Governance",
            "Hydrogen",
            "Industry 4.0 or 5.0",
            "Infrastructure",
            "Artificial Intelligence",
            "IoT",
            "Logistics",
            "Machine Learning",
            "Manufacturing",
            "Materials",
            "Mobility and Transport",
            "Numerical Modeling",
            "Nanotechnology",
            "Not specified",
            "Alternative Powertrain",
            "Preservation of Water Resources",
            "Ecological Preservation/Restoration",
            "Intellectual Property",
            "Quantum",
            "Green Chemistry",
            "Sanitation and Waste",
            "Health",
            "Vehicle Safety",
            "Agroforestry Systems/ILP",
            "Social",
            "Socioenvironmental",
            "Urban Sustainability",
            "Digital Transformation",
            "Farming",
            "Water",
            "Communication",
        };

        public override void Initialize(InMemoryDatabase database)
        {
            List<TechnologyModel> technologies = new();
            foreach (string techName in _initialTechnologies)
            {
                TechnologyModel technology = new(Guid.NewGuid(), techName);
                technologies.Add(technology);
            }

            database.TechnologiesDB.AddRange(technologies);
            database.SaveChanges();
        }
    }
}
