using Domain.Models.Auxiliary;

namespace Domain.Models
{
    public class FundingModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<CountryModel> Countries { get; set; }
        public List<OrganizationModel> Organizations { get; set; }
        public List<SectorModel> Sectors { get; set; }
        public List<TechnologyModel> Technologies { get; set; }
        public List<PartnerTypeModel> PartnerTypes { get; set; }
        public FundingModel
        (
            string title,
            List<CountryModel> countries,
            List<OrganizationModel> organization,
            List<SectorModel> sectors,
            List<TechnologyModel> technologies,
            List<PartnerTypeModel> partnerTypes
        )
        {
            Id = Guid.NewGuid();
            Title = title;
            Countries = countries;
            Organizations = organization;
            Sectors = sectors;
            Technologies = technologies;
            PartnerTypes = partnerTypes;
        }

    }
}
