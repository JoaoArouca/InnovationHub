using Domain.Interfaces.AuxiliaryBaseModel;

namespace Domain.Models.Auxiliary
{
    public class SectorModel : IAuxiliaryBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public SectorModel(string name, Guid id)
        {
            Name = name;
            Id = id;
        }

    }
}
