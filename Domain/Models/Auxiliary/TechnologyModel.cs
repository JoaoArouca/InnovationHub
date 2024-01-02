using Domain.Interfaces.AuxiliaryBaseModel;

namespace Domain.Models.Auxiliary
{
    public class TechnologyModel : IAuxiliaryBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TechnologyModel(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
