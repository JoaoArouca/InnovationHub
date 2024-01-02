using Domain.Interfaces.AuxiliaryBaseModel;

namespace Domain.Models.Auxiliary
{
    public class OrganizationModel : IAuxiliaryBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public OrganizationModel(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
