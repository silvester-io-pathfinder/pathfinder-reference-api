using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class FeatType : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Feat> Feats { get; set; } = new List<Feat>();
    }
}
