using Domain.Interfaces.AuxiliaryBaseModel;

namespace Domain.Models.Auxiliary
{
    public class PartnerTypeModel : IAuxiliaryBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public PartnerTypeModel(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
