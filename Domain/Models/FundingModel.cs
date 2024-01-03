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
        public string Region { get; set; }
        public string Institution { get; set; }
        public string Program {  get; set; }
        public string Call { get; set; }
        public string TypeOfSupport { get; set; }
        public bool IsCollaborativeProject { get; set; }
        public int MinimumTRL { get; set; }
        public int MaximumTRL { get; set; }
        public string Deadline { get; set; }
        public string Objective { get; set; }
        public string Eligibility { get; set; }
        public string Expenses { get; set; }
        public string MinAmountOfExpenses { get; set; }
        public string MaxAmountOfExpenses { get; set; }
        public string SupportTax { get; set; }
        public string Duration { get; set; }
        public string Tax { get; set; }
        public string GracePeriod { get; set; }
        public string Amortization { get; set; }
        public bool IsESG { get; set; }
        public string FundingLink { get; set; }
        public string Status { get; set; }
        public string LastRelease { get; set; }
        public string Observations { get; set; }
        public DateTime Created_At { get; set; }
        public Guid ResponsibleUserId { get; set; }
        public Guid LastReviewerUserId { get; set; }

        public FundingModel(
            string title,
            List<CountryModel> countries,
            List<OrganizationModel> organizations,
            List<SectorModel> sectors,
            List<TechnologyModel> technologies,
            List<PartnerTypeModel> partnerTypes,
            string region,
            string institution,
            string program,
            string call,
            string typeOfSupport,
            bool isCollaborativeProject,
            int minimumTRL,
            int maximumTRL,
            string deadline,
            string objective,
            string eligibility,
            string expenses,
            string minAmountOfExpenses,
            string maxAmountOfExpenses,
            string supportTax,
            string duration,
            string tax,
            string gracePeriod,
            string amortization,
            bool isESG,
            string fundingLink,
            string status,
            string lastRelease,
            string observations,
            Guid responsibleUserId,
            Guid lastReviewerUserId
        )
        {
            Id = Guid.NewGuid();
            Title = title;
            Countries = countries;
            Organizations = organizations;
            Sectors = sectors;
            Technologies = technologies;
            PartnerTypes = partnerTypes;
            Region = region;
            Institution = institution;
            Program = program;
            Call = call;
            TypeOfSupport = typeOfSupport;
            IsCollaborativeProject = isCollaborativeProject;
            MinimumTRL = minimumTRL;
            MaximumTRL = maximumTRL;
            Deadline = deadline;
            Objective = objective;
            Eligibility = eligibility;
            Expenses = expenses;
            MinAmountOfExpenses = minAmountOfExpenses;
            MaxAmountOfExpenses = maxAmountOfExpenses;
            SupportTax = supportTax;
            Duration = duration;
            Tax = tax;
            GracePeriod = gracePeriod;
            Amortization = amortization;
            IsESG = isESG;
            FundingLink = fundingLink;
            Status = status;
            LastRelease = lastRelease;
            Observations = observations;
            Created_At = DateTime.Now;
            ResponsibleUserId = responsibleUserId;
            LastReviewerUserId = lastReviewerUserId;
        }

    }
}
