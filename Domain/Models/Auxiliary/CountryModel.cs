using Domain.Interfaces.AuxiliaryBaseModel;

namespace Domain.Models.Auxiliary
{
    public class CountryModel : IAuxiliaryBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public CountryModel(string name, Guid id)
        {
            Name = name;
            Id = id;
        }
    }
}
