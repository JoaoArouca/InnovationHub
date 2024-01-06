using Domain.Models.Auxiliary;

namespace Application.Repositories.Seeds
{
    public class CountriesSeed : ISeedInitializer
    {
        private static readonly List<string> _initialCountriesNames = new()
        {
            "Brazil",
            "Canada",
            "Europe",
            "France",
            "Germany",
            "Ireland",
            "UK",
            "USA",
            "Other countries"
        };

        public override void Initialize(InMemoryDatabase database)
        {
            List<CountryModel> countries = new();
            foreach (string countryName in _initialCountriesNames)
            {
                CountryModel country = new(countryName, Guid.NewGuid());
                countries.Add(country);
            }

            database.CountriesDB.AddRange(countries);
            database.SaveChanges();
        }
    }
}
