using Domain.Models.Auxiliary;

namespace Application.Repositories.Seeds
{
    public static class CountriesSeed
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

        public static void Initialize(InMemoryDatabase database)
        {
            List<CountryModel> countries = new();
            foreach (string countryName in _initialCountriesNames)
            {
                CountryModel country = new(countryName, Guid.NewGuid());
                countries.Add(country);
            }

            database.AddRange(countries);
            database.SaveChanges();
        }
    }
}
